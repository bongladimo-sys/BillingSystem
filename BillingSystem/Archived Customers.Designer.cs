namespace BillingSystem
{
    partial class Archived_Customers
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
            dataGridView1 = new DataGridView();
            CustomerID = new DataGridViewTextBoxColumn();
            Fullname = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            lblArchivedCustomers = new Label();
            btnClose = new Button();
            btnUnarchive = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { CustomerID, Fullname, Address, Status });
            dataGridView1.Location = new Point(52, 87);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(547, 243);
            dataGridView1.TabIndex = 0;
            // 
            // CustomerID
            // 
            CustomerID.HeaderText = "Customer ID";
            CustomerID.MinimumWidth = 6;
            CustomerID.Name = "CustomerID";
            CustomerID.Width = 125;
            // 
            // Fullname
            // 
            Fullname.HeaderText = "Full Name";
            Fullname.MinimumWidth = 6;
            Fullname.Name = "Fullname";
            Fullname.Width = 125;
            // 
            // Address
            // 
            Address.HeaderText = "Address";
            Address.MinimumWidth = 6;
            Address.Name = "Address";
            Address.Width = 125;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.Width = 125;
            // 
            // lblArchivedCustomers
            // 
            lblArchivedCustomers.AutoSize = true;
            lblArchivedCustomers.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblArchivedCustomers.Location = new Point(52, 36);
            lblArchivedCustomers.Name = "lblArchivedCustomers";
            lblArchivedCustomers.Size = new Size(170, 23);
            lblArchivedCustomers.TabIndex = 1;
            lblArchivedCustomers.Text = "Archived Customers";
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnClose.Location = new Point(476, 358);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(123, 29);
            btnClose.TabIndex = 2;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // btnUnarchive
            // 
            btnUnarchive.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnUnarchive.Location = new Point(340, 358);
            btnUnarchive.Name = "btnUnarchive";
            btnUnarchive.Size = new Size(126, 29);
            btnUnarchive.TabIndex = 3;
            btnUnarchive.Text = " Unarchive";
            btnUnarchive.UseVisualStyleBackColor = true;
            // 
            // Archived_Customers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 413);
            Controls.Add(btnUnarchive);
            Controls.Add(btnClose);
            Controls.Add(lblArchivedCustomers);
            Controls.Add(dataGridView1);
            Name = "Archived_Customers";
            Text = "Archived_Customers";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn CustomerID;
        private DataGridViewTextBoxColumn Fullname;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn Status;
        private Label lblArchivedCustomers;
        private Button btnClose;
        private Button btnUnarchive;
    }
}