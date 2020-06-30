namespace NationalInstruments.Examples.WindowsFormsDataSource
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            NationalInstruments.NetworkVariable.WindowsForms.NetworkVariableBinding networkVariableBinding1 = new NationalInstruments.NetworkVariable.WindowsForms.NetworkVariableBinding();
            NationalInstruments.NetworkVariable.WindowsForms.NetworkVariableBinding networkVariableBinding2 = new NationalInstruments.NetworkVariable.WindowsForms.NetworkVariableBinding();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dataSourceWaveformGraph = new NationalInstruments.UI.WindowsForms.WaveformGraph();
            this.dataSource = new NationalInstruments.NetworkVariable.WindowsForms.NetworkVariableDataSource(this.components);
            this.dataSourceWaveformPlot = new NationalInstruments.UI.WaveformPlot();
            this.dataSourceXAxis = new NationalInstruments.UI.XAxis();
            this.dataSourceYAxis = new NationalInstruments.UI.YAxis();
            this.amplitudeTank = new NationalInstruments.UI.WindowsForms.Tank();
            ((System.ComponentModel.ISupportInitialize)(this.dataSourceWaveformGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amplitudeTank)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSourceWaveformGraph
            // 
            this.dataSourceWaveformGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataSourceWaveformGraph.BindingMethod = NationalInstruments.UI.BindableWaveformGraphMethod.PlotYAppend;
            this.dataSourceWaveformGraph.DataBindings.Add(new System.Windows.Forms.Binding("BindingData", this.dataSource, "waveformGraphBinding", true));
            this.dataSourceWaveformGraph.Location = new System.Drawing.Point(103, 12);
            this.dataSourceWaveformGraph.Name = "dataSourceWaveformGraph";
            this.dataSourceWaveformGraph.Plots.AddRange(new NationalInstruments.UI.WaveformPlot[] {
            this.dataSourceWaveformPlot});
            this.dataSourceWaveformGraph.Size = new System.Drawing.Size(423, 242);
            this.dataSourceWaveformGraph.TabIndex = 0;
            this.dataSourceWaveformGraph.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
            this.dataSourceXAxis});
            this.dataSourceWaveformGraph.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
            this.dataSourceYAxis});
            // 
            // dataSource
            // 
            this.dataSource.AutoConnect = false;
            networkVariableBinding1.DefaultReadValue = "0.0";
            networkVariableBinding1.Location = "\\\\localhost\\system\\DoubleArray";
            networkVariableBinding1.Name = "waveformGraphBinding";
            networkVariableBinding2.DefaultReadValue = "10.0";
            networkVariableBinding2.Location = "\\\\localhost\\system\\Double";
            networkVariableBinding2.Name = "tankBinding";
            this.dataSource.Bindings.AddRange(new NationalInstruments.NetworkVariable.WindowsForms.NetworkVariableBinding[] {
            networkVariableBinding1,
            networkVariableBinding2});
            // 
            // dataSourceWaveformPlot
            // 
            this.dataSourceWaveformPlot.XAxis = this.dataSourceXAxis;
            this.dataSourceWaveformPlot.YAxis = this.dataSourceYAxis;
            // 
            // dataSourceXAxis
            // 
            this.dataSourceXAxis.Mode = NationalInstruments.UI.AxisMode.AutoScaleExact;
            // 
            // dataSourceYAxis
            // 
            this.dataSourceYAxis.Mode = NationalInstruments.UI.AxisMode.Fixed;
            this.dataSourceYAxis.Range = new NationalInstruments.UI.Range(-10, 10);
            // 
            // amplitudeTank
            // 
            this.amplitudeTank.Caption = "Amplitude";
            this.amplitudeTank.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dataSource, "tankBinding", true));
            this.amplitudeTank.Location = new System.Drawing.Point(12, 12);
            this.amplitudeTank.Name = "amplitudeTank";
            this.amplitudeTank.Size = new System.Drawing.Size(72, 242);
            this.amplitudeTank.TabIndex = 1;
            this.amplitudeTank.Value = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 266);
            this.Controls.Add(this.amplitudeTank);
            this.Controls.Add(this.dataSourceWaveformGraph);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Network Variable Windows Forms Data Source";
            ((System.ComponentModel.ISupportInitialize)(this.dataSourceWaveformGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amplitudeTank)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private NationalInstruments.UI.WindowsForms.WaveformGraph dataSourceWaveformGraph;
        private NationalInstruments.UI.WaveformPlot dataSourceWaveformPlot;
        private NationalInstruments.UI.XAxis dataSourceXAxis;
        private NationalInstruments.UI.YAxis dataSourceYAxis;
        private NationalInstruments.NetworkVariable.WindowsForms.NetworkVariableDataSource dataSource;
        private NationalInstruments.UI.WindowsForms.Tank amplitudeTank;
    }
}

