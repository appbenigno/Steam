using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fishing_Planet_Assistor
{
    public partial class frmProcessList : Form
    {
        private Process[] processList;
        public frmProcessList()
        {
            InitializeComponent();
        }

        private void frmProcessList_Load(object sender, EventArgs e)
        {
            processList = Process.GetProcesses();
            cmbProcess.Items.Clear();

            foreach (Process processItem in processList)
            {
                Object processItemName = (Object)processItem.ProcessName;
                Object processItemID = (Object)processItem.Id;
                cmbProcess.Items.Add(processItemName);
            }
        }

        private void frmProcessList_Activated(object sender, EventArgs e)
        {
            processList = Process.GetProcesses();
            cmbProcess.Items.Clear();

            foreach (Process processItem in processList)
            {
                Object processItemName = (Object)processItem.ProcessName;
                Object processItemID = (Object)processItem.Id;
                cmbProcess.Items.Add(processItemName);
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            fishing.processName = (String)cmbProcess.SelectedItem;
            fishing.programName = fishing.processName;
            MyForms.MainForm.Show();
            MyForms.ProcessList.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MyForms.MainForm.Show();
            MyForms.ProcessList.Hide();
        }
    }
}
