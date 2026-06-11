namespace BillingSystem
{
    partial class CustomerListForm
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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            btnAdd = new Button();
            btnDelete = new Button();
            btnLogout = new Button();
            btnSearch = new Button();
            textBox1 = new TextBox();
            Customerid = new DataGridViewTextBoxColumn();
            Fullname = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            Contactnumber = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Balance = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(12, 62);
            label1.Name = "label1";
            label1.Size = new Size(106, 20);
            label1.TabIndex = 0;
            label1.Text = "Customer List";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Customerid, Fullname, Address, Contactnumber, Email, Balance });
            dataGridView1.Location = new Point(12, 99);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(758, 188);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAdd.Location = new Point(134, 340);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add\r\n";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDelete.Location = new Point(307, 340);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLogout.Location = new Point(468, 340);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(94, 29);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSearch.Location = new Point(292, 53);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(109, 29);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(414, 54);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(356, 27);
            textBox1.TabIndex = 6;
            // 
            // Customerid
            // 
            Customerid.HeaderText = "ID";
            Customerid.MinimumWidth = 6;
            Customerid.Name = "Customerid";
            Customerid.ReadOnly = true;
            // 
            // Fullname
            // 
            Fullname.HeaderText = "Full Name";
            Fullname.MinimumWidth = 6;
            Fullname.Name = "Fullname";
            Fullname.ReadOnly = true;
            // 
            // Address
            // 
            Address.HeaderText = "Address";
            Address.MinimumWidth = 6;
            Address.Name = "Address";
            Address.ReadOnly = true;
            // 
            // Contactnumber
            // 
            Contactnumber.HeaderText = "Contact No";
            Contactnumber.MinimumWidth = 6;
            Contactnumber.Name = "Contactnumber";
            Contactnumber.ReadOnly = true;
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.ReadOnly = true;
            // 
            // Balance
            // 
            Balance.HeaderText = "Balance";
            Balance.MinimumWidth = 6;
            Balance.Name = "Balance";
            Balance.ReadOnly = true;
            // 
            // CustomerListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 453);
            Controls.Add(textBox1);
            Controls.Add(btnSearch);
            Controls.Add(btnLogout);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "CustomerListForm";
            Text = "Billig System - Customer List";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnLogout;
        private Button btnSearch;
        private TextBox textBox1;
        private DataGridViewTextBoxColumn Customerid;
        private DataGridViewTextBoxColumn Fullname;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn Contactnumber;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Balance;
    }
}