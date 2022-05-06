namespace crud_front
{
    partial class addContact_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addContact_Form));
            this.labelFname = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labePhone = new System.Windows.Forms.Label();
            this.labelLname = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.buttAddContact = new System.Windows.Forms.Button();
            this.buttCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelFname
            // 
            this.labelFname.AutoSize = true;
            this.labelFname.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelFname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(17)))), ((int)(((byte)(60)))));
            this.labelFname.Location = new System.Drawing.Point(12, 46);
            this.labelFname.Name = "labelFname";
            this.labelFname.Size = new System.Drawing.Size(107, 25);
            this.labelFname.TabIndex = 2;
            this.labelFname.Text = "FirstName:";
            this.labelFname.Click += new System.EventHandler(this.labelSearch_Click);
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(17)))), ((int)(((byte)(60)))));
            this.labelAddress.Location = new System.Drawing.Point(31, 225);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(88, 25);
            this.labelAddress.TabIndex = 3;
            this.labelAddress.Text = "Address:";
            // 
            // labePhone
            // 
            this.labePhone.AutoSize = true;
            this.labePhone.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labePhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(17)))), ((int)(((byte)(60)))));
            this.labePhone.Location = new System.Drawing.Point(45, 165);
            this.labePhone.Name = "labePhone";
            this.labePhone.Size = new System.Drawing.Size(74, 25);
            this.labePhone.TabIndex = 4;
            this.labePhone.Text = "Phone:";
            // 
            // labelLname
            // 
            this.labelLname.AutoSize = true;
            this.labelLname.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelLname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(17)))), ((int)(((byte)(60)))));
            this.labelLname.Location = new System.Drawing.Point(15, 104);
            this.labelLname.Name = "labelLname";
            this.labelLname.Size = new System.Drawing.Size(104, 25);
            this.labelLname.TabIndex = 5;
            this.labelLname.Text = "LastName:";
            this.labelLname.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(17)))), ((int)(((byte)(60)))));
            this.txtFirstName.Location = new System.Drawing.Point(125, 46);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(218, 33);
            this.txtFirstName.TabIndex = 0;
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(17)))), ((int)(((byte)(60)))));
            this.txtPhone.Location = new System.Drawing.Point(125, 165);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(218, 33);
            this.txtPhone.TabIndex = 2;
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(17)))), ((int)(((byte)(60)))));
            this.txtAddress.Location = new System.Drawing.Point(125, 225);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(218, 33);
            this.txtAddress.TabIndex = 3;
            this.txtAddress.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(17)))), ((int)(((byte)(60)))));
            this.txtLastName.Location = new System.Drawing.Point(125, 104);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(218, 33);
            this.txtLastName.TabIndex = 1;
            // 
            // buttAddContact
            // 
            this.buttAddContact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.buttAddContact.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttAddContact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(17)))), ((int)(((byte)(60)))));
            this.buttAddContact.Location = new System.Drawing.Point(31, 300);
            this.buttAddContact.Name = "buttAddContact";
            this.buttAddContact.Size = new System.Drawing.Size(112, 60);
            this.buttAddContact.TabIndex = 4;
            this.buttAddContact.Text = "Add";
            this.buttAddContact.UseVisualStyleBackColor = false;
            this.buttAddContact.Click += new System.EventHandler(this.buttAddContact_Click);
            // 
            // buttCancel
            // 
            this.buttCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.buttCancel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(17)))), ((int)(((byte)(60)))));
            this.buttCancel.Location = new System.Drawing.Point(231, 300);
            this.buttCancel.Name = "buttCancel";
            this.buttCancel.Size = new System.Drawing.Size(112, 60);
            this.buttCancel.TabIndex = 5;
            this.buttCancel.Text = "Cancel";
            this.buttCancel.UseVisualStyleBackColor = false;
            this.buttCancel.Click += new System.EventHandler(this.buttCancel_Click);
            // 
            // addContact_Form
            // 
            this.AcceptButton = this.buttAddContact;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(50)))));
            this.CancelButton = this.buttCancel;
            this.ClientSize = new System.Drawing.Size(378, 397);
            this.Controls.Add(this.buttCancel);
            this.Controls.Add(this.buttAddContact);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.labelLname);
            this.Controls.Add(this.labePhone);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelFname);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(394, 436);
            this.MinimumSize = new System.Drawing.Size(394, 436);
            this.Name = "addContact_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contact Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelFname;
        private Label labelAddress;
        private Label labePhone;
        private Label labelLname;
        private TextBox txtFirstName;
        private TextBox txtPhone;
        private TextBox txtAddress;
        private TextBox txtLastName;
        private Button buttAddContact;
        private Button buttCancel;
    }
}