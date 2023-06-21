
namespace UsersApp
{
    partial class FrmUsers
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
            System.Windows.Forms.Label countryLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label passwordLabel;
            this.PnlTitle = new System.Windows.Forms.Panel();
            this.PnlInput = new System.Windows.Forms.Panel();
            this.userDataGridView = new System.Windows.Forms.DataGridView();
            this.PnlButton = new System.Windows.Forms.Panel();
            this.BtnDelete = new FontAwesome.Sharp.IconButton();
            this.BtnEdit = new FontAwesome.Sharp.IconButton();
            this.BtnCreate = new FontAwesome.Sharp.IconButton();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            countryLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            this.PnlInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).BeginInit();
            this.PnlButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Location = new System.Drawing.Point(18, 161);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new System.Drawing.Size(66, 21);
            countryLabel.TabIndex = 0;
            countryLabel.Text = "Country:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(18, 97);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(54, 21);
            emailLabel.TabIndex = 2;
            emailLabel.Text = "Email:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(18, 30);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(27, 21);
            idLabel.TabIndex = 4;
            idLabel.Text = "Id:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(18, 65);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(55, 21);
            nameLabel.TabIndex = 6;
            nameLabel.Text = "Name:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(18, 129);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(80, 21);
            passwordLabel.TabIndex = 8;
            passwordLabel.Text = "Password:";
            // 
            // PnlTitle
            // 
            this.PnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTitle.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PnlTitle.ForeColor = System.Drawing.Color.OrangeRed;
            this.PnlTitle.Location = new System.Drawing.Point(0, 0);
            this.PnlTitle.Name = "PnlTitle";
            this.PnlTitle.Size = new System.Drawing.Size(900, 63);
            this.PnlTitle.TabIndex = 0;
            // 
            // PnlInput
            // 
            this.PnlInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PnlInput.Controls.Add(this.userDataGridView);
            this.PnlInput.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlInput.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PnlInput.ForeColor = System.Drawing.Color.RoyalBlue;
            this.PnlInput.Location = new System.Drawing.Point(0, 63);
            this.PnlInput.Name = "PnlInput";
            this.PnlInput.Size = new System.Drawing.Size(511, 323);
            this.PnlInput.TabIndex = 1;
            // 
            // userDataGridView
            // 
            this.userDataGridView.AutoGenerateColumns = false;
            this.userDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.userDataGridView.DataSource = this.userBindingSource;
            this.userDataGridView.Location = new System.Drawing.Point(0, 0);
            this.userDataGridView.Name = "userDataGridView";
            this.userDataGridView.Size = new System.Drawing.Size(508, 323);
            this.userDataGridView.TabIndex = 0;
            this.userDataGridView.MouseEnter += new System.EventHandler(this.userDataGridView_MouseEnter);
            // 
            // PnlButton
            // 
            this.PnlButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(153)))));
            this.PnlButton.Controls.Add(this.BtnDelete);
            this.PnlButton.Controls.Add(this.BtnEdit);
            this.PnlButton.Controls.Add(this.BtnCreate);
            this.PnlButton.Controls.Add(countryLabel);
            this.PnlButton.Controls.Add(this.countryTextBox);
            this.PnlButton.Controls.Add(emailLabel);
            this.PnlButton.Controls.Add(this.emailTextBox);
            this.PnlButton.Controls.Add(idLabel);
            this.PnlButton.Controls.Add(this.idTextBox);
            this.PnlButton.Controls.Add(nameLabel);
            this.PnlButton.Controls.Add(this.nameTextBox);
            this.PnlButton.Controls.Add(passwordLabel);
            this.PnlButton.Controls.Add(this.passwordTextBox);
            this.PnlButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.PnlButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PnlButton.ForeColor = System.Drawing.Color.Blue;
            this.PnlButton.Location = new System.Drawing.Point(509, 63);
            this.PnlButton.Name = "PnlButton";
            this.PnlButton.Size = new System.Drawing.Size(391, 323);
            this.PnlButton.TabIndex = 1;
            // 
            // BtnDelete
            // 
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.IconChar = FontAwesome.Sharp.IconChar.UserMinus;
            this.BtnDelete.IconColor = System.Drawing.Color.Red;
            this.BtnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnDelete.IconSize = 22;
            this.BtnDelete.Location = new System.Drawing.Point(279, 237);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(96, 29);
            this.BtnDelete.TabIndex = 8;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            this.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEdit.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.BtnEdit.IconColor = System.Drawing.Color.Red;
            this.BtnEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnEdit.IconSize = 22;
            this.BtnEdit.Location = new System.Drawing.Point(156, 237);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(96, 29);
            this.BtnEdit.TabIndex = 7;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnCreate
            // 
            this.BtnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCreate.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.BtnCreate.IconColor = System.Drawing.Color.Red;
            this.BtnCreate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCreate.IconSize = 22;
            this.BtnCreate.Location = new System.Drawing.Point(22, 237);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(96, 29);
            this.BtnCreate.TabIndex = 6;
            this.BtnCreate.Text = "Create";
            this.BtnCreate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCreate.UseVisualStyleBackColor = true;
            // 
            // countryTextBox
            // 
            this.countryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Country", true));
            this.countryTextBox.Location = new System.Drawing.Point(104, 158);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(271, 26);
            this.countryTextBox.TabIndex = 5;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(104, 94);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(271, 26);
            this.emailTextBox.TabIndex = 3;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Id", true));
            this.idTextBox.Enabled = false;
            this.idTextBox.Location = new System.Drawing.Point(104, 27);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(271, 26);
            this.idTextBox.TabIndex = 1;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(104, 62);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(271, 26);
            this.nameTextBox.TabIndex = 2;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(104, 126);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(271, 26);
            this.passwordTextBox.TabIndex = 4;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(UsersApp.User);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 120;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn3.HeaderText = "Email";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Password";
            this.dataGridViewTextBoxColumn4.HeaderText = "Password";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Country";
            this.dataGridViewTextBoxColumn5.HeaderText = "Country";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // FrmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 386);
            this.Controls.Add(this.PnlButton);
            this.Controls.Add(this.PnlInput);
            this.Controls.Add(this.PnlTitle);
            this.Name = "FrmUsers";
            this.Text = "Users Management";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PnlInput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).EndInit();
            this.PnlButton.ResumeLayout(false);
            this.PnlButton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlTitle;
        private System.Windows.Forms.Panel PnlInput;
        private System.Windows.Forms.Panel PnlButton;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.DataGridView userDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private FontAwesome.Sharp.IconButton BtnDelete;
        private FontAwesome.Sharp.IconButton BtnEdit;
        private FontAwesome.Sharp.IconButton BtnCreate;
    }
}

