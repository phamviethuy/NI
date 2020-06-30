using System;
using System.ComponentModel;
using System.Windows.Forms;
using NationalInstruments;
using NationalInstruments.UI;
using NationalInstruments.UI.WindowsForms;

namespace NationalInstruments.Examples.Features
{
    public partial class MainForm : Form
    {
        private Random random;

        public MainForm()
        {
            InitializeComponent();

            foreach (object value in Enum.GetValues(typeof(PropertyEditorInteractionMode)))
            {
                propertyEditorInteractionModeComboBox.Items.Add(value);

                if (DefaultToolStripPropertyEditor.InteractionMode.Equals(value))
                {
                    propertyEditorInteractionModeComboBox.SelectedItem = value;
                }
            }

            foreach (object value in Enum.GetValues(typeof(BorderStyle)))
            {
                propertyEditorBorderStyleComboBox.Items.Add(value);

                if (DefaultToolStripPropertyEditor.BorderStyle.Equals(value))
                {
                    propertyEditorBorderStyleComboBox.SelectedItem = value;
                }
            }

            foreach (object value in Enum.GetValues(typeof(PropertyEditorRenderMode)))
            {
                propertyEditorRenderModeComboBox.Items.Add(value);

                if (DefaultToolStripPropertyEditor.RenderMode.Equals(value))
                {
                    propertyEditorRenderModeComboBox.SelectedItem = value;
                }
            }

            foreach (object value in Enum.GetValues(typeof(PropertyEditorDisplayMode)))
            {
                propertyEditorDisplayModeComboBox.Items.Add(value);

                if (DefaultToolStripPropertyEditor.DisplayMode.Equals(value))
                {
                    propertyEditorDisplayModeComboBox.SelectedItem = value;
                }
            }

            foreach (object value in Enum.GetValues(typeof(HorizontalAlignment)))
            {
                propertyEditorTextAlignComboBox.Items.Add(value);

                if (DefaultToolStripPropertyEditor.PropertyTextAlign.Equals(value))
                {
                    propertyEditorTextAlignComboBox.SelectedItem = value;
                }
            }

            double[] data = new double[20];
            random = new Random();

            for (int i = 0; i < data.Length; ++i)
            {
                data[i] = random.NextDouble() * sampleYAxis.Range.Maximum;
            }

            sampleWaveformGraph.PlotY(data);

            xAxisLabelFormatToolStripPropertyEditor.Source = new PropertyEditorSource(sampleXAxis.MajorDivisions, "LabelFormat");
        }

        private ToolStripPropertyEditor DefaultToolStripPropertyEditor
        {
            get
            {
                return interactionModeToolStripPropertyEditor;
            }
        }

        private void OnPropertyEditorInteractionModeChanged(object sender, System.EventArgs e)
        {
            foreach (ToolStripItem item in sampleInstrumentControlStrip.Items)
            {
                if (item is ToolStripPropertyEditor)
                {
                    ((ToolStripPropertyEditor)item).InteractionMode = (PropertyEditorInteractionMode)propertyEditorInteractionModeComboBox.SelectedItem;
                }
            }
        }

        private void OnPropertyEditorBorderStyleChanged(object sender, System.EventArgs e)
        {
            foreach (ToolStripItem item in sampleInstrumentControlStrip.Items)
            {
                if (item is ToolStripPropertyEditor)
                {
                    ((ToolStripPropertyEditor)item).BorderStyle = (BorderStyle)propertyEditorBorderStyleComboBox.SelectedItem;
                }
            }
        }

        private void OnPropertyEditorRenderModeChanged(object sender, System.EventArgs e)
        {
            foreach (ToolStripItem item in sampleInstrumentControlStrip.Items)
            {
                if (item is ToolStripPropertyEditor)
                {
                    ((ToolStripPropertyEditor)item).RenderMode = (PropertyEditorRenderMode)propertyEditorRenderModeComboBox.SelectedItem;
                }
            }
        }

        private void OnPropertyEditorDisplayModeChanged(object sender, System.EventArgs e)
        {
            foreach (ToolStripItem item in sampleInstrumentControlStrip.Items)
            {
                if (item is ToolStripPropertyEditor)
                {
                    ((ToolStripPropertyEditor)item).DisplayMode = (PropertyEditorDisplayMode)propertyEditorDisplayModeComboBox.SelectedItem;
                }
            }
        }

        private void OnPropertyEditorTextAlignChanged(object sender, System.EventArgs e)
        {
            foreach (ToolStripItem item in sampleInstrumentControlStrip.Items)
            {
                if (item is ToolStripPropertyEditor)
                {
                    ((ToolStripPropertyEditor)item).PropertyTextAlign = (HorizontalAlignment)propertyEditorTextAlignComboBox.SelectedItem;
                }
            }
        }
    }
}