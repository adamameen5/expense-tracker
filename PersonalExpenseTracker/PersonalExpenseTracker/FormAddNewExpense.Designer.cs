
namespace PersonalExpenseTracker
{
    partial class FormAddNewExpense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddNewExpense));
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.expenseCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.expenseDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.expenseAmount = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.expensePayee = new System.Windows.Forms.ComboBox();
            this.expenseEvent = new System.Windows.Forms.ComboBox();
            this.expenseAccount = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCurrentTime = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userControlBackToDashboardLink1 = new PersonalExpenseTracker.UserControlBackToDashboardLink();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Payee";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Event";
            // 
            // expenseCode
            // 
            this.expenseCode.Location = new System.Drawing.Point(70, 160);
            this.expenseCode.Name = "expenseCode";
            this.expenseCode.ReadOnly = true;
            this.expenseCode.Size = new System.Drawing.Size(226, 20);
            this.expenseCode.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(371, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Date";
            // 
            // expenseDate
            // 
            this.expenseDate.CustomFormat = "dd/MM/yyyy";
            this.expenseDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.expenseDate.Location = new System.Drawing.Point(436, 160);
            this.expenseDate.Name = "expenseDate";
            this.expenseDate.Size = new System.Drawing.Size(226, 20);
            this.expenseDate.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(371, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Amount";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(371, 264);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Account";
            // 
            // expenseAmount
            // 
            this.expenseAmount.Location = new System.Drawing.Point(436, 210);
            this.expenseAmount.Name = "expenseAmount";
            this.expenseAmount.Size = new System.Drawing.Size(226, 20);
            this.expenseAmount.TabIndex = 29;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(19, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 43);
            this.button1.TabIndex = 30;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.validateExpenseInfo);
            // 
            // expensePayee
            // 
            this.expensePayee.FormattingEnabled = true;
            this.expensePayee.Location = new System.Drawing.Point(70, 210);
            this.expensePayee.Name = "expensePayee";
            this.expensePayee.Size = new System.Drawing.Size(226, 21);
            this.expensePayee.TabIndex = 31;
            this.expensePayee.SelectedIndexChanged += new System.EventHandler(this.OnChangePayeeDropdown);
            // 
            // expenseEvent
            // 
            this.expenseEvent.FormattingEnabled = true;
            this.expenseEvent.Location = new System.Drawing.Point(70, 260);
            this.expenseEvent.Name = "expenseEvent";
            this.expenseEvent.Size = new System.Drawing.Size(226, 21);
            this.expenseEvent.TabIndex = 32;
            // 
            // expenseAccount
            // 
            this.expenseAccount.FormattingEnabled = true;
            this.expenseAccount.Location = new System.Drawing.Point(436, 260);
            this.expenseAccount.Name = "expenseAccount";
            this.expenseAccount.Size = new System.Drawing.Size(226, 21);
            this.expenseAccount.TabIndex = 33;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.AutoSize = true;
            this.lblCurrentTime.Location = new System.Drawing.Point(232, 64);
            this.lblCurrentTime.Name = "lblCurrentTime";
            this.lblCurrentTime.Size = new System.Drawing.Size(30, 13);
            this.lblCurrentTime.TabIndex = 36;
            this.lblCurrentTime.Text = "Time";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(232, 92);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(57, 13);
            this.lblUserName.TabIndex = 35;
            this.lblUserName.Text = "UserName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(231, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 24);
            this.label2.TabIndex = 34;
            this.label2.Text = "Add New Expense";
            // 
            // userControlBackToDashboardLink1
            // 
            this.userControlBackToDashboardLink1.Location = new System.Drawing.Point(19, 389);
            this.userControlBackToDashboardLink1.Name = "userControlBackToDashboardLink1";
            this.userControlBackToDashboardLink1.Size = new System.Drawing.Size(121, 18);
            this.userControlBackToDashboardLink1.TabIndex = 38;
            // 
            // FormAddNewExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 433);
            this.Controls.Add(this.userControlBackToDashboardLink1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblCurrentTime);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.expenseAccount);
            this.Controls.Add(this.expenseEvent);
            this.Controls.Add(this.expensePayee);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.expenseAmount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.expenseDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.expenseCode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "FormAddNewExpense";
            this.Text = "FormAddNewExpense";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox expenseCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker expenseDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox expenseAmount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox expensePayee;
        private System.Windows.Forms.ComboBox expenseEvent;
        private System.Windows.Forms.ComboBox expenseAccount;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCurrentTime;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label label2;
        private UserControlBackToDashboardLink userControlBackToDashboardLink1;
    }
}