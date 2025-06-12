namespace EmployeeManagementSystem
{
    partial class AddEmployee
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.addEmployee_status = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.addEmployee_clearBtn = new System.Windows.Forms.Button();
            this.addEmployee_deleteBtn = new System.Windows.Forms.Button();
            this.addEmployee_updateBtn = new System.Windows.Forms.Button();
            this.addEmployee_addBtn = new System.Windows.Forms.Button();
            this.addEmployee_Import = new System.Windows.Forms.Button();
            this.addEmployee_picture = new System.Windows.Forms.PictureBox();
            this.addEmployee_position = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.addEmployee_phoneNum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addEmployee_gender = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addEmployee_fullName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addEmployee_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addEmployee_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(17, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(875, 350);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(19, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(834, 263);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee\'s Data";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.addEmployee_status);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.addEmployee_clearBtn);
            this.panel2.Controls.Add(this.addEmployee_deleteBtn);
            this.panel2.Controls.Add(this.addEmployee_updateBtn);
            this.panel2.Controls.Add(this.addEmployee_addBtn);
            this.panel2.Controls.Add(this.addEmployee_Import);
            this.panel2.Controls.Add(this.addEmployee_picture);
            this.panel2.Controls.Add(this.addEmployee_position);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.addEmployee_phoneNum);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.addEmployee_gender);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.addEmployee_fullName);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.addEmployee_id);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(17, 383);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(875, 243);
            this.panel2.TabIndex = 1;
            // 
            // addEmployee_status
            // 
            this.addEmployee_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployee_status.FormattingEnabled = true;
            this.addEmployee_status.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.addEmployee_status.Location = new System.Drawing.Point(520, 117);
            this.addEmployee_status.Name = "addEmployee_status";
            this.addEmployee_status.Size = new System.Drawing.Size(191, 30);
            this.addEmployee_status.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(452, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 22);
            this.label7.TabIndex = 16;
            this.label7.Text = "Status:";
            // 
            // addEmployee_clearBtn
            // 
            this.addEmployee_clearBtn.BackColor = System.Drawing.Color.Green;
            this.addEmployee_clearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addEmployee_clearBtn.FlatAppearance.BorderSize = 0;
            this.addEmployee_clearBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.addEmployee_clearBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.addEmployee_clearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.addEmployee_clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEmployee_clearBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployee_clearBtn.ForeColor = System.Drawing.Color.White;
            this.addEmployee_clearBtn.Location = new System.Drawing.Point(545, 179);
            this.addEmployee_clearBtn.Name = "addEmployee_clearBtn";
            this.addEmployee_clearBtn.Size = new System.Drawing.Size(166, 45);
            this.addEmployee_clearBtn.TabIndex = 15;
            this.addEmployee_clearBtn.Text = "Clear";
            this.addEmployee_clearBtn.UseVisualStyleBackColor = false;
            this.addEmployee_clearBtn.Click += new System.EventHandler(this.addEmployee_clearBtn_Click);
            // 
            // addEmployee_deleteBtn
            // 
            this.addEmployee_deleteBtn.BackColor = System.Drawing.Color.Green;
            this.addEmployee_deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addEmployee_deleteBtn.FlatAppearance.BorderSize = 0;
            this.addEmployee_deleteBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.addEmployee_deleteBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.addEmployee_deleteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.addEmployee_deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEmployee_deleteBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployee_deleteBtn.ForeColor = System.Drawing.Color.White;
            this.addEmployee_deleteBtn.Location = new System.Drawing.Point(373, 179);
            this.addEmployee_deleteBtn.Name = "addEmployee_deleteBtn";
            this.addEmployee_deleteBtn.Size = new System.Drawing.Size(166, 45);
            this.addEmployee_deleteBtn.TabIndex = 14;
            this.addEmployee_deleteBtn.Text = "Delete";
            this.addEmployee_deleteBtn.UseVisualStyleBackColor = false;
            this.addEmployee_deleteBtn.Click += new System.EventHandler(this.addEmployee_deleteBtn_Click);
            // 
            // addEmployee_updateBtn
            // 
            this.addEmployee_updateBtn.BackColor = System.Drawing.Color.Green;
            this.addEmployee_updateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addEmployee_updateBtn.FlatAppearance.BorderSize = 0;
            this.addEmployee_updateBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.addEmployee_updateBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.addEmployee_updateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.addEmployee_updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEmployee_updateBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployee_updateBtn.ForeColor = System.Drawing.Color.White;
            this.addEmployee_updateBtn.Location = new System.Drawing.Point(195, 179);
            this.addEmployee_updateBtn.Name = "addEmployee_updateBtn";
            this.addEmployee_updateBtn.Size = new System.Drawing.Size(166, 45);
            this.addEmployee_updateBtn.TabIndex = 13;
            this.addEmployee_updateBtn.Text = "Update";
            this.addEmployee_updateBtn.UseVisualStyleBackColor = false;
            this.addEmployee_updateBtn.Click += new System.EventHandler(this.addEmployee_updateBtn_Click);
            // 
            // addEmployee_addBtn
            // 
            this.addEmployee_addBtn.BackColor = System.Drawing.Color.Green;
            this.addEmployee_addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addEmployee_addBtn.FlatAppearance.BorderSize = 0;
            this.addEmployee_addBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.addEmployee_addBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.addEmployee_addBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.addEmployee_addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEmployee_addBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployee_addBtn.ForeColor = System.Drawing.Color.White;
            this.addEmployee_addBtn.Location = new System.Drawing.Point(23, 179);
            this.addEmployee_addBtn.Name = "addEmployee_addBtn";
            this.addEmployee_addBtn.Size = new System.Drawing.Size(166, 45);
            this.addEmployee_addBtn.TabIndex = 12;
            this.addEmployee_addBtn.Text = "Add";
            this.addEmployee_addBtn.UseVisualStyleBackColor = false;
            this.addEmployee_addBtn.Click += new System.EventHandler(this.addEmployee_addBtn_Click);
            // 
            // addEmployee_Import
            // 
            this.addEmployee_Import.BackColor = System.Drawing.Color.Green;
            this.addEmployee_Import.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addEmployee_Import.FlatAppearance.BorderSize = 0;
            this.addEmployee_Import.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.addEmployee_Import.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.addEmployee_Import.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEmployee_Import.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployee_Import.ForeColor = System.Drawing.Color.White;
            this.addEmployee_Import.Location = new System.Drawing.Point(741, 186);
            this.addEmployee_Import.Name = "addEmployee_Import";
            this.addEmployee_Import.Size = new System.Drawing.Size(129, 38);
            this.addEmployee_Import.TabIndex = 11;
            this.addEmployee_Import.Text = "Import";
            this.addEmployee_Import.UseVisualStyleBackColor = false;
            this.addEmployee_Import.Click += new System.EventHandler(this.addEmployee_Import_Click);
            // 
            // addEmployee_picture
            // 
            this.addEmployee_picture.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.addEmployee_picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addEmployee_picture.Location = new System.Drawing.Point(741, 27);
            this.addEmployee_picture.Name = "addEmployee_picture";
            this.addEmployee_picture.Size = new System.Drawing.Size(129, 152);
            this.addEmployee_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addEmployee_picture.TabIndex = 10;
            this.addEmployee_picture.TabStop = false;
            // 
            // addEmployee_position
            // 
            this.addEmployee_position.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployee_position.FormattingEnabled = true;
            this.addEmployee_position.Items.AddRange(new object[] {
            "Motion Graphar",
            "Thumbnail Editor",
            "Data Administrator",
            "Front-End Developer",
            "Back-End Developer",
            "Ul/UX Design"});
            this.addEmployee_position.Location = new System.Drawing.Point(520, 71);
            this.addEmployee_position.Name = "addEmployee_position";
            this.addEmployee_position.Size = new System.Drawing.Size(191, 30);
            this.addEmployee_position.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(439, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 22);
            this.label6.TabIndex = 8;
            this.label6.Text = "Position:";
            // 
            // addEmployee_phoneNum
            // 
            this.addEmployee_phoneNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployee_phoneNum.Location = new System.Drawing.Point(520, 23);
            this.addEmployee_phoneNum.Name = "addEmployee_phoneNum";
            this.addEmployee_phoneNum.Size = new System.Drawing.Size(191, 28);
            this.addEmployee_phoneNum.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(379, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "Phone Number:";
            // 
            // addEmployee_gender
            // 
            this.addEmployee_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployee_gender.FormattingEnabled = true;
            this.addEmployee_gender.Items.AddRange(new object[] {
            "Male",
            "female"});
            this.addEmployee_gender.Location = new System.Drawing.Point(137, 119);
            this.addEmployee_gender.Name = "addEmployee_gender";
            this.addEmployee_gender.Size = new System.Drawing.Size(224, 30);
            this.addEmployee_gender.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(65, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Gender:";
            // 
            // addEmployee_fullName
            // 
            this.addEmployee_fullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployee_fullName.Location = new System.Drawing.Point(137, 76);
            this.addEmployee_fullName.Name = "addEmployee_fullName";
            this.addEmployee_fullName.Size = new System.Drawing.Size(224, 28);
            this.addEmployee_fullName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Full Name:";
            // 
            // addEmployee_id
            // 
            this.addEmployee_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployee_id.Location = new System.Drawing.Point(137, 23);
            this.addEmployee_id.Name = "addEmployee_id";
            this.addEmployee_id.Size = new System.Drawing.Size(198, 28);
            this.addEmployee_id.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Employee ID:";
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AddEmployee";
            this.Size = new System.Drawing.Size(908, 647);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addEmployee_picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox addEmployee_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox addEmployee_fullName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addEmployee_phoneNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox addEmployee_gender;
        private System.Windows.Forms.PictureBox addEmployee_picture;
        private System.Windows.Forms.ComboBox addEmployee_position;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addEmployee_clearBtn;
        private System.Windows.Forms.Button addEmployee_deleteBtn;
        private System.Windows.Forms.Button addEmployee_updateBtn;
        private System.Windows.Forms.Button addEmployee_addBtn;
        private System.Windows.Forms.Button addEmployee_Import;
        private System.Windows.Forms.ComboBox addEmployee_status;
        private System.Windows.Forms.Label label7;
    }
}
