using System.ComponentModel;

namespace BizHawkToolbox
{
	partial class ToolboxMainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}

			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.RedUp = new System.Windows.Forms.Button();
			this.GreenUp = new System.Windows.Forms.Button();
			this.BlueUp = new System.Windows.Forms.Button();
			this.RedValueLabel = new System.Windows.Forms.Label();
			this.GreenValueLabel = new System.Windows.Forms.Label();
			this.BlueValueLabel = new System.Windows.Forms.Label();
			this.RedDown = new System.Windows.Forms.Button();
			this.GreenDown = new System.Windows.Forms.Button();
			this.BlueDown = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.StartColorShift = new System.Windows.Forms.Button();
			this.StopColorShift = new System.Windows.Forms.Button();
			this.EnableColorShift = new System.Windows.Forms.Button();
			this.DisableColorShift = new System.Windows.Forms.Button();
			this.BlueDownBig = new System.Windows.Forms.Button();
			this.GreenDownBig = new System.Windows.Forms.Button();
			this.RedDownBig = new System.Windows.Forms.Button();
			this.RedUpBig = new System.Windows.Forms.Button();
			this.GreenUpBig = new System.Windows.Forms.Button();
			this.BlueUpBig = new System.Windows.Forms.Button();
			this.ColorChangeGroupBox = new System.Windows.Forms.GroupBox();
			this.ColorChangeGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// RedUp
			// 
			this.RedUp.Location = new System.Drawing.Point(46, 34);
			this.RedUp.Name = "RedUp";
			this.RedUp.Size = new System.Drawing.Size(35, 23);
			this.RedUp.TabIndex = 1;
			this.RedUp.Text = "+";
			this.RedUp.UseVisualStyleBackColor = true;
			this.RedUp.Click += new System.EventHandler(this.RedUp_Click);
			// 
			// GreenUp
			// 
			this.GreenUp.Location = new System.Drawing.Point(127, 34);
			this.GreenUp.Name = "GreenUp";
			this.GreenUp.Size = new System.Drawing.Size(35, 23);
			this.GreenUp.TabIndex = 3;
			this.GreenUp.Text = "+";
			this.GreenUp.UseVisualStyleBackColor = true;
			this.GreenUp.Click += new System.EventHandler(this.GreenUp_Click);
			// 
			// BlueUp
			// 
			this.BlueUp.Location = new System.Drawing.Point(208, 34);
			this.BlueUp.Name = "BlueUp";
			this.BlueUp.Size = new System.Drawing.Size(35, 23);
			this.BlueUp.TabIndex = 4;
			this.BlueUp.Text = "+";
			this.BlueUp.UseVisualStyleBackColor = true;
			this.BlueUp.Click += new System.EventHandler(this.BlueUp_Click);
			// 
			// RedValueLabel
			// 
			this.RedValueLabel.Location = new System.Drawing.Point(6, 60);
			this.RedValueLabel.Name = "RedValueLabel";
			this.RedValueLabel.Size = new System.Drawing.Size(75, 15);
			this.RedValueLabel.TabIndex = 6;
			this.RedValueLabel.Text = "0x00";
			this.RedValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// GreenValueLabel
			// 
			this.GreenValueLabel.Location = new System.Drawing.Point(87, 60);
			this.GreenValueLabel.Name = "GreenValueLabel";
			this.GreenValueLabel.Size = new System.Drawing.Size(75, 15);
			this.GreenValueLabel.TabIndex = 7;
			this.GreenValueLabel.Text = "0x00";
			this.GreenValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// BlueValueLabel
			// 
			this.BlueValueLabel.Location = new System.Drawing.Point(168, 60);
			this.BlueValueLabel.Name = "BlueValueLabel";
			this.BlueValueLabel.Size = new System.Drawing.Size(75, 15);
			this.BlueValueLabel.TabIndex = 8;
			this.BlueValueLabel.Text = "0x00";
			this.BlueValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// RedDown
			// 
			this.RedDown.Location = new System.Drawing.Point(46, 78);
			this.RedDown.Name = "RedDown";
			this.RedDown.Size = new System.Drawing.Size(35, 23);
			this.RedDown.TabIndex = 10;
			this.RedDown.Text = "-";
			this.RedDown.UseVisualStyleBackColor = true;
			this.RedDown.Click += new System.EventHandler(this.RedDown_Click);
			// 
			// GreenDown
			// 
			this.GreenDown.Location = new System.Drawing.Point(127, 78);
			this.GreenDown.Name = "GreenDown";
			this.GreenDown.Size = new System.Drawing.Size(35, 23);
			this.GreenDown.TabIndex = 11;
			this.GreenDown.Text = "-";
			this.GreenDown.UseVisualStyleBackColor = true;
			this.GreenDown.Click += new System.EventHandler(this.GreenDown_Click);
			// 
			// BlueDown
			// 
			this.BlueDown.Location = new System.Drawing.Point(208, 78);
			this.BlueDown.Name = "BlueDown";
			this.BlueDown.Size = new System.Drawing.Size(35, 23);
			this.BlueDown.TabIndex = 12;
			this.BlueDown.Text = "-";
			this.BlueDown.UseVisualStyleBackColor = true;
			this.BlueDown.Click += new System.EventHandler(this.BlueDown_Click);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(6, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(75, 15);
			this.label2.TabIndex = 14;
			this.label2.Text = "Red";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(87, 16);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(75, 15);
			this.label3.TabIndex = 15;
			this.label3.Text = "Green";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(168, 16);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(75, 15);
			this.label4.TabIndex = 16;
			this.label4.Text = "Blue";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// StartColorShift
			// 
			this.StartColorShift.Location = new System.Drawing.Point(6, 107);
			this.StartColorShift.Name = "StartColorShift";
			this.StartColorShift.Size = new System.Drawing.Size(55, 23);
			this.StartColorShift.TabIndex = 17;
			this.StartColorShift.Text = "Start";
			this.StartColorShift.UseVisualStyleBackColor = true;
			this.StartColorShift.Click += new System.EventHandler(this.StartColorShift_Click);
			// 
			// StopColorShift
			// 
			this.StopColorShift.Location = new System.Drawing.Point(67, 107);
			this.StopColorShift.Name = "StopColorShift";
			this.StopColorShift.Size = new System.Drawing.Size(55, 23);
			this.StopColorShift.TabIndex = 18;
			this.StopColorShift.Text = "Stop";
			this.StopColorShift.UseVisualStyleBackColor = true;
			this.StopColorShift.Click += new System.EventHandler(this.StopColorShift_Click);
			// 
			// EnableColorShift
			// 
			this.EnableColorShift.Location = new System.Drawing.Point(127, 107);
			this.EnableColorShift.Name = "EnableColorShift";
			this.EnableColorShift.Size = new System.Drawing.Size(55, 23);
			this.EnableColorShift.TabIndex = 19;
			this.EnableColorShift.Text = "Enable";
			this.EnableColorShift.UseVisualStyleBackColor = true;
			this.EnableColorShift.Click += new System.EventHandler(this.EnableColorShift_Click);
			// 
			// DisableColorShift
			// 
			this.DisableColorShift.Location = new System.Drawing.Point(188, 107);
			this.DisableColorShift.Name = "DisableColorShift";
			this.DisableColorShift.Size = new System.Drawing.Size(55, 23);
			this.DisableColorShift.TabIndex = 20;
			this.DisableColorShift.Text = "Disable";
			this.DisableColorShift.UseVisualStyleBackColor = true;
			this.DisableColorShift.Click += new System.EventHandler(this.DisableColorShift_Click);
			// 
			// BlueDownBig
			// 
			this.BlueDownBig.Location = new System.Drawing.Point(168, 78);
			this.BlueDownBig.Name = "BlueDownBig";
			this.BlueDownBig.Size = new System.Drawing.Size(35, 23);
			this.BlueDownBig.TabIndex = 22;
			this.BlueDownBig.Text = "--";
			this.BlueDownBig.UseVisualStyleBackColor = true;
			this.BlueDownBig.Click += new System.EventHandler(this.BlueDownBig_Click);
			// 
			// GreenDownBig
			// 
			this.GreenDownBig.Location = new System.Drawing.Point(87, 78);
			this.GreenDownBig.Name = "GreenDownBig";
			this.GreenDownBig.Size = new System.Drawing.Size(35, 23);
			this.GreenDownBig.TabIndex = 23;
			this.GreenDownBig.Text = "--";
			this.GreenDownBig.UseVisualStyleBackColor = true;
			this.GreenDownBig.Click += new System.EventHandler(this.GreenDownBig_Click);
			// 
			// RedDownBig
			// 
			this.RedDownBig.Location = new System.Drawing.Point(6, 78);
			this.RedDownBig.Name = "RedDownBig";
			this.RedDownBig.Size = new System.Drawing.Size(35, 23);
			this.RedDownBig.TabIndex = 24;
			this.RedDownBig.Text = "--";
			this.RedDownBig.UseVisualStyleBackColor = true;
			this.RedDownBig.Click += new System.EventHandler(this.RedDownBig_Click);
			// 
			// RedUpBig
			// 
			this.RedUpBig.Location = new System.Drawing.Point(6, 34);
			this.RedUpBig.Name = "RedUpBig";
			this.RedUpBig.Size = new System.Drawing.Size(35, 23);
			this.RedUpBig.TabIndex = 26;
			this.RedUpBig.Text = "++";
			this.RedUpBig.UseVisualStyleBackColor = true;
			this.RedUpBig.Click += new System.EventHandler(this.RedUpBig_Click);
			// 
			// GreenUpBig
			// 
			this.GreenUpBig.Location = new System.Drawing.Point(87, 34);
			this.GreenUpBig.Name = "GreenUpBig";
			this.GreenUpBig.Size = new System.Drawing.Size(35, 23);
			this.GreenUpBig.TabIndex = 27;
			this.GreenUpBig.Text = "++";
			this.GreenUpBig.UseVisualStyleBackColor = true;
			this.GreenUpBig.Click += new System.EventHandler(this.GreenUpBig_Click);
			// 
			// BlueUpBig
			// 
			this.BlueUpBig.Location = new System.Drawing.Point(168, 34);
			this.BlueUpBig.Name = "BlueUpBig";
			this.BlueUpBig.Size = new System.Drawing.Size(35, 23);
			this.BlueUpBig.TabIndex = 28;
			this.BlueUpBig.Text = "++";
			this.BlueUpBig.UseVisualStyleBackColor = true;
			this.BlueUpBig.Click += new System.EventHandler(this.BlueUpBig_Click);
			// 
			// ColorChangeGroupBox
			// 
			this.ColorChangeGroupBox.Controls.Add(this.label2);
			this.ColorChangeGroupBox.Controls.Add(this.BlueUpBig);
			this.ColorChangeGroupBox.Controls.Add(this.RedUp);
			this.ColorChangeGroupBox.Controls.Add(this.GreenUpBig);
			this.ColorChangeGroupBox.Controls.Add(this.GreenUp);
			this.ColorChangeGroupBox.Controls.Add(this.RedUpBig);
			this.ColorChangeGroupBox.Controls.Add(this.BlueUp);
			this.ColorChangeGroupBox.Controls.Add(this.RedDownBig);
			this.ColorChangeGroupBox.Controls.Add(this.RedValueLabel);
			this.ColorChangeGroupBox.Controls.Add(this.GreenDownBig);
			this.ColorChangeGroupBox.Controls.Add(this.GreenValueLabel);
			this.ColorChangeGroupBox.Controls.Add(this.BlueDownBig);
			this.ColorChangeGroupBox.Controls.Add(this.BlueValueLabel);
			this.ColorChangeGroupBox.Controls.Add(this.DisableColorShift);
			this.ColorChangeGroupBox.Controls.Add(this.RedDown);
			this.ColorChangeGroupBox.Controls.Add(this.EnableColorShift);
			this.ColorChangeGroupBox.Controls.Add(this.GreenDown);
			this.ColorChangeGroupBox.Controls.Add(this.StopColorShift);
			this.ColorChangeGroupBox.Controls.Add(this.BlueDown);
			this.ColorChangeGroupBox.Controls.Add(this.StartColorShift);
			this.ColorChangeGroupBox.Controls.Add(this.label3);
			this.ColorChangeGroupBox.Controls.Add(this.label4);
			this.ColorChangeGroupBox.Location = new System.Drawing.Point(12, 12);
			this.ColorChangeGroupBox.Name = "ColorChangeGroupBox";
			this.ColorChangeGroupBox.Size = new System.Drawing.Size(246, 136);
			this.ColorChangeGroupBox.TabIndex = 29;
			this.ColorChangeGroupBox.TabStop = false;
			this.ColorChangeGroupBox.Text = "Framebuffer Color Manipulation";
			// 
			// ToolboxMainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.ColorChangeGroupBox);
			this.Location = new System.Drawing.Point(15, 15);
			this.Name = "ToolboxMainForm";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ToolboxMainForm_FormClosing);
			this.Load += new System.EventHandler(this.ToolboxMainForm_Load);
			this.ColorChangeGroupBox.ResumeLayout(false);
			this.ResumeLayout(false);
		}

		private System.Windows.Forms.GroupBox ColorChangeGroupBox;

		private System.Windows.Forms.Button BlueDownBig;
		private System.Windows.Forms.Button GreenDownBig;
		private System.Windows.Forms.Button RedDownBig;
		private System.Windows.Forms.Button RedUpBig;
		private System.Windows.Forms.Button GreenUpBig;
		private System.Windows.Forms.Button BlueUpBig;

		private System.Windows.Forms.Button StartColorShift;
		private System.Windows.Forms.Button StopColorShift;
		private System.Windows.Forms.Button EnableColorShift;
		private System.Windows.Forms.Button DisableColorShift;

		private System.Windows.Forms.Label BlueValueLabel;

		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;

		private System.Windows.Forms.Button RedUp;
		private System.Windows.Forms.Button GreenUp;
		private System.Windows.Forms.Button BlueUp;
		private System.Windows.Forms.Label RedValueLabel;
		private System.Windows.Forms.Label GreenValueLabel;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button RedDown;
		private System.Windows.Forms.Button GreenDown;
		private System.Windows.Forms.Button BlueDown;

		#endregion
	}
}