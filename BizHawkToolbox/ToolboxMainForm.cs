using BizHawk.Client.Common;
using BizHawk.Client.EmuHawk;
using System.Windows.Forms;
using System;

namespace BizHawkToolbox
{
	[ExternalTool("BizHawkToolbox")]
	public partial class ToolboxMainForm : ToolFormBase, IExternalToolForm
	{
		protected override string WindowTitleStatic => "BizHawk Toolbox";
		
		public ToolboxMainForm()
		{
			InitializeComponent();
		}
		
		public ApiContainer ApiContainer
		{
			get => APIs.ApiContainer;
			set => APIs.Update(value);
		}
		
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
		}
		
		protected override void FastUpdateAfter() => UpdateAfter();

		private void ToolboxMainForm_Load(object sender, EventArgs e) { }

		private void ToolboxMainForm_FormClosing(object sender, FormClosingEventArgs e) { }
	}
}