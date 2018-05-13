namespace Fishing_Planet_Assistor
{
    partial class frmProcessList
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
            this.btnSelect = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnCancel = new System.Windows.Forms.Button();
            this.lstProcess = new System.Windows.Forms.ListView();
            this.headProcID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headProcName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(4, 314);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(267, 23);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "Use Selected Process";
            this.toolTip1.SetToolTip(this.btnSelect, "Find and select Fishing Planet Process");
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(285, 314);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lstProcess
            // 
            this.lstProcess.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.headProcID,
            this.headProcName});
            this.lstProcess.FullRowSelect = true;
            this.lstProcess.GridLines = true;
            this.lstProcess.HideSelection = false;
            this.lstProcess.Location = new System.Drawing.Point(12, 12);
            this.lstProcess.MultiSelect = false;
            this.lstProcess.Name = "lstProcess";
            this.lstProcess.Size = new System.Drawing.Size(348, 296);
            this.lstProcess.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.lstProcess.TabIndex = 3;
            this.lstProcess.UseCompatibleStateImageBehavior = false;
            this.lstProcess.View = System.Windows.Forms.View.Details;
            // 
            // headProcID
            // 
            this.headProcID.Text = "Process ID";
            this.headProcID.Width = 115;
            // 
            // headProcName
            // 
            this.headProcName.Text = "Process Name";
            this.headProcName.Width = 229;
            // 
            // frmProcessList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 349);
            this.ControlBox = false;
            this.Controls.Add(this.lstProcess);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSelect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmProcessList";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Process List";
            this.Activated += new System.EventHandler(this.frmProcessList_Activated);
            this.Load += new System.EventHandler(this.frmProcessList_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ListView lstProcess;
        private System.Windows.Forms.ColumnHeader headProcID;
        private System.Windows.Forms.ColumnHeader headProcName;
    }
}