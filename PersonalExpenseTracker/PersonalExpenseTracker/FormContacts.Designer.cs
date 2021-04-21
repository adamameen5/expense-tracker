
namespace PersonalExpenseTracker
{
    partial class FormContacts
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormContacts));
            this.tabContacts = new System.Windows.Forms.TabControl();
            this.tabPayor = new System.Windows.Forms.TabPage();
            this.dataGridPayor = new System.Windows.Forms.DataGridView();
            this.tabPayee = new System.Windows.Forms.TabPage();
            this.dataGridPayee = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCurrentTime = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userControlBackToDashboardLink1 = new PersonalExpenseTracker.UserControlBackToDashboardLink();
            this.expenseGuide = new PersonalExpenseTracker.ExpenseGuide();
            this.expenseGuideBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contactBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contactIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKUserIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactTelephoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabContacts.SuspendLayout();
            this.tabPayor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPayor)).BeginInit();
            this.tabPayee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPayee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseGuide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseGuideBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabContacts
            // 
            this.tabContacts.Controls.Add(this.tabPayor);
            this.tabContacts.Controls.Add(this.tabPayee);
            this.tabContacts.Location = new System.Drawing.Point(29, 173);
            this.tabContacts.Name = "tabContacts";
            this.tabContacts.SelectedIndex = 0;
            this.tabContacts.Size = new System.Drawing.Size(612, 293);
            this.tabContacts.TabIndex = 11;
            // 
            // tabPayor
            // 
            this.tabPayor.Controls.Add(this.dataGridPayor);
            this.tabPayor.Location = new System.Drawing.Point(4, 22);
            this.tabPayor.Name = "tabPayor";
            this.tabPayor.Padding = new System.Windows.Forms.Padding(3);
            this.tabPayor.Size = new System.Drawing.Size(604, 267);
            this.tabPayor.TabIndex = 0;
            this.tabPayor.Text = "Payor";
            this.tabPayor.UseVisualStyleBackColor = true;
            // 
            // dataGridPayor
            // 
            this.dataGridPayor.AutoGenerateColumns = false;
            this.dataGridPayor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPayor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.contactIDDataGridViewTextBoxColumn,
            this.contactNameDataGridViewTextBoxColumn,
            this.contactDescriptionDataGridViewTextBoxColumn,
            this.contactTypeDataGridViewTextBoxColumn,
            this.fKUserIDDataGridViewTextBoxColumn,
            this.contactTelephoneNumberDataGridViewTextBoxColumn});
            this.dataGridPayor.DataSource = this.contactBindingSource;
            this.dataGridPayor.Location = new System.Drawing.Point(0, -3);
            this.dataGridPayor.Name = "dataGridPayor";
            this.dataGridPayor.Size = new System.Drawing.Size(604, 267);
            this.dataGridPayor.TabIndex = 0;
            // 
            // tabPayee
            // 
            this.tabPayee.Controls.Add(this.dataGridPayee);
            this.tabPayee.Location = new System.Drawing.Point(4, 22);
            this.tabPayee.Name = "tabPayee";
            this.tabPayee.Padding = new System.Windows.Forms.Padding(3);
            this.tabPayee.Size = new System.Drawing.Size(604, 267);
            this.tabPayee.TabIndex = 1;
            this.tabPayee.Text = "Payee";
            this.tabPayee.UseVisualStyleBackColor = true;
            // 
            // dataGridPayee
            // 
            this.dataGridPayee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPayee.Location = new System.Drawing.Point(0, 0);
            this.dataGridPayee.Name = "dataGridPayee";
            this.dataGridPayee.Size = new System.Drawing.Size(604, 267);
            this.dataGridPayee.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DodgerBlue;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(27, 492);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(148, 43);
            this.button4.TabIndex = 21;
            this.button4.Text = "Add New Payor";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.toggleAddNewPayorView);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(206, 492);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 43);
            this.button1.TabIndex = 22;
            this.button1.Text = "Add New Payee";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.toggleAddNewPayeeView);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.AutoSize = true;
            this.lblCurrentTime.Location = new System.Drawing.Point(243, 76);
            this.lblCurrentTime.Name = "lblCurrentTime";
            this.lblCurrentTime.Size = new System.Drawing.Size(30, 13);
            this.lblCurrentTime.TabIndex = 40;
            this.lblCurrentTime.Text = "Time";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(243, 104);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(57, 13);
            this.lblUserName.TabIndex = 39;
            this.lblUserName.Text = "UserName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(242, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 38;
            this.label2.Text = "Contacts";
            // 
            // userControlBackToDashboardLink1
            // 
            this.userControlBackToDashboardLink1.Location = new System.Drawing.Point(27, 554);
            this.userControlBackToDashboardLink1.Name = "userControlBackToDashboardLink1";
            this.userControlBackToDashboardLink1.Size = new System.Drawing.Size(148, 16);
            this.userControlBackToDashboardLink1.TabIndex = 42;
            // 
            // expenseGuide
            // 
            this.expenseGuide.DataSetName = "ExpenseGuide";
            this.expenseGuide.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // expenseGuideBindingSource
            // 
            this.expenseGuideBindingSource.DataSource = this.expenseGuide;
            this.expenseGuideBindingSource.Position = 0;
            // 
            // contactBindingSource
            // 
            this.contactBindingSource.DataMember = "Contact";
            this.contactBindingSource.DataSource = this.expenseGuide;
            // 
            // contactIDDataGridViewTextBoxColumn
            // 
            this.contactIDDataGridViewTextBoxColumn.DataPropertyName = "ContactID";
            this.contactIDDataGridViewTextBoxColumn.HeaderText = "ContactID";
            this.contactIDDataGridViewTextBoxColumn.Name = "contactIDDataGridViewTextBoxColumn";
            // 
            // contactNameDataGridViewTextBoxColumn
            // 
            this.contactNameDataGridViewTextBoxColumn.DataPropertyName = "ContactName";
            this.contactNameDataGridViewTextBoxColumn.HeaderText = "ContactName";
            this.contactNameDataGridViewTextBoxColumn.Name = "contactNameDataGridViewTextBoxColumn";
            // 
            // contactDescriptionDataGridViewTextBoxColumn
            // 
            this.contactDescriptionDataGridViewTextBoxColumn.DataPropertyName = "ContactDescription";
            this.contactDescriptionDataGridViewTextBoxColumn.HeaderText = "ContactDescription";
            this.contactDescriptionDataGridViewTextBoxColumn.Name = "contactDescriptionDataGridViewTextBoxColumn";
            // 
            // contactTypeDataGridViewTextBoxColumn
            // 
            this.contactTypeDataGridViewTextBoxColumn.DataPropertyName = "ContactType";
            this.contactTypeDataGridViewTextBoxColumn.HeaderText = "ContactType";
            this.contactTypeDataGridViewTextBoxColumn.Name = "contactTypeDataGridViewTextBoxColumn";
            // 
            // fKUserIDDataGridViewTextBoxColumn
            // 
            this.fKUserIDDataGridViewTextBoxColumn.DataPropertyName = "FK_UserID";
            this.fKUserIDDataGridViewTextBoxColumn.HeaderText = "FK_UserID";
            this.fKUserIDDataGridViewTextBoxColumn.Name = "fKUserIDDataGridViewTextBoxColumn";
            // 
            // contactTelephoneNumberDataGridViewTextBoxColumn
            // 
            this.contactTelephoneNumberDataGridViewTextBoxColumn.DataPropertyName = "ContactTelephoneNumber";
            this.contactTelephoneNumberDataGridViewTextBoxColumn.HeaderText = "ContactTelephoneNumber";
            this.contactTelephoneNumberDataGridViewTextBoxColumn.Name = "contactTelephoneNumberDataGridViewTextBoxColumn";
            // 
            // FormContacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 592);
            this.Controls.Add(this.userControlBackToDashboardLink1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblCurrentTime);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.tabContacts);
            this.MaximizeBox = false;
            this.Name = "FormContacts";
            this.Text = "FormContacts";
            this.Load += new System.EventHandler(this.FormContacts_Load);
            this.tabContacts.ResumeLayout(false);
            this.tabPayor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPayor)).EndInit();
            this.tabPayee.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPayee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseGuide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseGuideBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabContacts;
        private System.Windows.Forms.TabPage tabPayor;
        private System.Windows.Forms.TabPage tabPayee;
        private System.Windows.Forms.DataGridView dataGridPayee;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCurrentTime;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label label2;
        private UserControlBackToDashboardLink userControlBackToDashboardLink1;
        private System.Windows.Forms.DataGridView dataGridPayor;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fKUserIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactTelephoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource contactBindingSource;
        private ExpenseGuide expenseGuide;
        private System.Windows.Forms.BindingSource expenseGuideBindingSource;
    }
}