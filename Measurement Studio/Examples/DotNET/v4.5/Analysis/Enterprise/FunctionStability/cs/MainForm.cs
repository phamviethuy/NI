using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using NationalInstruments.Analysis;
using NationalInstruments.Analysis.Conversion;
using NationalInstruments.Restricted;
using NationalInstruments.Analysis.Dsp;
using NationalInstruments.Analysis.Math;
using NationalInstruments.Analysis.Monitoring;
using NationalInstruments.Analysis.SignalGeneration;
using NationalInstruments.Analysis.SpectralMeasurements;
using NationalInstruments.UI;
using NationalInstruments.UI.WindowsForms;


namespace NationalInstruments.Examples.FunctionStability
{
	/// <summary>
	/// Summary description for MainForm.
	/// </summary>
	public class MainForm : System.Windows.Forms.Form
	{
        private System.Windows.Forms.Label NumeratorLabel;
        private System.Windows.Forms.Label denominatorLabel;
        private System.Windows.Forms.Label stableCheckLabel;
        private NationalInstruments.UI.XAxis xAxis;
        private NationalInstruments.UI.YAxis yAxis;
        private NationalInstruments.UI.ScatterPlot polePlot;
        private NationalInstruments.UI.ScatterPlot zeroPlot;
        private NationalInstruments.UI.ScatterPlot horizontalAxis;
        private NationalInstruments.UI.ScatterPlot verticalAxis;
        private NationalInstruments.UI.ScatterPlot circlePlot;
        private System.Windows.Forms.Label helpLabel;
		private System.Windows.Forms.ToolTip toolTip;
        private NationalInstruments.UI.WindowsForms.Led stableCheckLed;
        private System.Windows.Forms.TextBox AzTextBox;
        private System.Windows.Forms.TextBox BzTextBox;
        private System.Windows.Forms.Button computeStabilityButton;
        private NationalInstruments.UI.WindowsForms.ScatterGraph poleZeroScatterGraph;
        private System.Windows.Forms.Label exampleLabel;
		private System.ComponentModel.IContainer components;

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
            this.components = new System.ComponentModel.Container();
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(MainForm));
            this.NumeratorLabel = new System.Windows.Forms.Label();
            this.AzTextBox = new System.Windows.Forms.TextBox();
            this.denominatorLabel = new System.Windows.Forms.Label();
            this.BzTextBox = new System.Windows.Forms.TextBox();
            this.stableCheckLabel = new System.Windows.Forms.Label();
            this.computeStabilityButton = new System.Windows.Forms.Button();
            this.poleZeroScatterGraph = new NationalInstruments.UI.WindowsForms.ScatterGraph();
            this.circlePlot = new NationalInstruments.UI.ScatterPlot();
            this.xAxis = new NationalInstruments.UI.XAxis();
            this.yAxis = new NationalInstruments.UI.YAxis();
            this.polePlot = new NationalInstruments.UI.ScatterPlot();
            this.zeroPlot = new NationalInstruments.UI.ScatterPlot();
            this.horizontalAxis = new NationalInstruments.UI.ScatterPlot();
            this.verticalAxis = new NationalInstruments.UI.ScatterPlot();
            this.helpLabel = new System.Windows.Forms.Label();
            this.stableCheckLed = new NationalInstruments.UI.WindowsForms.Led();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.exampleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.poleZeroScatterGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stableCheckLed)).BeginInit();
            this.SuspendLayout();
            // 
            // NumeratorLabel
            // 
            this.NumeratorLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.NumeratorLabel.Location = new System.Drawing.Point(24, 40);
            this.NumeratorLabel.Name = "NumeratorLabel";
            this.NumeratorLabel.Size = new System.Drawing.Size(40, 16);
            this.NumeratorLabel.TabIndex = 3;
            this.NumeratorLabel.Text = "A(z)";
            this.toolTip.SetToolTip(this.NumeratorLabel, "Separate coefficients by commas. Ex: 1.2, 0.5, 2.0");
            // 
            // AzTextBox
            // 
            this.AzTextBox.Location = new System.Drawing.Point(24, 56);
            this.AzTextBox.Name = "AzTextBox";
            this.AzTextBox.Size = new System.Drawing.Size(152, 20);
            this.AzTextBox.TabIndex = 1;
            this.AzTextBox.Text = "1.2,0.5";
            // 
            // denominatorLabel
            // 
            this.denominatorLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.denominatorLabel.Location = new System.Drawing.Point(24, 96);
            this.denominatorLabel.Name = "denominatorLabel";
            this.denominatorLabel.Size = new System.Drawing.Size(56, 16);
            this.denominatorLabel.TabIndex = 5;
            this.denominatorLabel.Text = "B(z)";
            this.toolTip.SetToolTip(this.denominatorLabel, "Separate coefficients by commas. Ex: 1.2, 0.5, 2.0");
            // 
            // BzTextBox
            // 
            this.BzTextBox.Location = new System.Drawing.Point(24, 112);
            this.BzTextBox.Name = "BzTextBox";
            this.BzTextBox.Size = new System.Drawing.Size(152, 20);
            this.BzTextBox.TabIndex = 2;
            this.BzTextBox.Text = "1.1,0.25,0.3";
            // 
            // stableCheckLabel
            // 
            this.stableCheckLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.stableCheckLabel.Location = new System.Drawing.Point(80, 220);
            this.stableCheckLabel.Name = "stableCheckLabel";
            this.stableCheckLabel.Size = new System.Drawing.Size(80, 16);
            this.stableCheckLabel.TabIndex = 7;
            this.stableCheckLabel.Text = "Y(z) Unstable?";
            // 
            // computeStabilityButton
            // 
            this.computeStabilityButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.computeStabilityButton.Location = new System.Drawing.Point(24, 152);
            this.computeStabilityButton.Name = "computeStabilityButton";
            this.computeStabilityButton.Size = new System.Drawing.Size(152, 32);
            this.computeStabilityButton.TabIndex = 0;
            this.computeStabilityButton.Text = "Compute Stability";
            this.toolTip.SetToolTip(this.computeStabilityButton, "Compute Stability of Y(z) = A(z)/B(z) ");
            this.computeStabilityButton.Click += new System.EventHandler(this.computeStability_Click);
            // 
            // poleZeroScatterGraph
            // 
            this.poleZeroScatterGraph.Caption = "Pole Zero Plot";
            this.poleZeroScatterGraph.Location = new System.Drawing.Point(216, 8);
            this.poleZeroScatterGraph.Name = "poleZeroScatterGraph";
            this.poleZeroScatterGraph.PlotAreaColor = System.Drawing.Color.White;
            this.poleZeroScatterGraph.Plots.AddRange(new NationalInstruments.UI.ScatterPlot[] {
                                                                                                  this.circlePlot,
                                                                                                  this.polePlot,
                                                                                                  this.zeroPlot,
                                                                                                  this.horizontalAxis,
                                                                                                  this.verticalAxis});
            this.poleZeroScatterGraph.Size = new System.Drawing.Size(300, 300);
            this.poleZeroScatterGraph.TabIndex = 10;
            this.poleZeroScatterGraph.TabStop = false;
            this.poleZeroScatterGraph.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
                                                                                            this.xAxis});
            this.poleZeroScatterGraph.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
                                                                                            this.yAxis});
            // 
            // circlePlot
            // 
            this.circlePlot.LineColor = System.Drawing.Color.Red;
            this.circlePlot.XAxis = this.xAxis;
            this.circlePlot.YAxis = this.yAxis;
            // 
            // xAxis
            // 
            this.xAxis.AutoSpacing = false;
            this.xAxis.MajorDivisions.GridColor = System.Drawing.Color.LightBlue;
            this.xAxis.MajorDivisions.GridVisible = true;
            this.xAxis.MajorDivisions.Interval = 1;
            this.xAxis.MinorDivisions.Interval = 0.5;
            this.xAxis.Mode = NationalInstruments.UI.AxisMode.AutoScaleExact;
            this.xAxis.Range = new NationalInstruments.UI.Range(-2.15987527248219, 2.15987527248221);
            // 
            // yAxis
            // 
            this.yAxis.AutoSpacing = false;
            this.yAxis.MajorDivisions.GridColor = System.Drawing.Color.LightBlue;
            this.yAxis.MajorDivisions.GridVisible = true;
            this.yAxis.MajorDivisions.Interval = 1;
            this.yAxis.MinorDivisions.Interval = 0.5;
            this.yAxis.Mode = NationalInstruments.UI.AxisMode.AutoScaleExact;
            this.yAxis.Range = new NationalInstruments.UI.Range(-2, 1.9982456601977177);
            // 
            // polePlot
            // 
            this.polePlot.LineStyle = NationalInstruments.UI.LineStyle.None;
            this.polePlot.PointColor = System.Drawing.Color.Green;
            this.polePlot.PointStyle = NationalInstruments.UI.PointStyle.Cross;
            this.polePlot.XAxis = this.xAxis;
            this.polePlot.YAxis = this.yAxis;
            // 
            // zeroPlot
            // 
            this.zeroPlot.LineStyle = NationalInstruments.UI.LineStyle.None;
            this.zeroPlot.PointColor = System.Drawing.Color.Blue;
            this.zeroPlot.PointStyle = NationalInstruments.UI.PointStyle.EmptyCircle;
            this.zeroPlot.XAxis = this.xAxis;
            this.zeroPlot.YAxis = this.yAxis;
            // 
            // horizontalAxis
            // 
            this.horizontalAxis.LineColor = System.Drawing.Color.Red;
            this.horizontalAxis.XAxis = this.xAxis;
            this.horizontalAxis.YAxis = this.yAxis;
            // 
            // verticalAxis
            // 
            this.verticalAxis.LineColor = System.Drawing.Color.Red;
            this.verticalAxis.XAxis = this.xAxis;
            this.verticalAxis.YAxis = this.yAxis;
            // 
            // helpLabel
            // 
            this.helpLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.helpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.helpLabel.Location = new System.Drawing.Point(24, 328);
            this.helpLabel.Name = "helpLabel";
            this.helpLabel.Size = new System.Drawing.Size(512, 48);
            this.helpLabel.TabIndex = 11;
            this.helpLabel.Text = "This example evaluates the stability of the system: Y(z) = A(z)/B(z) and uses the" +
                " Complex Polynomial Roots method. The coefficients for polynomial A(z) and B(z) " +
                "are specified left to right with the highest order coefficients specified first " +
                ". ";
            // 
            // stableCheckLed
            // 
            this.stableCheckLed.LedStyle = NationalInstruments.UI.LedStyle.Round3D;
            this.stableCheckLed.Location = new System.Drawing.Point(32, 208);
            this.stableCheckLed.Name = "stableCheckLed";
            this.stableCheckLed.Size = new System.Drawing.Size(40, 40);
            this.stableCheckLed.TabIndex = 12;
            this.stableCheckLed.TabStop = false;
            // 
            // exampleLabel
            // 
            this.exampleLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.exampleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.exampleLabel.Location = new System.Drawing.Point(24, 384);
            this.exampleLabel.Name = "exampleLabel";
            this.exampleLabel.Size = new System.Drawing.Size(336, 24);
            this.exampleLabel.TabIndex = 13;
            this.exampleLabel.Text = "For example: 0.5x^3 + 0.3x^2 + 1 is specified as 0.5,0.3,1.0 ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(568, 421);
            this.Controls.Add(this.exampleLabel);
            this.Controls.Add(this.stableCheckLed);
            this.Controls.Add(this.helpLabel);
            this.Controls.Add(this.poleZeroScatterGraph);
            this.Controls.Add(this.computeStabilityButton);
            this.Controls.Add(this.stableCheckLabel);
            this.Controls.Add(this.BzTextBox);
            this.Controls.Add(this.AzTextBox);
            this.Controls.Add(this.denominatorLabel);
            this.Controls.Add(this.NumeratorLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Function Stability Example";
            ((System.ComponentModel.ISupportInitialize)(this.poleZeroScatterGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stableCheckLed)).EndInit();
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

       
        // Checking for the stability of polynomial function.
        private void computeStability_Click(object sender, System.EventArgs e)
        {
            int i;
            string numeratorString;
            string denominatorString;
            string []splitNumeratorString;
            string []splitDenominatorString;
            double []numeratorCoefficients;
            double []denominatorCoefficients;
            double []zeroMagnitude;
            double []zeroPhase;
            double []zeroReal;
            double []zeroImaginary;
            double []poleMagnitude;
            double []polePhase;
            double []poleReal;
            double []poleImaginary;
            double poleMaximum, poleMinimum;
            double zeroMaximum, zeroMinimum;
            double maximumOfPoleZero;
            double []xWaveform;
            double []yWaveform;
            double []horizontal;
            double []vertical;
            int indexOfMaximum, indexOfMinimum;
            NationalInstruments.ComplexDouble []zeros;
            NationalInstruments.ComplexDouble []poles;
            xWaveform = new double[10000];
            yWaveform = new double[10000];

            SineSignal sin = new SineSignal(100, 1.0, 0.0);
            SineSignal cos = new SineSignal(100, 1.0, 90.0);
            xWaveform = sin.Generate(100000, 10000);
            yWaveform = cos.Generate(100000, 10000);
            
            numeratorString = AzTextBox.Text; // take the numerator coefficients
            denominatorString = BzTextBox.Text;  // take the denominator coefficients.
          
            try
            {
                // Extracting numerator coefficients from numeratorString.
                splitNumeratorString  = System.Text.RegularExpressions.Regex.Split(numeratorString,",");
                // Extracting denominator coefficients from denominatorString.
                splitDenominatorString = System.Text.RegularExpressions.Regex.Split(denominatorString,",");
            
                //Memory allocation for numerator's coefficients arrays
                numeratorCoefficients = new double[splitNumeratorString.Length];
            
                //Memory allocation for denominator's coeffiecients arrays 
                denominatorCoefficients = new double[splitDenominatorString.Length];
            
                // Converting the string array to double array to get actual numerator coefficients.
                for(i=0; i < splitNumeratorString.Length; i++)
                {
                    numeratorCoefficients[i] = System.Convert.ToDouble(splitNumeratorString[i]);
                }
                // Converting the string array to double array to get actual denominator coefficients.
                for(i=0; i < splitDenominatorString.Length; i++)
                {
                    denominatorCoefficients[i] = System.Convert.ToDouble(splitDenominatorString[i]);
                }

                // Find zeros and poles of the polynomial function.
                zeros = Roots.FindPolynomialRoots(numeratorCoefficients);
                poles = Roots.FindPolynomialRoots(denominatorCoefficients);
            
                // memory allocation to store properties of zeros 
                zeroMagnitude = new double[zeros.Length];
                zeroPhase = new double[zeros.Length];
                zeroReal = new double[zeros.Length];
                zeroImaginary = new double[zeros.Length];

                // memory allocation to store properties of poles
                poleMagnitude = new double[poles.Length];
                polePhase = new double[poles.Length];
                poleReal = new double[poles.Length];
                poleImaginary = new double[poles.Length];

                // Storing magnitude, phase, real and imaginary values 
                // of each zero and pole of the polynomial function.
                for(i=0; i < zeros.Length; i++)
                {
                    zeroMagnitude[i] = zeros[i].Magnitude;
                    zeroPhase[i] = zeros[i].Phase;
                    zeroReal[i] = zeros[i].Real;
                    zeroImaginary[i] = zeros[i].Imaginary;
                }
                for(i=0; i < poles.Length; i++)
                {
                    poleMagnitude[i] = poles[i].Magnitude;
                    polePhase[i] = poles[i].Phase;
                    poleReal[i] = poles[i].Real;
                    poleImaginary[i] = poles[i].Imaginary;
                }
            
                ArrayOperation.MaxMin1D(zeroMagnitude,out zeroMaximum,out indexOfMaximum,out zeroMinimum,out indexOfMinimum);
                // Check for stability. 
                // If the magnitude of any of the poles is greater than 1, polynomial function would be
                // unstable, otherwise the polynomial function would be stable.
                ArrayOperation.MaxMin1D(poleMagnitude, out poleMaximum, out indexOfMaximum,
                    out poleMinimum, out indexOfMinimum);
                if(poleMaximum > 1.0)
                    stableCheckLed.Value = true;
                else
                    stableCheckLed.Value = false;
            
                // Assign maximum value of pole or zero to maximumOfPoleZero.
                if ( poleMaximum > zeroMaximum)
                    maximumOfPoleZero = poleMaximum;
                else
                    maximumOfPoleZero = zeroMaximum;
                // Plot the zeros and poles in the z domain graph.

                // Plot a circle of radius 1.
                circlePlot.PlotXY(xWaveform, yWaveform);
            
                // Plot horizontal axis. 
                horizontal = new double[2];
                vertical = new double[2];
                horizontal[0] = -(maximumOfPoleZero + 2);
                horizontal[1] = (maximumOfPoleZero + 2);
                vertical[0] = 0;
                vertical[1] = 0;
                horizontalAxis.PlotXY(horizontal, vertical);
            
                // Plot Vertical axis.
                horizontal[0] = 0;
                horizontal[1] = 0;
                vertical[0] = -(maximumOfPoleZero + 2);
                vertical[1] = (maximumOfPoleZero + 2);
                verticalAxis.PlotXY(horizontal, vertical);

                // Plot poles.
                polePlot.PlotXY(poleReal, poleImaginary);

                // Plot zeros.
                zeroPlot.PlotXY(zeroReal, zeroImaginary);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            
        }

    }
}
