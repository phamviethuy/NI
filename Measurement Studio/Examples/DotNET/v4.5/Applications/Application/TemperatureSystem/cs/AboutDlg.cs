//==================================================================================================
//
//  Title       : AboutDlg.cs
//  Purpose     :
//
//==================================================================================================

using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;
using System.IO;

namespace NationalInstruments.Examples.TemperatureSystem
{
    public class AboutDlg : System.Windows.Forms.Form
    {
        private System.Windows.Forms.PictureBox mstudioPictureBox;
		private System.Windows.Forms.Button okButton;
		private System.Windows.Forms.Label temperatureSystemLabel;
		private System.Windows.Forms.Label copyrightLabel;
        private System.ComponentModel.Container components = null;

        public AboutDlg()
        {
            InitializeComponent();
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutDlg));
            this.mstudioPictureBox = new System.Windows.Forms.PictureBox();
            this.okButton = new System.Windows.Forms.Button();
            this.temperatureSystemLabel = new System.Windows.Forms.Label();
            this.copyrightLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.mstudioPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mstudioPictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.mstudioPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.mstudioPictureBox.Location = new System.Drawing.Point(0, 0);
            this.mstudioPictureBox.Name = "pictureBox";
            this.mstudioPictureBox.Size = new System.Drawing.Size(184, 192);
            this.mstudioPictureBox.TabIndex = 0;
            this.mstudioPictureBox.TabStop = false;
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.okButton.Location = new System.Drawing.Point(244, 148);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(100, 23);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "OK";
            // 
            // temperatureSystemLabel
            // 
            this.temperatureSystemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temperatureSystemLabel.Location = new System.Drawing.Point(196, 32);
            this.temperatureSystemLabel.Name = "temperatureSystemLabel";
            this.temperatureSystemLabel.Size = new System.Drawing.Size(224, 23);
            this.temperatureSystemLabel.TabIndex = 2;
            this.temperatureSystemLabel.Text = "Temperature System Demo";
            // 
            // copyrightLabel
            // 
            this.copyrightLabel.Location = new System.Drawing.Point(200, 76);
            this.copyrightLabel.Name = "copyrightLabel";
            this.copyrightLabel.Size = new System.Drawing.Size(104, 23);
            this.copyrightLabel.TabIndex = 3;
            this.copyrightLabel.Text = "Copyright (C) 2004";
            // 
            // AboutDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.okButton;
            this.ClientSize = new System.Drawing.Size(426, 192);
            this.Controls.Add(this.copyrightLabel);
            this.Controls.Add(this.temperatureSystemLabel);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.mstudioPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutDlg";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About Temperature System";
            this.ResumeLayout(false);

		}
        #endregion

        //==========================================================================================
        /// <summary>
        /// Releases the resources used by the component.
        /// </summary>
        /// <param name="disposing">
        /// If <see langword="true"/>, this method releases managed and unmanaged resources.  If <see langword="false"/>, this method releases only
        /// unmanaged resources.
        /// </param>
        //==========================================================================================
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                    components.Dispose();
            }

            base.Dispose(disposing);
        }
    }
}

