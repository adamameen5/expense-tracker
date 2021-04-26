
namespace PersonalExpenseTracker
{
    partial class FormPredictor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPredictor));
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.datePickerSelectedDate = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.lblFinancialStatusHeading = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCurrentTime = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userControlBackToDashboardLink1 = new PersonalExpenseTracker.UserControlBackToDashboardLink();
            this.panelStatus = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.groupBoxLastTwoMonths = new System.Windows.Forms.GroupBox();
            this.groupBoxFutureIncomeExpense = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblIncomeLastTwoMonths = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblFutureIncome = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblExpenseLastTwoMonths = new System.Windows.Forms.Label();
            this.lblFutureExpenses = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelStatus.SuspendLayout();
            this.groupBoxLastTwoMonths.SuspendLayout();
            this.groupBoxFutureIncomeExpense.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(342, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Please select the date to see your predicted financial state on that date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Date";
            // 
            // datePickerSelectedDate
            // 
            this.datePickerSelectedDate.CustomFormat = "dd/MM/yyyy";
            this.datePickerSelectedDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePickerSelectedDate.Location = new System.Drawing.Point(80, 206);
            this.datePickerSelectedDate.Name = "datePickerSelectedDate";
            this.datePickerSelectedDate.Size = new System.Drawing.Size(263, 20);
            this.datePickerSelectedDate.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(28, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(315, 36);
            this.button1.TabIndex = 31;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.ValidateDate);
            // 
            // lblFinancialStatusHeading
            // 
            this.lblFinancialStatusHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinancialStatusHeading.Location = new System.Drawing.Point(23, 12);
            this.lblFinancialStatusHeading.Name = "lblFinancialStatusHeading";
            this.lblFinancialStatusHeading.Size = new System.Drawing.Size(275, 49);
            this.lblFinancialStatusHeading.TabIndex = 34;
            this.lblFinancialStatusHeading.Text = "Predicted financial status on the selected date is a";
            this.lblFinancialStatusHeading.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBoxFutureIncomeExpense);
            this.panel1.Controls.Add(this.groupBoxLastTwoMonths);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Location = new System.Drawing.Point(466, 169);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 260);
            this.panel1.TabIndex = 38;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 41);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(290, 219);
            this.textBox1.TabIndex = 40;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(54, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(177, 20);
            this.label11.TabIndex = 39;
            this.label11.Text = "Calculation based on";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(28, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.AutoSize = true;
            this.lblCurrentTime.Location = new System.Drawing.Point(242, 64);
            this.lblCurrentTime.Name = "lblCurrentTime";
            this.lblCurrentTime.Size = new System.Drawing.Size(30, 13);
            this.lblCurrentTime.TabIndex = 44;
            this.lblCurrentTime.Text = "Time";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(242, 92);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(57, 13);
            this.lblUserName.TabIndex = 43;
            this.lblUserName.Text = "UserName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(241, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 24);
            this.label2.TabIndex = 42;
            this.label2.Text = "Predictor";
            // 
            // userControlBackToDashboardLink1
            // 
            this.userControlBackToDashboardLink1.Location = new System.Drawing.Point(25, 485);
            this.userControlBackToDashboardLink1.Name = "userControlBackToDashboardLink1";
            this.userControlBackToDashboardLink1.Size = new System.Drawing.Size(213, 34);
            this.userControlBackToDashboardLink1.TabIndex = 46;
            // 
            // panelStatus
            // 
            this.panelStatus.BackColor = System.Drawing.Color.AliceBlue;
            this.panelStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelStatus.Controls.Add(this.lblStatus);
            this.panelStatus.Controls.Add(this.lblFinancialStatusHeading);
            this.panelStatus.Location = new System.Drawing.Point(28, 314);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(315, 105);
            this.panelStatus.TabIndex = 47;
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(17, 53);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(281, 41);
            this.lblStatus.TabIndex = 35;
            this.lblStatus.Text = "[status]";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBoxLastTwoMonths
            // 
            this.groupBoxLastTwoMonths.Controls.Add(this.lblExpenseLastTwoMonths);
            this.groupBoxLastTwoMonths.Controls.Add(this.label6);
            this.groupBoxLastTwoMonths.Controls.Add(this.lblIncomeLastTwoMonths);
            this.groupBoxLastTwoMonths.Controls.Add(this.label1);
            this.groupBoxLastTwoMonths.Location = new System.Drawing.Point(11, 53);
            this.groupBoxLastTwoMonths.Name = "groupBoxLastTwoMonths";
            this.groupBoxLastTwoMonths.Size = new System.Drawing.Size(265, 91);
            this.groupBoxLastTwoMonths.TabIndex = 41;
            this.groupBoxLastTwoMonths.TabStop = false;
            this.groupBoxLastTwoMonths.Text = "Last 2 Months Income/Expenses";
            // 
            // groupBoxFutureIncomeExpense
            // 
            this.groupBoxFutureIncomeExpense.Controls.Add(this.lblFutureExpenses);
            this.groupBoxFutureIncomeExpense.Controls.Add(this.label7);
            this.groupBoxFutureIncomeExpense.Controls.Add(this.lblFutureIncome);
            this.groupBoxFutureIncomeExpense.Controls.Add(this.label9);
            this.groupBoxFutureIncomeExpense.Location = new System.Drawing.Point(11, 157);
            this.groupBoxFutureIncomeExpense.Name = "groupBoxFutureIncomeExpense";
            this.groupBoxFutureIncomeExpense.Size = new System.Drawing.Size(265, 91);
            this.groupBoxFutureIncomeExpense.TabIndex = 42;
            this.groupBoxFutureIncomeExpense.TabStop = false;
            this.groupBoxFutureIncomeExpense.Text = "Future Income/Expenses";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Incomes";
            // 
            // lblIncomeLastTwoMonths
            // 
            this.lblIncomeLastTwoMonths.AutoSize = true;
            this.lblIncomeLastTwoMonths.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncomeLastTwoMonths.Location = new System.Drawing.Point(122, 28);
            this.lblIncomeLastTwoMonths.Name = "lblIncomeLastTwoMonths";
            this.lblIncomeLastTwoMonths.Size = new System.Drawing.Size(48, 13);
            this.lblIncomeLastTwoMonths.TabIndex = 1;
            this.lblIncomeLastTwoMonths.Text = "Income";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(49, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Expenses";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(49, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Expenses";
            // 
            // lblFutureIncome
            // 
            this.lblFutureIncome.AutoSize = true;
            this.lblFutureIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFutureIncome.Location = new System.Drawing.Point(122, 33);
            this.lblFutureIncome.Name = "lblFutureIncome";
            this.lblFutureIncome.Size = new System.Drawing.Size(48, 13);
            this.lblFutureIncome.TabIndex = 4;
            this.lblFutureIncome.Text = "Income";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(49, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Incomes";
            // 
            // lblExpenseLastTwoMonths
            // 
            this.lblExpenseLastTwoMonths.AutoSize = true;
            this.lblExpenseLastTwoMonths.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpenseLastTwoMonths.Location = new System.Drawing.Point(122, 57);
            this.lblExpenseLastTwoMonths.Name = "lblExpenseLastTwoMonths";
            this.lblExpenseLastTwoMonths.Size = new System.Drawing.Size(48, 13);
            this.lblExpenseLastTwoMonths.TabIndex = 3;
            this.lblExpenseLastTwoMonths.Text = "Income";
            // 
            // lblFutureExpenses
            // 
            this.lblFutureExpenses.AutoSize = true;
            this.lblFutureExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFutureExpenses.Location = new System.Drawing.Point(122, 62);
            this.lblFutureExpenses.Name = "lblFutureExpenses";
            this.lblFutureExpenses.Size = new System.Drawing.Size(48, 13);
            this.lblFutureExpenses.TabIndex = 6;
            this.lblFutureExpenses.Text = "Income";
            // 
            // FormPredictor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 530);
            this.Controls.Add(this.panelStatus);
            this.Controls.Add(this.userControlBackToDashboardLink1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblCurrentTime);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.datePickerSelectedDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "FormPredictor";
            this.Text = "FormPredictor";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelStatus.ResumeLayout(false);
            this.groupBoxLastTwoMonths.ResumeLayout(false);
            this.groupBoxLastTwoMonths.PerformLayout();
            this.groupBoxFutureIncomeExpense.ResumeLayout(false);
            this.groupBoxFutureIncomeExpense.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker datePickerSelectedDate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblFinancialStatusHeading;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCurrentTime;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label label2;
        private UserControlBackToDashboardLink userControlBackToDashboardLink1;
        private System.Windows.Forms.Panel panelStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.GroupBox groupBoxFutureIncomeExpense;
        private System.Windows.Forms.Label lblFutureExpenses;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblFutureIncome;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBoxLastTwoMonths;
        private System.Windows.Forms.Label lblExpenseLastTwoMonths;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblIncomeLastTwoMonths;
        private System.Windows.Forms.Label label1;
    }
}