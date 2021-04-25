
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
            // FormWeeklyView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 674);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateToShowCalendar);
            this.Name = "FormWeeklyView";
            this.Text = "FormWeeklyView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar dateToShowCalendar;
        private System.Windows.Forms.Label label1;
    }
}