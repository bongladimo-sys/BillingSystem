namespace BillingSystem
{
    partial class AddCustomerForm
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
            lbltitle = new Label();
            lblFullname = new Label();
            txtaddress = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            lblcontact = new Label();
            textBox3 = new TextBox();
            lblemail = new Label();
            textBox4 = new TextBox();
            lblbalance = new Label();
            textBox5 = new TextBox();
            btnsave = new Button();
            btnclear = new Button();
            btnback = new Button();
            SuspendLayout();
            // 
            // lbltitle
            // 
            lbltitle.AutoSize = true;
            lbltitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbltitle.Location = new Point(89, 44);
            lbltitle.Name = "lbltitle";
            lbltitle.Size = new Size(146, 20);
            lbltitle.TabIndex = 0;
            lbltitle.Text = "Add New Customer\r\n";
            // 
            // lblFullname
            // 
            lblFullname.AutoSize = true;
            lblFullname.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFullname.Location = new Point(25, 79);
            lblFullname.Name = "lblFullname";
            lblFullname.Size = new Size(84, 20);
            lblFullname.TabIndex = 1;
            lblFullname.Text = "Full Name:";
            // 
            // txtaddress
            // 
            txtaddress.AutoSize = true;
            txtaddress.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtaddress.Location = new Point(25, 111);
            txtaddress.Name = "txtaddress";
            txtaddress.Size = new Size(70, 20);
            txtaddress.TabIndex = 2;
            txtaddress.Text = "Address:\r\n";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(116, 79);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(220, 27);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(116, 112);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(220, 27);
            textBox2.TabIndex = 4;
            // 
            // lblcontact
            // 
            lblcontact.AutoSize = true;
            lblcontact.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblcontact.Location = new Point(23, 155);
            lblcontact.Name = "lblcontact";
            lblcontact.Size = new Size(92, 20);
            lblcontact.TabIndex = 5;
            lblcontact.Text = "Contact No.";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(116, 155);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(220, 27);
            textBox3.TabIndex = 6;
            // 
            // lblemail
            // 
            lblemail.AutoSize = true;
            lblemail.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblemail.Location = new Point(23, 196);
            lblemail.Name = "lblemail";
            lblemail.Size = new Size(51, 20);
            lblemail.TabIndex = 7;
            lblemail.Text = "Email:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(116, 196);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(220, 27);
            textBox4.TabIndex = 8;
            // 
            // lblbalance
            // 
            lblbalance.AutoSize = true;
            lblbalance.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblbalance.Location = new Point(25, 240);
            lblbalance.Name = "lblbalance";
            lblbalance.Size = new Size(79, 20);
            lblbalance.TabIndex = 9;
            lblbalance.Text = "Initial Bal.";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(121, 240);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(215, 27);
            textBox5.TabIndex = 10;
            textBox5.Text = "0.00";
            // 
            // btnsave
            // 
            btnsave.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnsave.Location = new Point(51, 289);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(94, 29);
            btnsave.TabIndex = 11;
            btnsave.Text = "Save";
            btnsave.UseVisualStyleBackColor = true;
            // 
            // btnclear
            // 
            btnclear.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnclear.Location = new Point(162, 289);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(94, 29);
            btnclear.TabIndex = 12;
            btnclear.Text = "Clear";
            btnclear.UseVisualStyleBackColor = true;
            // 
            // btnback
            // 
            btnback.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnback.Location = new Point(276, 289);
            btnback.Name = "btnback";
            btnback.Size = new Size(94, 29);
            btnback.TabIndex = 13;
            btnback.Text = "Back";
            btnback.UseVisualStyleBackColor = true;
            // 
            // AddCustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 373);
            Controls.Add(btnback);
            Controls.Add(btnclear);
            Controls.Add(btnsave);
            Controls.Add(textBox5);
            Controls.Add(lblbalance);
            Controls.Add(textBox4);
            Controls.Add(lblemail);
            Controls.Add(textBox3);
            Controls.Add(lblcontact);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(txtaddress);
            Controls.Add(lblFullname);
            Controls.Add(lbltitle);
            Name = "AddCustomerForm";
            Text = "Billing System - Add Customer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbltitle;
        private Label lblFullname;
        private Label txtaddress;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label lblcontact;
        private TextBox textBox3;
        private Label lblemail;
        private TextBox textBox4;
        private Label lblbalance;
        private TextBox textBox5;
        private Button btnsave;
        private Button btnclear;
        private Button btnback;
    }
}