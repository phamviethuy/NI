<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim NetworkVariableBinding1 As NationalInstruments.NetworkVariable.WindowsForms.NetworkVariableBinding = New NationalInstruments.NetworkVariable.WindowsForms.NetworkVariableBinding
        Dim NetworkVariableBinding2 As NationalInstruments.NetworkVariable.WindowsForms.NetworkVariableBinding = New NationalInstruments.NetworkVariable.WindowsForms.NetworkVariableBinding
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.dataSourceWaveformGraph = New NationalInstruments.UI.WindowsForms.WaveformGraph
        Me.dataSource = New NationalInstruments.NetworkVariable.WindowsForms.NetworkVariableDataSource(Me.components)
        Me.dataSourceWaveformPlot = New NationalInstruments.UI.WaveformPlot
        Me.dataSourceXAxis = New NationalInstruments.UI.XAxis
        Me.dataSourceYAxis = New NationalInstruments.UI.YAxis
        Me.amplitudeTank = New NationalInstruments.UI.WindowsForms.Tank
        CType(Me.dataSourceWaveformGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.amplitudeTank, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dataSourceWaveformGraph
        '
        Me.dataSourceWaveformGraph.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dataSourceWaveformGraph.BindingMethod = NationalInstruments.UI.BindableWaveformGraphMethod.PlotYAppend
        Me.dataSourceWaveformGraph.DataBindings.Add(New System.Windows.Forms.Binding("BindingData", Me.dataSource, "dataSourceBinding", True))
        Me.dataSourceWaveformGraph.Location = New System.Drawing.Point(103, 12)
        Me.dataSourceWaveformGraph.Name = "dataSourceWaveformGraph"
        Me.dataSourceWaveformGraph.Plots.AddRange(New NationalInstruments.UI.WaveformPlot() {Me.dataSourceWaveformPlot})
        Me.dataSourceWaveformGraph.Size = New System.Drawing.Size(423, 242)
        Me.dataSourceWaveformGraph.TabIndex = 0
        Me.dataSourceWaveformGraph.XAxes.AddRange(New NationalInstruments.UI.XAxis() {Me.dataSourceXAxis})
        Me.dataSourceWaveformGraph.YAxes.AddRange(New NationalInstruments.UI.YAxis() {Me.dataSourceYAxis})
        '
        'dataSource
        '
        Me.dataSource.AutoConnect = False
        NetworkVariableBinding1.DefaultReadValue = "0.0"
        NetworkVariableBinding1.Location = "\\localhost\system\DoubleArray"
        NetworkVariableBinding1.Name = "dataSourceBinding"
        NetworkVariableBinding2.DefaultReadValue = "10.0"
        NetworkVariableBinding2.Location = "\\localhost\system\Double"
        NetworkVariableBinding2.Name = "tankBinding"
        Me.dataSource.Bindings.AddRange(New NationalInstruments.NetworkVariable.WindowsForms.NetworkVariableBinding() {NetworkVariableBinding1, NetworkVariableBinding2})
        '
        'dataSourceWaveformPlot
        '
        Me.dataSourceWaveformPlot.XAxis = Me.dataSourceXAxis
        Me.dataSourceWaveformPlot.YAxis = Me.dataSourceYAxis
        '
        'dataSourceXAxis
        '
        Me.dataSourceXAxis.Mode = NationalInstruments.UI.AxisMode.AutoScaleExact
        '
        'amplitudeTank
        '
        Me.amplitudeTank.Caption = "Amplitude"
        Me.amplitudeTank.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.dataSource, "tankBinding", True))
        Me.amplitudeTank.Location = New System.Drawing.Point(12, 12)
        Me.amplitudeTank.Name = "amplitudeTank"
        Me.amplitudeTank.Size = New System.Drawing.Size(72, 242)
        Me.amplitudeTank.TabIndex = 1
        Me.amplitudeTank.Value = 10
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(538, 266)
        Me.Controls.Add(Me.amplitudeTank)
        Me.Controls.Add(Me.dataSourceWaveformGraph)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.Text = "Network Variable Windows Forms Data Source"
        CType(Me.dataSourceWaveformGraph, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.amplitudeTank, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dataSourceWaveformGraph As NationalInstruments.UI.WindowsForms.WaveformGraph
    Friend WithEvents dataSourceWaveformPlot As NationalInstruments.UI.WaveformPlot
    Friend WithEvents dataSourceXAxis As NationalInstruments.UI.XAxis
    Friend WithEvents dataSourceYAxis As NationalInstruments.UI.YAxis
    Friend WithEvents dataSource As NationalInstruments.NetworkVariable.WindowsForms.NetworkVariableDataSource
    Friend WithEvents amplitudeTank As NationalInstruments.UI.WindowsForms.Tank

End Class
