using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NationalInstruments.NetworkVariable;

namespace NationalInstruments.Examples.Creation
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void UpdateProcessList()
        {
            ServerProcessInfo[] processes = null;

            ProcessesListBox.Items.Clear();

            // Get a list of all processes
            try
            {
                processes = ServerProcess.GetAll();
            }
            catch (NetworkVariableException)
            {
                MessageBox.Show("Error gathering process list.", this.Text);
            }

            if (processes != null)
            {
                // store the process names in the process list box
                foreach (ServerProcessInfo procInfo in processes)
                {
                    ProcessesListBox.Items.Add(procInfo);
                }

                // make sure the list box displays the name of the process
                ProcessesListBox.DisplayMember = "Name";
            }
        }

        private void UpdateVariableList()
        {
            ServerVariableInfo[] variables = null;

            // get the selected process
            ServerProcessInfo info = ProcessesListBox.SelectedItem as ServerProcessInfo;

            VariablesListBox.Items.Clear();

            if (info != null && info.Exists)
            {
                // if a valid process is selected, get its variables
                try
                {
                    variables = info.GetVariables();
                }
                catch (NetworkVariableException)
                {
                    MessageBox.Show("Error retrieving process variables.", this.Text);
                }
            }

            if (variables != null)
            {
                foreach (ServerVariableInfo varInfo in variables)
                {
                    VariablesListBox.Items.Add(varInfo);
                }

                VariablesListBox.DisplayMember = "Name";
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Set up the list boxes when the form loads
            UpdateProcessList();
            UpdateVariableList();
        }

        private void lbxProcesses_SelectedIndexChanged(object sender, EventArgs e)
        {
            // update the list of variables when a new process is selected
            UpdateVariableList();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            if (ProcessNameTextBox.Text.Length == 0)
            {
                MessageBox.Show("Please enter a process name.", this.Text);
            }
            else
            {
                // create a new process with the specified name
                try
                {
                    // create the process
                    ServerProcess.Create(ProcessNameTextBox.Text);
                    UpdateProcessList();
                }
                catch (Exception ex)
                {
                    string errorMessage = String.Format("Error creating process:{0}{1}", Environment.NewLine, ex.Message);
                    MessageBox.Show(errorMessage, this.Text);
                }
            }
        }

        private void btnCreateVariable_Click(object sender, EventArgs e)
        {
            if (VariableNameTextBox.Text.Length == 0)
            {
                MessageBox.Show("Please enter a variable name.");
            }
            else
            {
                ServerProcessInfo procInfo = ProcessesListBox.SelectedItem as ServerProcessInfo;

                if (procInfo != null)
                {
                    try
                    {
                        // if the selected process exists, add a variable
                        procInfo.CreateVariable(VariableNameTextBox.Text);
                    }
                    catch (Exception ex)
                    {
                        string errorMessage = String.Format("Error creating variable:{0}{1}", Environment.NewLine, ex.Message);
                        MessageBox.Show(errorMessage, this.Text);
                    }
                    UpdateVariableList();
                }
                else
                {
                    MessageBox.Show("Please select a process.");
                }
            } 
        }

        private void refreshProcessesItem_Click(object sender, EventArgs e)
        {
            UpdateProcessList();
        }

        private void deleteProcessItem_Click(object sender, EventArgs e)
        {
            ServerProcessInfo procInfo = ProcessesListBox.SelectedItem as ServerProcessInfo;

            if (procInfo != null)
            {
                procInfo.Delete();
                UpdateProcessList();
                UpdateVariableList();
            }
            else
            {
                MessageBox.Show("Please select a process.", this.Text);
            }
        }

        private void refreshVariablesItem_Click(object sender, EventArgs e)
        {
            UpdateVariableList();
        }

        private void deleteVariableItem_Click(object sender, EventArgs e)
        {
            ServerVariableInfo varInfo = VariablesListBox.SelectedItem as ServerVariableInfo;

            if (varInfo != null)
            {
                try
                {
                    varInfo.Delete();
                }
                catch (Exception ex)
                {
                    string errorMessage = String.Format("Error deleting variable:{0}{1}", Environment.NewLine, ex.Message);
                    MessageBox.Show(errorMessage, this.Text);
                }

                UpdateVariableList();
            }
            else
            {
                MessageBox.Show("Please select a variable.", this.Text);
            }
        }
    }
}