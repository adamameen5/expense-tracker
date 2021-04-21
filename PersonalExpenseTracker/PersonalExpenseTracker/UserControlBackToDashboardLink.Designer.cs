
namespace PersonalExpenseTracker
{
    partial class UserControlBackToDashboardLink
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
            this.linkGoBackToDashboard = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // linkGoBackToDashboard
            // 
            this.linkGoBackToDashboard.AutoSize = true;
            this.linkGoBackToDashboard.Location = new System.Drawing.Point(3, 0);
            this.linkGoBackToDashboard.Name = "linkGoBackToDashboard";
            this.linkGoBackToDashboard.Size = new System.Drawing.Size(115, 13);
            this.linkGoBackToDashboard.TabIndex = 64;
            this.linkGoBackToDashboard.TabStop = true;
            this.linkGoBackToDashboard.Text = "Go back to Dashboard";
            this.linkGoBackToDashboard.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkBackToDashboard);
            // 
            // UserControlBackToDashboardLink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.linkGoBackToDashboard);
            this.Name = "UserControlBackToDashboardLink";
            this.Size = new System.Drawing.Size(115, 13);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkGoBackToDashboard;
    }
}
