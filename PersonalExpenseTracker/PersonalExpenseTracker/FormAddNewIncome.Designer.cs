
namespace PersonalExpenseTracker
{
    partial class FormAddNewIncome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddNewIncome));
            this.button1 = new System.Windows.Forms.Button();
            this.incomeAmount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.incomeDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.incomeCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.incomePayor = new System.Windows.Forms.ComboBox();
            this.incomeEvent = new System.Windows.Forms.ComboBox();
            this.incomeAccount = new System.Windows.Forms.ComboBox();
            this.userControlBackToDashboardLink1 = new PersonalExpenseTracker.UserControlBackToDashboardLink();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCurrentTime = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(32, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 43);
            this.button1.TabIndex = 47;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.validateIncomeInfo);
            // 
            // incomeAmount
            // 
            this.incomeAmount.Location = new System.Drawing.Point(449, 185);
            this.incomeAmount.Name = "incomeAmount";
            this.incomeAmount.Size = new System.Drawing.Size(226, 20);
            this.incomeAmount.TabIndex = 46;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(384, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 45;
            this.label8.Text = "Account";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(384, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "Amount";
            // 
            // incomeDate
            // 
            this.incomeDate.Location = new System.Drawing.Point(449, 135);
            this.incomeDate.Name = "incomeDate";
            this.incomeDate.Size = new System.Drawing.Size(226, 20);
            this.incomeDate.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(384, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "Date";
            // 
            // incomeCode
            // 
            this.incomeCode.Location = new System.Drawing.Point(83, 135);
            this.incomeCode.Name = "incomeCode";
            this.incomeCode.ReadOnly = true;
            this.incomeCode.Size = new System.Drawing.Size(226, 20);
            this.incomeCode.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Event";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Payor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Code";
            // 
            // incomePayor
            // 
            this.incomePayor.FormattingEnabled = true;
            this.incomePayor.Location = new System.Drawing.Point(83, 185);
            this.incomePayor.Name = "incomePayor";
            this.incomePayor.Size = new System.Drawing.Size(226, 21);
            this.incomePayor.TabIndex = 48;
            this.incomePayor.SelectedIndexChanged += new System.EventHandler(this.onChangePayorDropdown);
            // 
            // incomeEvent
            // 
            this.incomeEvent.FormattingEnabled = true;
            this.incomeEvent.Location = new System.Drawing.Point(83, 235);
            this.incomeEvent.Name = "incomeEvent";
            this.incomeEvent.Size = new System.Drawing.Size(226, 21);
            this.incomeEvent.TabIndex = 49;
            // 
            // incomeAccount
            // 
            this.incomeAccount.FormattingEnabled = true;
            this.incomeAccount.Location = new System.Drawing.Point(449, 235);
            this.incomeAccount.Name = "incomeAccount";
            this.incomeAccount.Size = new System.Drawing.Size(226, 21);
            this.incomeAccount.TabIndex = 50;
            // 
            // userControlBackToDashboardLink1
            // 
            this.userControlBackToDashboardLink1.Location = new System.Drawing.Point(32, 368);
            this.userControlBackToDashboardLink1.Name = "userControlBackToDashboardLink1";
            this.userControlBackToDashboardLink1.Size = new System.Drawing.Size(144, 21);
            this.userControlBackToDashboardLink1.TabIndex = 69;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 73;
            this.pictureBox1.TabStop = false;
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.AutoSize = true;
            this.lblCurrentTime.Location = new System.Drawing.Point(246, 55);
            this.lblCurrentTime.Name = "lblCurrentTime";
            this.lblCurrentTime.Size = new System.Drawing.Size(30, 13);
            this.lblCurrentTime.TabIndex = 72;
            this.lblCurrentTime.Text = "Time";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(246, 83);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(57, 13);
            this.lblUserName.TabIndex = 71;
            this.lblUserName.Text = "UserName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(245, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 24);
            this.label2.TabIndex = 70;
            this.label2.Text = "Add New Income";
            // 
            // FormAddNewIncome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 404);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblCurrentTime);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userControlBackToDashboardLink1);
            this.Controls.Add(this.incomeAccount);
            this.Controls.Add(this.incomeEvent);
            this.Controls.Add(this.incomePayor);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.incomeAmount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.incomeDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.incomeCode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "FormAddNewIncome";
            this.Text = "FormAddNewIncome";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox incomeAmount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker incomeDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox incomeCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox incomePayor;
        private System.Windows.Forms.ComboBox incomeEvent;
        private System.Windows.Forms.ComboBox incomeAccount;
        private UserControlBackToDashboardLink userControlBackToDashboardLink1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCurrentTime;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label label2;
    }
}