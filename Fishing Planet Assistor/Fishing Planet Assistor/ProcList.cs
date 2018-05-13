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
using Assistor;

namespace Fishing_Planet_Assistor
{
    public partial class frmProcessList : Form
    {
        private Process[] processList;
        public frmProcessList()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Get Process List
        /// </summary>
        internal void getProcessList()
        {
            processList = Process.GetProcesses();
            lstProcess.Items.Clear();

            foreach (Process processItem in processList)
            {
                Object processItemName = (Object)processItem.ProcessName;
                Object processItemID = (Object)processItem.Id;

                ListViewItem procItem = new ListViewItem(conversion.toHex((int)processItemID));
                procItem.SubItems.Add(processItemName.ToString());
                lstProcess.Items.Add(procItem);
            }
            lstProcess.Items[0].Selected = true;
        }

        private void frmProcessList_Load(object sender, EventArgs e)
        {
            getProcessList();
        }

        private void frmProcessList_Activated(object sender, EventArgs e)
        {
            getProcessList();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            fishing.processName = lstProcess.SelectedItems[0].SubItems[1].Text;
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
