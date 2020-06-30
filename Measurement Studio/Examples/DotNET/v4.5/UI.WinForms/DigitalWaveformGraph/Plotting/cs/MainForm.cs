using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using NationalInstruments.UI;
using NationalInstruments.UI.WindowsForms;

namespace NationalInstruments.Examples.Plotting
{
	/// <summary>
	/// Summary description for MainForm.
	/// </summary>
	public class MainForm : System.Windows.Forms.Form
	{
        private NationalInstruments.UI.WindowsForms.DigitalWaveformGraph sampleDigitalWaveformGraph;
        private System.Windows.Forms.GroupBox randomPlottingGroupBox;
        private NationalInstruments.UI.WindowsForms.Slide numberOfPlotsSlide;
        private System.Windows.Forms.Button plotButton;
        private System.Windows.Forms.Label numberOfPlotsLabel;
        private System.Windows.Forms.Label displayModeLabel;
        private NationalInstruments.UI.WindowsForms.PropertyEditor displayModePropertyEditor;
        private System.ComponentModel.IContainer components = null;

		public MainForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
       
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.sampleDigitalWaveformGraph = new NationalInstruments.UI.WindowsForms.DigitalWaveformGraph();
            this.randomPlottingGroupBox = new System.Windows.Forms.GroupBox();
            this.numberOfPlotsLabel = new System.Windows.Forms.Label();
            this.displayModeLabel = new System.Windows.Forms.Label();
            this.displayModePropertyEditor = new NationalInstruments.UI.WindowsForms.PropertyEditor();
            this.plotButton = new System.Windows.Forms.Button();
            this.numberOfPlotsSlide = new NationalInstruments.UI.WindowsForms.Slide();
            ((System.ComponentModel.ISupportInitialize)(this.sampleDigitalWaveformGraph)).BeginInit();
            this.randomPlottingGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfPlotsSlide)).BeginInit();
            this.SuspendLayout();
            // 
            // sampleDigitalWaveformGraph
            // 
            this.sampleDigitalWaveformGraph.Caption = "Digital Waveform Graph";
            this.sampleDigitalWaveformGraph.Dock = System.Windows.Forms.DockStyle.Top;
            this.sampleDigitalWaveformGraph.Location = new System.Drawing.Point(5, 5);
            this.sampleDigitalWaveformGraph.Name = "sampleDigitalWaveformGraph";
            this.sampleDigitalWaveformGraph.Size = new System.Drawing.Size(420, 252);
            this.sampleDigitalWaveformGraph.TabIndex = 0;
            // 
            // randomPlottingGroupBox
            // 
            this.randomPlottingGroupBox.Controls.Add(this.numberOfPlotsLabel);
            this.randomPlottingGroupBox.Controls.Add(this.displayModeLabel);
            this.randomPlottingGroupBox.Controls.Add(this.displayModePropertyEditor);
            this.randomPlottingGroupBox.Controls.Add(this.plotButton);
            this.randomPlottingGroupBox.Controls.Add(this.numberOfPlotsSlide);
            this.randomPlottingGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.randomPlottingGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.randomPlottingGroupBox.Location = new System.Drawing.Point(5, 257);
            this.randomPlottingGroupBox.Name = "randomPlottingGroupBox";
            this.randomPlottingGroupBox.Size = new System.Drawing.Size(420, 136);
            this.randomPlottingGroupBox.TabIndex = 3;
            this.randomPlottingGroupBox.TabStop = false;
            this.randomPlottingGroupBox.Text = "Random Plotting";
            // 
            // numberOfPlotsLabel
            // 
            this.numberOfPlotsLabel.AutoSize = true;
            this.numberOfPlotsLabel.Location = new System.Drawing.Point(8, 23);
            this.numberOfPlotsLabel.Name = "numberOfPlotsLabel";
            this.numberOfPlotsLabel.Size = new System.Drawing.Size(108, 13);
            this.numberOfPlotsLabel.TabIndex = 8;
            this.numberOfPlotsLabel.Text = "Number Of Bus Plots:";
            // 
            // displayModeLabel
            // 
            this.displayModeLabel.AutoSize = true;
            this.displayModeLabel.Location = new System.Drawing.Point(240, 23);
            this.displayModeLabel.Name = "displayModeLabel";
            this.displayModeLabel.Size = new System.Drawing.Size(74, 13);
            this.displayModeLabel.TabIndex = 7;
            this.displayModeLabel.Text = "Display Mode:";
            // 
            // displayModePropertyEditor
            // 
            this.displayModePropertyEditor.Location = new System.Drawing.Point(240, 44);
            this.displayModePropertyEditor.Name = "displayModePropertyEditor";
            this.displayModePropertyEditor.Size = new System.Drawing.Size(168, 20);
            this.displayModePropertyEditor.Source = new NationalInstruments.UI.PropertyEditorSource(this.sampleDigitalWaveformGraph, "DisplayMode");
            this.displayModePropertyEditor.TabIndex = 3;
            // 
            // plotButton
            // 
            this.plotButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.plotButton.Location = new System.Drawing.Point(138, 96);
            this.plotButton.Name = "plotButton";
            this.plotButton.Size = new System.Drawing.Size(144, 32);
            this.plotButton.TabIndex = 4;
            this.plotButton.Text = "Plot";
            this.plotButton.Click += new System.EventHandler(this.OnPlotData);
            // 
            // numberOfPlotsSlide
            // 
            this.numberOfPlotsSlide.AutoDivisionSpacing = false;
            this.numberOfPlotsSlide.CoercionMode = NationalInstruments.UI.NumericCoercionMode.ToDivisions;
            this.numberOfPlotsSlide.FillBackColor = System.Drawing.Color.Transparent;
            this.numberOfPlotsSlide.FillColor = System.Drawing.Color.Transparent;
            this.numberOfPlotsSlide.Location = new System.Drawing.Point(8, 42);
            this.numberOfPlotsSlide.MajorDivisions.Interval = 1;
            this.numberOfPlotsSlide.MajorDivisions.LabelFormat = new NationalInstruments.UI.FormatString(NationalInstruments.UI.FormatStringMode.Numeric, "F0");
            this.numberOfPlotsSlide.Name = "numberOfPlotsSlide";
            this.numberOfPlotsSlide.Range = new NationalInstruments.UI.Range(1, 5);
            this.numberOfPlotsSlide.ScaleBaseLineVisible = true;
            this.numberOfPlotsSlide.ScalePosition = NationalInstruments.UI.NumericScalePosition.Bottom;
            this.numberOfPlotsSlide.Size = new System.Drawing.Size(168, 40);
            this.numberOfPlotsSlide.SlideStyle = NationalInstruments.UI.SlideStyle.SunkenWithGrip;
            this.numberOfPlotsSlide.TabIndex = 1;
            this.numberOfPlotsSlide.Value = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(430, 398);
            this.Controls.Add(this.randomPlottingGroupBox);
            this.Controls.Add(this.sampleDigitalWaveformGraph);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plotting Example";
            ((System.ComponentModel.ISupportInitialize)(this.sampleDigitalWaveformGraph)).EndInit();
            this.randomPlottingGroupBox.ResumeLayout(false);
            this.randomPlottingGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfPlotsSlide)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.EnableVisualStyles();
            Application.DoEvents();
            Application.Run(new MainForm());
		}
        
        private static DigitalWaveform CreateRandomWaveform(int sampleCount, int signalCount)
        {
            Random rand = new Random((int)DateTime.Now.Ticks);			
            double randValue;
            DigitalState state;
            DigitalWaveform wave = new DigitalWaveform(sampleCount, signalCount);
            for(int s = 0; s < sampleCount; s++)
                for(int l = 0; l < signalCount; l++)
                {
                    randValue = rand.NextDouble();
                    if(randValue < .4875)
                        state = DigitalState.ForceUp;
                    else if(randValue < .975)
                        state = DigitalState.ForceDown;
                    else if(randValue < .9875)
                        state = DigitalState.ForceOff;
                    else
                        state = DigitalState.CompareUnknown;

                    wave.Samples[s].States[l] = state;
                }
            return wave;
        }

        private void OnPlotData(object sender, System.EventArgs e)
        {
            DigitalWaveform[] busPlots = new DigitalWaveform[(int)numberOfPlotsSlide.Value];
            Random rand = new Random();
            
            for(int i = 0; i < numberOfPlotsSlide.Value; i++)
            {
                busPlots[i] = CreateRandomWaveform(rand.Next(25, 30), rand.Next(3,8));
            }
            
            sampleDigitalWaveformGraph.PlotWaveforms(busPlots);
        }
 	}
   
}
