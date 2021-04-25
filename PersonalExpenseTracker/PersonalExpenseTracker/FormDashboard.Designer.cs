
namespace PersonalExpenseTracker
{
    partial class FormDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDashboard));
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnContacts = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.bntLogout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCurrentTime = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(24, 142);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(148, 43);
            this.btnSubmit.TabIndex = 16;
            this.btnSubmit.Text = "Expenses";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.toggleExpensesView);
            // 
            // btnContacts
            // 
            this.btnContacts.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnContacts.ForeColor = System.Drawing.Color.White;
            this.btnContacts.Location = new System.Drawing.Point(24, 216);
            this.btnContacts.Name = "btnContacts";
            this.btnContacts.Size = new System.Drawing.Size(148, 43);
            this.btnContacts.TabIndex = 17;
            this.btnContacts.Text = "Contacts";
            this.btnContacts.UseVisualStyleBackColor = false;
            this.btnContacts.Click += new System.EventHandler(this.toggleContactsView);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DodgerBlue;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(24, 290);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 43);
            this.button2.TabIndex = 18;
            this.button2.Text = "My Accounts";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DodgerBlue;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(200, 290);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 43);
            this.button3.TabIndex = 21;
            this.button3.Text = "My Info";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.toggleUserInfoView);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DodgerBlue;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(200, 216);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(148, 43);
            this.button4.TabIndex = 20;
            this.button4.Text = "Predictor";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.togglePredictorView);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DodgerBlue;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(200, 142);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(148, 43);
            this.button5.TabIndex = 19;
            this.button5.Text = "Income";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.toggleIncomesView);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.DodgerBlue;
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(377, 290);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(148, 43);
            this.button6.TabIndex = 24;
            this.button6.Text = "Events";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.toggleEventsView);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.DodgerBlue;
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(377, 216);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(148, 43);
            this.button7.TabIndex = 23;
            this.button7.Text = "Reports";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.DodgerBlue;
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(377, 142);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(148, 43);
            this.button8.TabIndex = 22;
            this.button8.Text = "Savings";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // bntLogout
            // 
            this.bntLogout.BackColor = System.Drawing.Color.Gray;
            this.bntLogout.ForeColor = System.Drawing.Color.White;
            this.bntLogout.Location = new System.Drawing.Point(214, 367);
            this.bntLogout.Name = "bntLogout";
            this.bntLogout.Size = new System.Drawing.Size(120, 43);
            this.bntLogout.TabIndex = 25;
            this.bntLogout.Text = "Logout";
            this.bntLogout.UseVisualStyleBackColor = false;
            this.bntLogout.Click += new System.EventHandler(this.Logout);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.AutoSize = true;
            this.lblCurrentTime.Location = new System.Drawing.Point(238, 64);
            this.lblCurrentTime.Name = "lblCurrentTime";
            this.lblCurrentTime.Size = new System.Drawing.Size(30, 13);
            this.lblCurrentTime.TabIndex = 44;
            this.lblCurrentTime.Text = "Time";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(238, 92);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(57, 13);
            this.lblUserName.TabIndex = 43;
            this.lblUserName.Text = "UserName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(237, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 24);
            this.label2.TabIndex = 42;
            this.label2.Text = "Dashboard";
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 435);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblCurrentTime);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bntLogout);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnContacts);
            this.Controls.Add(this.btnSubmit);
            this.Name = "FormDashboard";
            this.Text = "FormDashboard";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnContacts;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button bntLogout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCurrentTime;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label label2;
    }
}