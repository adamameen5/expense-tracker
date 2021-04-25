
namespace PersonalExpenseTracker
{
    partial class FormWeeklyView
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
            this.dateToShowCalendar = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxKey = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.goBackToEvents = new System.Windows.Forms.LinkLabel();
            this.groupBoxKey.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateToShowCalendar
            // 
            this.dateToShowCalendar.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.dateToShowCalendar.Location = new System.Drawing.Point(16, 40);
            this.dateToShowCalendar.Name = "dateToShowCalendar";
            this.dateToShowCalendar.ShowWeekNumbers = true;
            this.dateToShowCalendar.TabIndex = 0;
            this.dateToShowCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.DatePicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pick a date to show the events for that specific week";
            // 
            // groupBoxKey
            // 
            this.groupBoxKey.Controls.Add(this.panel2);
            this.groupBoxKey.Controls.Add(this.panel1);
            this.groupBoxKey.Controls.Add(this.label3);
            this.groupBoxKey.Controls.Add(this.label2);
            this.groupBoxKey.Location = new System.Drawing.Point(860, 50);
            this.groupBoxKey.Name = "groupBoxKey";
            this.groupBoxKey.Size = new System.Drawing.Size(245, 138);
            this.groupBoxKey.TabIndex = 2;
            this.groupBoxKey.TabStop = false;
            this.groupBoxKey.Text = "Key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Expense";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Income";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Bisque;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(116, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(106, 33);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.AliceBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(116, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(106, 33);
            this.panel2.TabIndex = 3;
            // 
            // goBackToEvents
            // 
            this.goBackToEvents.AutoSize = true;
            this.goBackToEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goBackToEvents.Location = new System.Drawing.Point(12, 650);
            this.goBackToEvents.Name = "goBackToEvents";
            this.goBackToEvents.Size = new System.Drawing.Size(160, 16);
            this.goBackToEvents.TabIndex = 3;
            this.goBackToEvents.TabStop = true;
            this.goBackToEvents.Text = "Go Back To Events Page";
            this.goBackToEvents.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RedirectToEventsPage);
            // 
            // FormWeeklyView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 674);
            this.Controls.Add(this.goBackToEvents);
            this.Controls.Add(this.groupBoxKey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateToShowCalendar);
            this.Name = "FormWeeklyView";
            this.Text = "FormWeeklyView";
            this.groupBoxKey.ResumeLayout(false);
            this.groupBoxKey.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar dateToShowCalendar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxKey;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel goBackToEvents;
    }
}