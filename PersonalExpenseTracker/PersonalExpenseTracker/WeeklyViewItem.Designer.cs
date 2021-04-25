
namespace PersonalExpenseTracker
{
    partial class WeeklyViewItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelItems = new System.Windows.Forms.Panel();
            this.lblTotalExpenses = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panelItems
            // 
            this.panelItems.AutoScroll = true;
            this.panelItems.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelItems.Location = new System.Drawing.Point(0, 0);
            this.panelItems.Name = "panelItems";
            this.panelItems.Size = new System.Drawing.Size(150, 320);
            this.panelItems.TabIndex = 0;
            // 
            // lblTotalExpenses
            // 
            this.lblTotalExpenses.AutoSize = true;
            this.lblTotalExpenses.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblTotalExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalExpenses.ForeColor = System.Drawing.Color.White;
            this.lblTotalExpenses.Location = new System.Drawing.Point(2, 327);
            this.lblTotalExpenses.Name = "lblTotalExpenses";
            this.lblTotalExpenses.Size = new System.Drawing.Size(80, 13);
            this.lblTotalExpenses.TabIndex = 1;
            this.lblTotalExpenses.Text = "Total Expenses";
            this.lblTotalExpenses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WeeklyViewItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.Controls.Add(this.lblTotalExpenses);
            this.Controls.Add(this.panelItems);
            this.Name = "WeeklyViewItem";
            this.Size = new System.Drawing.Size(150, 360);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelItems;
        private System.Windows.Forms.Label lblTotalExpenses;
    }
}
