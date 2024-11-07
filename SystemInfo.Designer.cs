namespace System_Info
{
    partial class SystemInfo
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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lblMSID = new System.Windows.Forms.Label();
            this.UUID = new System.Windows.Forms.Label();
            this.hostname = new System.Windows.Forms.Label();
            this.lblOSID = new System.Windows.Forms.Label();
            this.lblPID = new System.Windows.Forms.Label();
            this.lblPhysicalAddress = new System.Windows.Forms.Label();
            this.txtMachineSID = new System.Windows.Forms.TextBox();
            this.txtUUID = new System.Windows.Forms.TextBox();
            this.txthostname = new System.Windows.Forms.TextBox();
            this.txtOSID = new System.Windows.Forms.TextBox();
            this.txtProcessorID = new System.Windows.Forms.TextBox();
            this.txtPhysicalAddress = new System.Windows.Forms.TextBox();
            this.btnExportText = new System.Windows.Forms.Button();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.07255F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.92745F));
            this.tableLayoutPanel.Controls.Add(this.lblMSID, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.UUID, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.hostname, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.lblOSID, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.lblPID, 0, 4);
            this.tableLayoutPanel.Controls.Add(this.lblPhysicalAddress, 0, 5);
            this.tableLayoutPanel.Controls.Add(this.txtMachineSID, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.txtUUID, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.txthostname, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.txtOSID, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.txtProcessorID, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.txtPhysicalAddress, 1, 5);
            this.tableLayoutPanel.Controls.Add(this.btnExportText, 1, 6);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 7;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(827, 228);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // lblMSID
            // 
            this.lblMSID.AutoSize = true;
            this.lblMSID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMSID.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMSID.Location = new System.Drawing.Point(1, 1);
            this.lblMSID.Margin = new System.Windows.Forms.Padding(0);
            this.lblMSID.Name = "lblMSID";
            this.lblMSID.Size = new System.Drawing.Size(165, 31);
            this.lblMSID.TabIndex = 0;
            this.lblMSID.Text = "MSID :";
            // 
            // UUID
            // 
            this.UUID.AutoSize = true;
            this.UUID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UUID.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UUID.Location = new System.Drawing.Point(1, 33);
            this.UUID.Margin = new System.Windows.Forms.Padding(0);
            this.UUID.Name = "UUID";
            this.UUID.Size = new System.Drawing.Size(165, 31);
            this.UUID.TabIndex = 0;
            this.UUID.Text = "UUID :";
            // 
            // hostname
            // 
            this.hostname.AutoSize = true;
            this.hostname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hostname.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hostname.Location = new System.Drawing.Point(1, 65);
            this.hostname.Margin = new System.Windows.Forms.Padding(0);
            this.hostname.Name = "hostname";
            this.hostname.Size = new System.Drawing.Size(165, 31);
            this.hostname.TabIndex = 0;
            this.hostname.Text = "Host Name :";
            // 
            // lblOSID
            // 
            this.lblOSID.AutoSize = true;
            this.lblOSID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOSID.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOSID.Location = new System.Drawing.Point(1, 97);
            this.lblOSID.Margin = new System.Windows.Forms.Padding(0);
            this.lblOSID.Name = "lblOSID";
            this.lblOSID.Size = new System.Drawing.Size(165, 31);
            this.lblOSID.TabIndex = 0;
            this.lblOSID.Text = "OSID :";
            // 
            // lblPID
            // 
            this.lblPID.AutoSize = true;
            this.lblPID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPID.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPID.Location = new System.Drawing.Point(1, 129);
            this.lblPID.Margin = new System.Windows.Forms.Padding(0);
            this.lblPID.Name = "lblPID";
            this.lblPID.Size = new System.Drawing.Size(165, 31);
            this.lblPID.TabIndex = 0;
            this.lblPID.Text = "PID :";
            // 
            // lblPhysicalAddress
            // 
            this.lblPhysicalAddress.AutoSize = true;
            this.lblPhysicalAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPhysicalAddress.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhysicalAddress.Location = new System.Drawing.Point(1, 161);
            this.lblPhysicalAddress.Margin = new System.Windows.Forms.Padding(0);
            this.lblPhysicalAddress.Name = "lblPhysicalAddress";
            this.lblPhysicalAddress.Size = new System.Drawing.Size(165, 31);
            this.lblPhysicalAddress.TabIndex = 0;
            this.lblPhysicalAddress.Text = "PYID :";
            // 
            // txtMachineSID
            // 
            this.txtMachineSID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMachineSID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMachineSID.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMachineSID.Location = new System.Drawing.Point(167, 1);
            this.txtMachineSID.Margin = new System.Windows.Forms.Padding(0);
            this.txtMachineSID.Name = "txtMachineSID";
            this.txtMachineSID.ReadOnly = true;
            this.txtMachineSID.Size = new System.Drawing.Size(659, 29);
            this.txtMachineSID.TabIndex = 1;
            // 
            // txtUUID
            // 
            this.txtUUID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUUID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUUID.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUUID.Location = new System.Drawing.Point(167, 33);
            this.txtUUID.Margin = new System.Windows.Forms.Padding(0);
            this.txtUUID.Name = "txtUUID";
            this.txtUUID.ReadOnly = true;
            this.txtUUID.Size = new System.Drawing.Size(659, 29);
            this.txtUUID.TabIndex = 1;
            // 
            // txthostname
            // 
            this.txthostname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txthostname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txthostname.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthostname.Location = new System.Drawing.Point(167, 65);
            this.txthostname.Margin = new System.Windows.Forms.Padding(0);
            this.txthostname.Name = "txthostname";
            this.txthostname.ReadOnly = true;
            this.txthostname.Size = new System.Drawing.Size(659, 29);
            this.txthostname.TabIndex = 1;
            // 
            // txtOSID
            // 
            this.txtOSID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOSID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOSID.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOSID.Location = new System.Drawing.Point(167, 97);
            this.txtOSID.Margin = new System.Windows.Forms.Padding(0);
            this.txtOSID.Name = "txtOSID";
            this.txtOSID.ReadOnly = true;
            this.txtOSID.Size = new System.Drawing.Size(659, 29);
            this.txtOSID.TabIndex = 1;
            // 
            // txtProcessorID
            // 
            this.txtProcessorID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProcessorID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtProcessorID.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProcessorID.Location = new System.Drawing.Point(167, 129);
            this.txtProcessorID.Margin = new System.Windows.Forms.Padding(0);
            this.txtProcessorID.Name = "txtProcessorID";
            this.txtProcessorID.ReadOnly = true;
            this.txtProcessorID.Size = new System.Drawing.Size(659, 29);
            this.txtProcessorID.TabIndex = 1;
            // 
            // txtPhysicalAddress
            // 
            this.txtPhysicalAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhysicalAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPhysicalAddress.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhysicalAddress.Location = new System.Drawing.Point(167, 161);
            this.txtPhysicalAddress.Margin = new System.Windows.Forms.Padding(0);
            this.txtPhysicalAddress.Name = "txtPhysicalAddress";
            this.txtPhysicalAddress.ReadOnly = true;
            this.txtPhysicalAddress.Size = new System.Drawing.Size(659, 29);
            this.txtPhysicalAddress.TabIndex = 1;
            // 
            // btnExportText
            // 
            this.btnExportText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExportText.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportText.Location = new System.Drawing.Point(167, 193);
            this.btnExportText.Margin = new System.Windows.Forms.Padding(0);
            this.btnExportText.Name = "btnExportText";
            this.btnExportText.Size = new System.Drawing.Size(659, 34);
            this.btnExportText.TabIndex = 2;
            this.btnExportText.Text = "Export Text";
            this.btnExportText.UseVisualStyleBackColor = true;
            this.btnExportText.Click += new System.EventHandler(this.btnExportText_Click_1);
            // 
            // SystemInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 228);
            this.Controls.Add(this.tableLayoutPanel);
            this.MaximizeBox = false;
            this.Name = "SystemInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System Info";
            this.Load += new System.EventHandler(this.SystemInfo_Load);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label lblMSID;
        private System.Windows.Forms.Label UUID;
        private System.Windows.Forms.Label hostname;
        private System.Windows.Forms.Label lblOSID;
        private System.Windows.Forms.Label lblPID;
        private System.Windows.Forms.Label lblPhysicalAddress;
        private System.Windows.Forms.TextBox txtMachineSID;
        private System.Windows.Forms.TextBox txtUUID;
        private System.Windows.Forms.TextBox txthostname;
        private System.Windows.Forms.TextBox txtOSID;
        private System.Windows.Forms.TextBox txtProcessorID;
        private System.Windows.Forms.TextBox txtPhysicalAddress;
        private System.Windows.Forms.Button btnExportText;
    }
}

