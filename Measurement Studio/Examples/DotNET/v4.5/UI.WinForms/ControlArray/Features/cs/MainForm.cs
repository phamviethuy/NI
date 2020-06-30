using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NationalInstruments;
using NationalInstruments.UI;
using NationalInstruments.UI.WindowsForms;

namespace NationalInstruments.Examples.Features
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            scalingSwitchArray.ItemPropertyChanged += new EventHandler<NationalInstruments.UI.ControlArrayPropertyChangedEventArgs<NationalInstruments.UI.WindowsForms.Switch>>(OnScalingSwitchArrayItemPropertyChanged);
            OnScaleModeChanged();

            booleanComboBox.SelectedIndex = 0;

            for (int i = 0; i < layoutNumericEditArray.Count; ++i)
            {
                indexComboBox.Items.Add(i);
            }

            indexComboBox.SelectedIndex = 0;
        }

        private void OnScalingSwitchArrayItemPropertyChanged(object sender, NationalInstruments.UI.ControlArrayPropertyChangedEventArgs<NationalInstruments.UI.WindowsForms.Switch> e)
        {
            if (e.PropertyName.Equals("Value"))
            {
                UpdateScalingLedArrayValues();
                UpdateValuesListBox();
            }
        }

        private void OnScaleModeChanged()
        {
            UpdateValuesListBox();

            switch (scalingSwitchArray.ScaleMode.Type)
            {
                case ControlArrayScaleModeType.Automatic:
                    automaticScaleModePanel.Enabled = true;
                    break;
                case ControlArrayScaleModeType.Fixed:
                    automaticScaleModePanel.Enabled = false;
                    break;
                default:
                    break;
            }
        }

        private void UpdateValuesListBox()
        {
            valuesListBox.Items.Clear();
            bool[] switchArrayValues = scalingSwitchArray.GetValues();
            foreach (bool value in switchArrayValues)
            {
                valuesListBox.Items.Add(value);
            }
        }

        private void OnScaleModePropertyEditorSourceValueChanged(object sender, EventArgs e)
        {
            scalingLedArray.ScaleMode = scaleModePropertyEditor.SourceValue as ControlArrayScaleMode;
            OnScaleModeChanged();
        }

        private void OnAddButtonClick(object sender, EventArgs e)
        {
            bool addedValue = Convert.ToBoolean(booleanComboBox.SelectedItem);
            bool[] switchArrayValues = scalingSwitchArray.GetValues();
            List<bool> updatedValues = new List<bool>(switchArrayValues);
            updatedValues.Add(addedValue);
            scalingSwitchArray.SetValues(updatedValues.ToArray());
        }

        private void OnScalingSwitchArrayValuesChanged(object sender, EventArgs e)
        {
            UpdateScalingLedArrayValues();
            UpdateValuesListBox();
        }

        private void UpdateScalingLedArrayValues()
        {
            bool[] switchArrayValues = scalingSwitchArray.GetValues();
            scalingLedArray.SetValues(switchArrayValues);
        }

        private void OnRemoveButtonClick(object sender, EventArgs e)
        {
            if (valuesListBox.SelectedItems.Count > 0)
            {
                foreach (int index in valuesListBox.SelectedIndices)
                {
                    valuesListBox.Items.RemoveAt(index);
                }

                bool[] updatedValues = new bool[valuesListBox.Items.Count];

                for (int i = 0; i < updatedValues.Length; ++i)
                {
                    updatedValues[i] = Convert.ToBoolean(valuesListBox.Items[i]);
                }

                scalingSwitchArray.SetValues(updatedValues);
            }
        }

        private void OnIndexComboboxSelectedIndexChanged(object sender, EventArgs e)
        {
            rangePropertyEditor.Source = new PropertyEditorSource(layoutNumericEditArray[indexComboBox.SelectedIndex], "Range");
        }
    }
}