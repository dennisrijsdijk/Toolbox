using BizHawk.Emulation.Common;

namespace BizHawkToolbox
{
	public class ColorInvert
	{
		public EffectStatus EffectStatus { get; set; }
		public int ColorShift { get; set; } // Color value (int32 ARGB) that gets shifted into the framebuffer color
		private int ColorModifier { get; set; }

		public ColorInvert()
		{
			EffectStatus = EffectStatus.Stopped;
			ColorShift = 0;
			ColorModifier = 0x020202;
		}

		public void UpdateAfter()
		{
			if (EffectStatus == EffectStatus.Stopped)
			{
				return;
			}

			IVideoProvider vp = (IVideoProvider)APIs.MainForm.GetMemberValue("_currentVideoProvider");
			int[] buffer = vp.GetVideoBuffer();
			for (int ii = 0; ii < buffer.Length; ii++)
			{
				buffer[ii] ^= ColorShift;
			}

			vp.PopulateFromBuffer(buffer);
			
			if (ColorShift < 0xFFFFFF && EffectStatus == EffectStatus.Starting)
			{
				ColorShift += ColorModifier;
			}
			
			if (ColorShift > 0xFFFFFF && EffectStatus == EffectStatus.Starting)
			{
				ColorShift = 0xFFFFFF;
				EffectStatus = EffectStatus.Running;
			}

			if (EffectStatus == EffectStatus.Stopping && ColorShift <= 0x000000)
			{
				EffectStatus = EffectStatus.Stopped;
			}
			else if (EffectStatus == EffectStatus.Stopping)
			{
				ColorShift -= ColorModifier;
				if (ColorShift < 0)
				{
					ColorShift = 0;
				}
			}
		}
	}
}