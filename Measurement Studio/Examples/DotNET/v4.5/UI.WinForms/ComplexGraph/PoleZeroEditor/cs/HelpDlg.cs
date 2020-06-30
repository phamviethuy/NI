using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;
using System.IO;

namespace NationalInstruments.Examples.PoleZeroEditor
{
    public class HelpDlg : System.Windows.Forms.Form
    {
        private System.Windows.Forms.PictureBox measurementStudioPictureBox;
		private System.Windows.Forms.Label helpContentsLabel;
        private System.ComponentModel.Container components = null;

        public HelpDlg()
        {
            InitializeComponent();
			UpdateHelpBox();
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpDlg));
            this.measurementStudioPictureBox = new System.Windows.Forms.PictureBox();
            this.helpContentsLabel = new System.Windows.Forms.Label();
#if NETFX2_0
            ((System.ComponentModel.ISupportInitialize)(this.measurementStudioPictureBox)).BeginInit();
#endif
            this.SuspendLayout();
            // 
            // helpContentsLabel
            // 
            this.helpContentsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.helpContentsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.helpContentsLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpContentsLabel.Location = new System.Drawing.Point(0, 0);
            this.helpContentsLabel.Name = "helpContentsLabel";
            this.helpContentsLabel.Size = new System.Drawing.Size(558, 315);
            this.helpContentsLabel.TabIndex = 1;
            // 
            // HelpDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(558, 315);
            this.Controls.Add(this.helpContentsLabel);
            this.Controls.Add(this.measurementStudioPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HelpDlg";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pole-Zero Editor Help";
#if NETFX2_0
            ((System.ComponentModel.ISupportInitialize)(this.measurementStudioPictureBox)).EndInit();
#endif
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

		private void UpdateHelpBox()
		{
			string overview =  "Introduction:\r\n\r\nThe Pole-Zero Editor is a tool that gives useful insights into the response of a filter."
						+" This tool assists in complex analysis of a system with respect to its stability and can be used as a basis for filter design.\r\n\r\n";
			
			string usingTool = "Using the Tool:\r\n\r\nThe Pole-Zero Editor assists users to create linear systems using a pole-zero plot. "
						+"Using the tool, one can interactively plot poles and zeros in the complex plane. "
						+"The filter characteristics of the system is updated as the user manipulates the poles and the zeros.\r\n\r\n"
						+"Operations can be performed on individual poles/zeros or a group of them. The 'Select' menu item or the context menu has options to determine how poles and zeros can be selected. "
						+"The poles and the zeros can be moved, added or deleted by using the context menu, main menu items or via the list entries."; 
										
			helpContentsLabel.Text = overview + "\r\n" + usingTool;
		}
    }
}

