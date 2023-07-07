
namespace DataTableApp
{
    partial class FrmStudents
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DgvStudents = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TxtCourse = new System.Windows.Forms.TextBox();
            this.TxtClass = new System.Windows.Forms.TextBox();
            this.TxtAge = new System.Windows.Forms.TextBox();
            this.TxtLastName = new System.Windows.Forms.TextBox();
            this.TxtFirstName = new System.Windows.Forms.TextBox();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.LblCourse = new System.Windows.Forms.Label();
            this.LblClass = new System.Windows.Forms.Label();
            this.LblAge = new System.Windows.Forms.Label();
            this.LblLastName = new System.Windows.Forms.Label();
            this.LblFirstName = new System.Windows.Forms.Label();
            this.LblId = new System.Windows.Forms.Label();
            this.BtnClear = new FontAwesome.Sharp.IconButton();
            this.BtnDelete = new FontAwesome.Sharp.IconButton();
            this.BtnUpdate = new FontAwesome.Sharp.IconButton();
            this.BtnCreate = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.DgvStudents)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvStudents
            // 
            this.DgvStudents.BackgroundColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.DgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvStudents.DefaultCellStyle = dataGridViewCellStyle14;
            this.DgvStudents.GridColor = System.Drawing.Color.MediumBlue;
            this.DgvStudents.Location = new System.Drawing.Point(0, 72);
            this.DgvStudents.Name = "DgvStudents";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvStudents.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.DgvStudents.RowHeadersWidth = 62;
            this.DgvStudents.Size = new System.Drawing.Size(512, 277);
            this.DgvStudents.TabIndex = 1;
            this.DgvStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvStudents_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(254, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "STUDENTS MANAGEMENT";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaShell;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(945, 73);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel2.Controls.Add(this.TxtCourse);
            this.panel2.Controls.Add(this.TxtClass);
            this.panel2.Controls.Add(this.TxtAge);
            this.panel2.Controls.Add(this.TxtLastName);
            this.panel2.Controls.Add(this.TxtFirstName);
            this.panel2.Controls.Add(this.TxtId);
            this.panel2.Controls.Add(this.LblCourse);
            this.panel2.Controls.Add(this.LblClass);
            this.panel2.Controls.Add(this.LblAge);
            this.panel2.Controls.Add(this.LblLastName);
            this.panel2.Controls.Add(this.LblFirstName);
            this.panel2.Controls.Add(this.LblId);
            this.panel2.Controls.Add(this.BtnClear);
            this.panel2.Controls.Add(this.BtnDelete);
            this.panel2.Controls.Add(this.BtnUpdate);
            this.panel2.Controls.Add(this.BtnCreate);
            this.panel2.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.Color.Blue;
            this.panel2.Location = new System.Drawing.Point(518, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(427, 277);
            this.panel2.TabIndex = 4;
            // 
            // TxtCourse
            // 
            this.TxtCourse.ForeColor = System.Drawing.Color.Blue;
            this.TxtCourse.Location = new System.Drawing.Point(125, 172);
            this.TxtCourse.Name = "TxtCourse";
            this.TxtCourse.Size = new System.Drawing.Size(274, 25);
            this.TxtCourse.TabIndex = 2;
            // 
            // TxtClass
            // 
            this.TxtClass.ForeColor = System.Drawing.Color.Blue;
            this.TxtClass.Location = new System.Drawing.Point(125, 141);
            this.TxtClass.Name = "TxtClass";
            this.TxtClass.Size = new System.Drawing.Size(274, 25);
            this.TxtClass.TabIndex = 2;
            // 
            // TxtAge
            // 
            this.TxtAge.ForeColor = System.Drawing.Color.Blue;
            this.TxtAge.Location = new System.Drawing.Point(125, 110);
            this.TxtAge.Name = "TxtAge";
            this.TxtAge.Size = new System.Drawing.Size(274, 25);
            this.TxtAge.TabIndex = 2;
            // 
            // TxtLastName
            // 
            this.TxtLastName.ForeColor = System.Drawing.Color.Blue;
            this.TxtLastName.Location = new System.Drawing.Point(125, 79);
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.Size = new System.Drawing.Size(274, 25);
            this.TxtLastName.TabIndex = 2;
            // 
            // TxtFirstName
            // 
            this.TxtFirstName.ForeColor = System.Drawing.Color.Blue;
            this.TxtFirstName.Location = new System.Drawing.Point(125, 48);
            this.TxtFirstName.MaxLength = 50;
            this.TxtFirstName.Name = "TxtFirstName";
            this.TxtFirstName.Size = new System.Drawing.Size(274, 25);
            this.TxtFirstName.TabIndex = 2;
            // 
            // TxtId
            // 
            this.TxtId.Enabled = false;
            this.TxtId.ForeColor = System.Drawing.Color.Blue;
            this.TxtId.Location = new System.Drawing.Point(125, 17);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(274, 25);
            this.TxtId.TabIndex = 2;
            // 
            // LblCourse
            // 
            this.LblCourse.AutoSize = true;
            this.LblCourse.ForeColor = System.Drawing.Color.RoyalBlue;
            this.LblCourse.Location = new System.Drawing.Point(32, 178);
            this.LblCourse.Name = "LblCourse";
            this.LblCourse.Size = new System.Drawing.Size(54, 20);
            this.LblCourse.TabIndex = 1;
            this.LblCourse.Text = "Course";
            // 
            // LblClass
            // 
            this.LblClass.AutoSize = true;
            this.LblClass.ForeColor = System.Drawing.Color.RoyalBlue;
            this.LblClass.Location = new System.Drawing.Point(32, 144);
            this.LblClass.Name = "LblClass";
            this.LblClass.Size = new System.Drawing.Size(44, 20);
            this.LblClass.TabIndex = 1;
            this.LblClass.Text = "Class";
            // 
            // LblAge
            // 
            this.LblAge.AutoSize = true;
            this.LblAge.ForeColor = System.Drawing.Color.RoyalBlue;
            this.LblAge.Location = new System.Drawing.Point(32, 111);
            this.LblAge.Name = "LblAge";
            this.LblAge.Size = new System.Drawing.Size(34, 20);
            this.LblAge.TabIndex = 1;
            this.LblAge.Text = "Age";
            // 
            // LblLastName
            // 
            this.LblLastName.AutoSize = true;
            this.LblLastName.ForeColor = System.Drawing.Color.RoyalBlue;
            this.LblLastName.Location = new System.Drawing.Point(32, 81);
            this.LblLastName.Name = "LblLastName";
            this.LblLastName.Size = new System.Drawing.Size(73, 20);
            this.LblLastName.TabIndex = 1;
            this.LblLastName.Text = "LastName";
            // 
            // LblFirstName
            // 
            this.LblFirstName.AutoSize = true;
            this.LblFirstName.ForeColor = System.Drawing.Color.RoyalBlue;
            this.LblFirstName.Location = new System.Drawing.Point(32, 49);
            this.LblFirstName.Name = "LblFirstName";
            this.LblFirstName.Size = new System.Drawing.Size(75, 20);
            this.LblFirstName.TabIndex = 1;
            this.LblFirstName.Text = "FirstName";
            // 
            // LblId
            // 
            this.LblId.AutoSize = true;
            this.LblId.ForeColor = System.Drawing.Color.RoyalBlue;
            this.LblId.Location = new System.Drawing.Point(32, 18);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(21, 20);
            this.LblId.TabIndex = 1;
            this.LblId.Text = "Id";
            // 
            // BtnClear
            // 
            this.BtnClear.BackColor = System.Drawing.Color.DarkTurquoise;
            this.BtnClear.FlatAppearance.BorderSize = 0;
            this.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClear.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.ForeColor = System.Drawing.Color.Yellow;
            this.BtnClear.IconChar = FontAwesome.Sharp.IconChar.RotateBackward;
            this.BtnClear.IconColor = System.Drawing.Color.Orange;
            this.BtnClear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnClear.IconSize = 22;
            this.BtnClear.Location = new System.Drawing.Point(319, 224);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(80, 29);
            this.BtnClear.TabIndex = 0;
            this.BtnClear.Text = "Clear";
            this.BtnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnDelete.FlatAppearance.BorderSize = 0;
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.ForeColor = System.Drawing.Color.Lavender;
            this.BtnDelete.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.BtnDelete.IconColor = System.Drawing.Color.Red;
            this.BtnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnDelete.IconSize = 22;
            this.BtnDelete.Location = new System.Drawing.Point(214, 224);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(84, 29);
            this.BtnDelete.TabIndex = 0;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnDelete.UseVisualStyleBackColor = false;
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnUpdate.FlatAppearance.BorderSize = 0;
            this.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdate.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.ForeColor = System.Drawing.Color.Lavender;
            this.BtnUpdate.IconChar = FontAwesome.Sharp.IconChar.PenClip;
            this.BtnUpdate.IconColor = System.Drawing.Color.Yellow;
            this.BtnUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnUpdate.IconSize = 22;
            this.BtnUpdate.Location = new System.Drawing.Point(111, 224);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(97, 29);
            this.BtnUpdate.TabIndex = 0;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnUpdate.UseVisualStyleBackColor = false;
            // 
            // BtnCreate
            // 
            this.BtnCreate.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnCreate.FlatAppearance.BorderSize = 0;
            this.BtnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCreate.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCreate.ForeColor = System.Drawing.Color.Lavender;
            this.BtnCreate.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.BtnCreate.IconColor = System.Drawing.Color.Chartreuse;
            this.BtnCreate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCreate.IconSize = 22;
            this.BtnCreate.Location = new System.Drawing.Point(21, 224);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(84, 29);
            this.BtnCreate.TabIndex = 0;
            this.BtnCreate.Text = "Create";
            this.BtnCreate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCreate.UseVisualStyleBackColor = false;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // FrmStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 350);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DgvStudents);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FrmStudents";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvStudents)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvStudents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LblId;
        private FontAwesome.Sharp.IconButton BtnCreate;
        private System.Windows.Forms.Label LblClass;
        private System.Windows.Forms.Label LblAge;
        private System.Windows.Forms.Label LblLastName;
        private System.Windows.Forms.Label LblFirstName;
        private System.Windows.Forms.Label LblCourse;
        private System.Windows.Forms.TextBox TxtCourse;
        private System.Windows.Forms.TextBox TxtClass;
        private System.Windows.Forms.TextBox TxtAge;
        private System.Windows.Forms.TextBox TxtLastName;
        private System.Windows.Forms.TextBox TxtFirstName;
        private System.Windows.Forms.TextBox TxtId;
        private FontAwesome.Sharp.IconButton BtnClear;
        private FontAwesome.Sharp.IconButton BtnDelete;
        private FontAwesome.Sharp.IconButton BtnUpdate;
    }
}

