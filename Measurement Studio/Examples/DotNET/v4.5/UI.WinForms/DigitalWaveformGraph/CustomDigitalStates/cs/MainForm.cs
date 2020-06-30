using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using NationalInstruments;
using NationalInstruments.UI;


namespace NationalInstruments.Examples.CustomDigitalStates
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class MainForm : System.Windows.Forms.Form
	{
		private NationalInstruments.UI.WindowsForms.DigitalWaveformGraph sampleDigitalWaveformGraph;
		private System.Windows.Forms.RadioButton customSignalStateRadioButton;
		private System.Windows.Forms.RadioButton defaultSignalStateRadioButton;
		private System.Windows.Forms.RadioButton customWaveformStateRadioButton;
		private System.Windows.Forms.RadioButton defaultWaveformStateRadioButton;
		private System.ComponentModel.IContainer components;

		private NationalInstruments.UI.DigitalWaveformPlot digitalWaveformPlot1;
		private NationalInstruments.UI.DigitalSignalPlot digitalSignalPlot1;
		private System.Windows.Forms.Panel settingsPanel;
		private System.Windows.Forms.GroupBox signalStateGroupBox;
		private System.Windows.Forms.GroupBox waveformStateGroupBox;
		private System.Windows.Forms.Splitter vertSplitter;
		private System.Windows.Forms.Button plotButton;
		private System.Windows.Forms.ImageList plotButtonImageList;
		private System.Windows.Forms.Label plottingLabel;
		private System.Windows.Forms.Timer plottingTimer;
	
		public MainForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			plottingTimer_Tick(this, EventArgs.Empty);
			OnSignalStateStyleChanged(this, EventArgs.Empty);

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.sampleDigitalWaveformGraph = new NationalInstruments.UI.WindowsForms.DigitalWaveformGraph();
            this.digitalWaveformPlot1 = new NationalInstruments.UI.DigitalWaveformPlot();
            this.digitalSignalPlot1 = new NationalInstruments.UI.DigitalSignalPlot();
            this.settingsPanel = new System.Windows.Forms.Panel();
            this.plotButton = new System.Windows.Forms.Button();
            this.plotButtonImageList = new System.Windows.Forms.ImageList(this.components);
            this.signalStateGroupBox = new System.Windows.Forms.GroupBox();
            this.customSignalStateRadioButton = new System.Windows.Forms.RadioButton();
            this.defaultSignalStateRadioButton = new System.Windows.Forms.RadioButton();
            this.waveformStateGroupBox = new System.Windows.Forms.GroupBox();
            this.customWaveformStateRadioButton = new System.Windows.Forms.RadioButton();
            this.defaultWaveformStateRadioButton = new System.Windows.Forms.RadioButton();
            this.plottingLabel = new System.Windows.Forms.Label();
            this.vertSplitter = new System.Windows.Forms.Splitter();
            this.plottingTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sampleDigitalWaveformGraph)).BeginInit();
            this.settingsPanel.SuspendLayout();
            this.signalStateGroupBox.SuspendLayout();
            this.waveformStateGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // sampleDigitalWaveformGraph
            // 
            this.sampleDigitalWaveformGraph.Caption = "Digital Waveform Graph";
            this.sampleDigitalWaveformGraph.Dock = System.Windows.Forms.DockStyle.Right;
            this.sampleDigitalWaveformGraph.Location = new System.Drawing.Point(180, 4);
            this.sampleDigitalWaveformGraph.Name = "sampleDigitalWaveformGraph";
            this.sampleDigitalWaveformGraph.Plots.AddRange(new NationalInstruments.UI.DigitalWaveformPlot[] {
            this.digitalWaveformPlot1});
            this.sampleDigitalWaveformGraph.Size = new System.Drawing.Size(400, 308);
            this.sampleDigitalWaveformGraph.TabIndex = 0;
            // 
            // digitalWaveformPlot1
            // 
            this.digitalWaveformPlot1.SignalPlots.AddRange(new NationalInstruments.UI.DigitalSignalPlot[] {
            this.digitalSignalPlot1});
            // 
            // settingsPanel
            // 
            this.settingsPanel.AutoScroll = true;
            this.settingsPanel.Controls.Add(this.plotButton);
            this.settingsPanel.Controls.Add(this.signalStateGroupBox);
            this.settingsPanel.Controls.Add(this.waveformStateGroupBox);
            this.settingsPanel.Controls.Add(this.plottingLabel);
            this.settingsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsPanel.Location = new System.Drawing.Point(4, 4);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(176, 308);
            this.settingsPanel.TabIndex = 1;
            // 
            // plotButton
            // 
            this.plotButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.plotButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.plotButton.ImageIndex = 1;
            this.plotButton.ImageList = this.plotButtonImageList;
            this.plotButton.Location = new System.Drawing.Point(112, 24);
            this.plotButton.Name = "plotButton";
            this.plotButton.Size = new System.Drawing.Size(48, 24);
            this.plotButton.TabIndex = 5;
            this.plotButton.Click += new System.EventHandler(this.OnPlotButtonClick);
            // 
            // plotButtonImageList
            // 
            this.plotButtonImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("plotButtonImageList.ImageStream")));
            this.plotButtonImageList.TransparentColor = System.Drawing.Color.Magenta;
            // 
            // signalStateGroupBox
            // 
            this.signalStateGroupBox.Controls.Add(this.customSignalStateRadioButton);
            this.signalStateGroupBox.Controls.Add(this.defaultSignalStateRadioButton);
            this.signalStateGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.signalStateGroupBox.Location = new System.Drawing.Point(16, 192);
            this.signalStateGroupBox.Name = "signalStateGroupBox";
            this.signalStateGroupBox.Size = new System.Drawing.Size(144, 100);
            this.signalStateGroupBox.TabIndex = 1;
            this.signalStateGroupBox.TabStop = false;
            this.signalStateGroupBox.Text = "Signal State Style";
            // 
            // customSignalStateRadioButton
            // 
            this.customSignalStateRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.customSignalStateRadioButton.Location = new System.Drawing.Point(20, 64);
            this.customSignalStateRadioButton.Name = "customSignalStateRadioButton";
            this.customSignalStateRadioButton.Size = new System.Drawing.Size(104, 24);
            this.customSignalStateRadioButton.TabIndex = 2;
            this.customSignalStateRadioButton.Text = "Custom";
            this.customSignalStateRadioButton.CheckedChanged += new System.EventHandler(this.OnSignalStateStyleChanged);
            // 
            // defaultSignalStateRadioButton
            // 
            this.defaultSignalStateRadioButton.Checked = true;
            this.defaultSignalStateRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.defaultSignalStateRadioButton.Location = new System.Drawing.Point(20, 24);
            this.defaultSignalStateRadioButton.Name = "defaultSignalStateRadioButton";
            this.defaultSignalStateRadioButton.Size = new System.Drawing.Size(104, 24);
            this.defaultSignalStateRadioButton.TabIndex = 1;
            this.defaultSignalStateRadioButton.TabStop = true;
            this.defaultSignalStateRadioButton.Text = "Default";
            this.defaultSignalStateRadioButton.CheckedChanged += new System.EventHandler(this.OnSignalStateStyleChanged);
            // 
            // waveformStateGroupBox
            // 
            this.waveformStateGroupBox.Controls.Add(this.customWaveformStateRadioButton);
            this.waveformStateGroupBox.Controls.Add(this.defaultWaveformStateRadioButton);
            this.waveformStateGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.waveformStateGroupBox.Location = new System.Drawing.Point(16, 72);
            this.waveformStateGroupBox.Name = "waveformStateGroupBox";
            this.waveformStateGroupBox.Size = new System.Drawing.Size(144, 100);
            this.waveformStateGroupBox.TabIndex = 0;
            this.waveformStateGroupBox.TabStop = false;
            this.waveformStateGroupBox.Text = "Waveform State Style";
            // 
            // customWaveformStateRadioButton
            // 
            this.customWaveformStateRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.customWaveformStateRadioButton.Location = new System.Drawing.Point(20, 64);
            this.customWaveformStateRadioButton.Name = "customWaveformStateRadioButton";
            this.customWaveformStateRadioButton.Size = new System.Drawing.Size(104, 24);
            this.customWaveformStateRadioButton.TabIndex = 1;
            this.customWaveformStateRadioButton.Text = "Custom";
            this.customWaveformStateRadioButton.CheckedChanged += new System.EventHandler(this.OnWaveformStateStyleChanged);
            // 
            // defaultWaveformStateRadioButton
            // 
            this.defaultWaveformStateRadioButton.Checked = true;
            this.defaultWaveformStateRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.defaultWaveformStateRadioButton.Location = new System.Drawing.Point(20, 24);
            this.defaultWaveformStateRadioButton.Name = "defaultWaveformStateRadioButton";
            this.defaultWaveformStateRadioButton.Size = new System.Drawing.Size(104, 24);
            this.defaultWaveformStateRadioButton.TabIndex = 0;
            this.defaultWaveformStateRadioButton.TabStop = true;
            this.defaultWaveformStateRadioButton.Text = "Default";
            this.defaultWaveformStateRadioButton.CheckedChanged += new System.EventHandler(this.OnWaveformStateStyleChanged);
            // 
            // plottingLabel
            // 
            this.plottingLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plottingLabel.Location = new System.Drawing.Point(16, 28);
            this.plottingLabel.Name = "plottingLabel";
            this.plottingLabel.Size = new System.Drawing.Size(96, 16);
            this.plottingLabel.TabIndex = 4;
            this.plottingLabel.Text = "Plot Digital Values";
            // 
            // vertSplitter
            // 
            this.vertSplitter.Dock = System.Windows.Forms.DockStyle.Right;
            this.vertSplitter.Location = new System.Drawing.Point(177, 4);
            this.vertSplitter.Name = "vertSplitter";
            this.vertSplitter.Size = new System.Drawing.Size(3, 308);
            this.vertSplitter.TabIndex = 2;
            this.vertSplitter.TabStop = false;
            // 
            // plottingTimer
            // 
            this.plottingTimer.Enabled = true;
            this.plottingTimer.Interval = 1000;
            this.plottingTimer.Tick += new System.EventHandler(this.plottingTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(584, 316);
            this.Controls.Add(this.vertSplitter);
            this.Controls.Add(this.settingsPanel);
            this.Controls.Add(this.sampleDigitalWaveformGraph);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Custom Digital States";
            ((System.ComponentModel.ISupportInitialize)(this.sampleDigitalWaveformGraph)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            this.signalStateGroupBox.ResumeLayout(false);
            this.waveformStateGroupBox.ResumeLayout(false);
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


		private void OnWaveformStateStyleChanged(object sender, System.EventArgs e)
		{
			if(defaultWaveformStateRadioButton.Checked == true)
			{
				sampleDigitalWaveformGraph.Plots[0].SampleStyle = DigitalWaveformSampleStyle.Simple;
			}
			else
			{
				sampleDigitalWaveformGraph.Plots[0].SampleStyle = CustomStyles.ShadedStyle;
			}
		}

		private void OnSignalStateStyleChanged(object sender, System.EventArgs e)
		{
			foreach(DigitalSignalPlot signalPlot in digitalWaveformPlot1.SignalPlots)
			{
				signalPlot.StateLabelVisible = true;
				if(defaultSignalStateRadioButton.Checked == true)
				{
					signalPlot.StateStyle = DigitalStateStyle.Simple;
				}
				else
				{
					signalPlot.StateStyle = CustomStyles.CharactersStyle;
				}
			}
		}

		private void plottingTimer_Tick(object sender, System.EventArgs e)
		{
			sampleDigitalWaveformGraph.PlotWaveform(CreateRandomWaveform(25, 6));
		}

		private void OnPlotButtonClick(object sender, System.EventArgs e)
		{
			plottingTimer.Enabled = !plottingTimer.Enabled;
			if(plottingTimer.Enabled)
			{
				plotButton.ImageIndex = 1;
				plottingTimer_Tick(this, EventArgs.Empty);
			}
			else
			{
				plotButton.ImageIndex = 0;
			}
		}
      
	}
    
	public class CustomStyles
	{
		public static readonly DigitalWaveformSampleStyle ShadedStyle = new ShadedBusStyleImpl();
		public static readonly DigitalStateStyle CharactersStyle = new CharactersLineStyleImpl();

		private class ShadedBusStyleImpl : DigitalWaveformSampleStyle
		{
			private Color _stateColor;
    
			public ShadedBusStyleImpl()
			{
				_stateColor = Color.Teal;
			}
            
			public override  void DrawSample(object context, DigitalWaveformSampleStyleDrawArgs args)
			{
				PointF[] previousPoints, nextPoints;
				GetSamplePoints(args.StateBounds, args.Sample, args.WaveformPlot.LineWidth, out previousPoints, out nextPoints);
				
				if(previousPoints.Length > 1 && nextPoints.Length > 1)
				{
					using(Brush brush = new HatchBrush(HatchStyle.DiagonalBrick, _stateColor, Color.Red))
						args.Graphics.FillRectangle(brush, args.LabelBounds);
				}

				DigitalWaveformSampleStyle.Simple.DrawSample(context, args);
				args.SetTransitionInfo(previousPoints, nextPoints, _stateColor);
			}
		}

		private class CharactersLineStyleImpl : DigitalStateStyle
		{
			private static char GetCustomChar(DigitalState state)
			{
				char label;
				switch(state)
				{
					case DigitalState.ForceUp:
						label = 'J';
						break;
					case DigitalState.ForceDown:
						label = 'L';
						break;
					case DigitalState.ForceOff:
						label = 'M';
						break;
					case DigitalState.CompareUnknown:
						label = 'N';
						break;
					default:
						label = DigitalStateUtility.ToChar(state);
						break;
				}

				return label;
			}
           
			public override void DrawLabel(object context, DigitalStateStyleDrawArgs args)
			{
				if(args.SignalPlot.StateLabelVisible)
				{
					Color foreColor = args.SignalPlot.StateLabelForeColor;

					using(Font font = new Font("WingDings", args.SignalPlot.StateLabelFont.Size + 6))
					using(Brush brush = new SolidBrush(Color.White))
					{
						Rectangle labelBounds = args.LabelBounds;
						char charLabel = GetCustomChar(args.SignalState);
						string label = charLabel.ToString();
						
						SizeF labelSize = args.Graphics.MeasureString(label, font);
						float centerWidth = (labelBounds.Width - labelSize.Width) / 2;
						float centerHeight = (labelBounds.Height - labelSize.Height) / 2; 
						PointF labelPoint = new PointF(labelBounds.X + centerWidth, labelBounds.Y + centerHeight);
						args.Graphics.DrawString(label, font, brush, labelPoint);
					}
				}
			}

			public override void DrawState(object context, DigitalStateStyleDrawArgs args)
			{
				DigitalStateStyle.Simple.DrawState(context, args);
			}

		}
	}
}
