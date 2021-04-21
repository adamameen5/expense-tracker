
namespace PersonalExpenseTracker
{
    partial class FormAddNewPayor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddNewPayor));
            this.payorName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.payorDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.payorTelephoneNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCurrentTime = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userControlBackToDashboardLink1 = new PersonalExpenseTracker.UserControlBackToDashboardLink();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // payorName
            // 
            this.payorName.Location = new System.Drawing.Point(130, 148);
            this.payorName.Name = "payorName";
            this.payorName.Size = new System.Drawing.Size(257, 20);
            this.payorName.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Payor Name";
            // 
            // payorDescription
            // 
            this.payorDescription.Location = new System.Drawing.Point(130, 188);
            this.payorDescription.Multiline = true;
            this.payorDescription.Name = "payorDescription";
            this.payorDescription.Size = new System.Drawing.Size(257, 114);
            this.payorDescription.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "Payor Description";
            // 
            // payorTelephoneNumber
            // 
            this.payorTelephoneNumber.Location = new System.Drawing.Point(130, 325);
            this.payorTelephoneNumber.Name = "payorTelephoneNumber";
            this.payorTelephoneNumber.Size = new System.Drawing.Size(257, 20);
            this.payorTelephoneNumber.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "Contact Number";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DodgerBlue;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(32, 375);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(148, 43);
            this.button4.TabIndex = 50;
            this.button4.Text = "Save";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.validatePayorInfo);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.AutoSize = true;
            this.lblCurrentTime.Location = new System.Drawing.Point(246, 64);
            this.lblCurrentTime.Name = "lblCurrentTime";
            this.lblCurrentTime.Size = new System.Drawing.Size(30, 13);
            this.lblCurrentTime.TabIndex = 53;
            this.lblCurrentTime.Text = "Time";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(246, 92);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(57, 13);
            this.lblUserName.TabIndex = 52;
            this.lblUserName.Text = "UserName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(245, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 24);
            this.label2.TabIndex = 51;
            this.label2.Text = "Add New Payor";
            // 
            // userControlBackToDashboardLink1
            // 
            this.userControlBackToDashboardLink1.Location = new System.Drawing.Point(32, 436);
            this.userControlBackToDashboardLink1.Name = "userControlBackToDashboardLink1";
            this.userControlBackToDashboardLink1.Size = new System.Drawing.Size(147, 20);
            this.userControlBackToDashboardLink1.TabIndex = 55;
            // 
            // FormAddNewPayor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 475);
            this.Controls.Add(this.userControlBackToDashboardLink1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblCurrentTime);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.payorTelephoneNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.payorDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.payorName);
            this.Controls.Add(this.label5);
            this.Name = "FormAddNewPayor";
            this.Text = "FormAddNewPayor";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox payorName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox payorDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox payorTelephoneNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCurrentTime;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label label2;
        private UserControlBackToDashboardLink userControlBackToDashboardLink1;
    }
}