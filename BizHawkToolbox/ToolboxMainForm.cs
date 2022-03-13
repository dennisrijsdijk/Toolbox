using BizHawk.Client.Common;
using BizHawk.Client.EmuHawk;
using System.Windows.Forms;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace BizHawkToolbox
{
	[ExternalTool("BizHawkToolbox")]
	public partial class ToolboxMainForm : ToolFormBase, IExternalToolForm
	{
		protected override string WindowTitleStatic => "BizHawk Toolbox";

		private ColorInvert _colorInvert;
		
		#region ColorShifts

		private byte _alphaShift
		{
			get => (byte)(_colorInvert.ColorShift >> 24 & byte.MaxValue);
			set => _colorInvert.ColorShift = _colorInvert.ColorShift & 0x00FFFFFF | Convert.ToInt32((uint)value) << 24;
		}
		private byte _redShift
		{
			get => (byte)(_colorInvert.ColorShift >> 16 & byte.MaxValue);
			set => _colorInvert.ColorShift = (int)(_colorInvert.ColorShift & 0xFF00FFFF | Convert.ToInt32((uint)value) << 16);
		}
		
		private byte _greenShift
		{
			get => (byte)(_colorInvert.ColorShift >> 8 & byte.MaxValue);
			set => _colorInvert.ColorShift = (int)(_colorInvert.ColorShift & 0xFFFF00FF | Convert.ToInt32((uint)value) << 8);
		}
		
		private byte _blueShift
		{
			get => (byte)(_colorInvert.ColorShift & byte.MaxValue);
			set => _colorInvert.ColorShift = (int)(_colorInvert.ColorShift & 0xFFFFFF00 | Convert.ToInt32((uint)value));
		}
		
		#endregion
		
		public ToolboxMainForm()
		{
			InitializeComponent();
			_colorInvert = new ColorInvert();
		}
		
		public ApiContainer ApiContainer
		{
			get => APIs.ApiContainer;
			set => APIs.Update(value);
		}
		
		#region Overrides
		
		public override void Restart()
		{
			APIs.Update(MainForm);
		}

		protected override void UpdateBefore()
		{
			base.UpdateBefore();
		}

		protected override void FastUpdateBefore() => UpdateBefore();

		protected override void UpdateAfter()
		{
			base.UpdateAfter();
			_colorInvert.UpdateAfter();
			AlphaValueLabel.Text = _alphaShift.ToString("X2");
			RedValueLabel.Text = _redShift.ToString("X2");
			GreenValueLabel.Text = _greenShift.ToString("X2");
			BlueValueLabel.Text = _blueShift.ToString("X2");
		}
		
		protected override void FastUpdateAfter() => UpdateAfter();
		
		#endregion
		
		#region Events

		private void ToolboxMainForm_Load(object sender, EventArgs e) { }

		private void ToolboxMainForm_FormClosing(object sender, FormClosingEventArgs e) { }
		
		#endregion

		#region ColorButtons
		
		private void AlphaUp_Click(object sender, EventArgs e) => _alphaShift++;

		private void RedUp_Click(object sender, EventArgs e) => _redShift++;

		private void GreenUp_Click(object sender, EventArgs e) => _greenShift++;

		private void BlueUp_Click(object sender, EventArgs e) => _blueShift++;

		private void AlphaDown_Click(object sender, EventArgs e) => _alphaShift--;

		private void RedDown_Click(object sender, EventArgs e) => _redShift--;

		private void GreenDown_Click(object sender, EventArgs e) => _greenShift--;

		private void BlueDown_Click(object sender, EventArgs e) => _blueShift--;
		
		private void AlphaUpBig_Click(object sender, EventArgs e) => _alphaShift += 0x10;

		private void RedUpBig_Click(object sender, EventArgs e) => _redShift += 0x10;

		private void GreenUpBig_Click(object sender, EventArgs e) => _greenShift += 0x10;

		private void BlueUpBig_Click(object sender, EventArgs e) => _blueShift += 0x10;

		private void AlphaDownBig_Click(object sender, EventArgs e) => _alphaShift -= 0x10;

		private void RedDownBig_Click(object sender, EventArgs e) => _redShift -= 0x10;

		private void GreenDownBig_Click(object sender, EventArgs e) => _greenShift -= 0x10;

		private void BlueDownBig_Click(object sender, EventArgs e) => _blueShift -= 0x10;

		#endregion

		private void StartColorShift_Click(object sender, EventArgs e)
		{
			_colorInvert.EffectStatus = EffectStatus.Starting;
		}

		private void StopColorShift_Click(object sender, EventArgs e)
		{
			_colorInvert.EffectStatus = EffectStatus.Stopping;
		}

		private void EnableColorShift_Click(object sender, EventArgs e)
		{
			_colorInvert.EffectStatus = EffectStatus.Running;
		}

		private void DisableColorShift_Click(object sender, EventArgs e)
		{
			_colorInvert.EffectStatus = EffectStatus.Stopped;
		}
	}
}