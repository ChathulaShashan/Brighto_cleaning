namespace supermarket
{
    partial class Employeeform
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
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmpaddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtEmpname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtContactno = new System.Windows.Forms.TextBox();
            this.txtEmpemail = new System.Windows.Forms.TextBox();
            this.txtEmpage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmpid = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.searchEmployee = new System.Windows.Forms.TextBox();
            this.EmployeeGrid = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.editBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.EmpgenderCb = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(130, 684);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 34);
            this.button1.TabIndex = 45;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Aqua;
            this.label7.Location = new System.Drawing.Point(26, 370);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 20);
            this.label7.TabIndex = 43;
            this.label7.Text = "Gender";
            // 
            // txtEmpaddress
            // 
            this.txtEmpaddress.Location = new System.Drawing.Point(130, 513);
            this.txtEmpaddress.Name = "txtEmpaddress";
            this.txtEmpaddress.Size = new System.Drawing.Size(179, 22);
            this.txtEmpaddress.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Aqua;
            this.label6.Location = new System.Drawing.Point(26, 443);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 41;
            this.label6.Text = "Contact no";
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.Black;
            this.button8.Location = new System.Drawing.Point(1019, 108);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(116, 24);
            this.button8.TabIndex = 40;
            this.button8.Text = "REFRESH";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click_1);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.deleteBtn.FlatAppearance.BorderSize = 0;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.ForeColor = System.Drawing.Color.Black;
            this.deleteBtn.Location = new System.Drawing.Point(222, 635);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(90, 34);
            this.deleteBtn.TabIndex = 178;
            this.deleteBtn.Text = "DELETE";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(38, 635);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(86, 34);
            this.btnAdd.TabIndex = 177;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtEmpname
            // 
            this.txtEmpname.Location = new System.Drawing.Point(130, 170);
            this.txtEmpname.Name = "txtEmpname";
            this.txtEmpname.Size = new System.Drawing.Size(179, 22);
            this.txtEmpname.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Aqua;
            this.label5.Location = new System.Drawing.Point(26, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 35;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Aqua;
            this.label4.Location = new System.Drawing.Point(26, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 34;
            this.label4.Text = "Age";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Aqua;
            this.label3.Location = new System.Drawing.Point(26, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 33;
            this.label3.Text = "Name";
            // 
            // txtContactno
            // 
            this.txtContactno.Location = new System.Drawing.Point(130, 443);
            this.txtContactno.Name = "txtContactno";
            this.txtContactno.Size = new System.Drawing.Size(179, 22);
            this.txtContactno.TabIndex = 32;
            // 
            // txtEmpemail
            // 
            this.txtEmpemail.Location = new System.Drawing.Point(130, 303);
            this.txtEmpemail.Name = "txtEmpemail";
            this.txtEmpemail.Size = new System.Drawing.Size(179, 22);
            this.txtEmpemail.TabIndex = 31;
            this.txtEmpemail.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtEmpage
            // 
            this.txtEmpage.Location = new System.Drawing.Point(130, 236);
            this.txtEmpage.Name = "txtEmpage";
            this.txtEmpage.Size = new System.Drawing.Size(179, 22);
            this.txtEmpage.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Aqua;
            this.label2.Location = new System.Drawing.Point(26, 515);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Address";
            // 
            // txtEmpid
            // 
            this.txtEmpid.Location = new System.Drawing.Point(130, 110);
            this.txtEmpid.Name = "txtEmpid";
            this.txtEmpid.Size = new System.Drawing.Size(179, 22);
            this.txtEmpid.TabIndex = 47;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Aqua;
            this.label8.Location = new System.Drawing.Point(26, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 20);
            this.label8.TabIndex = 46;
            this.label8.Text = "Emp Id";
            // 
            // searchEmployee
            // 
            this.searchEmployee.Location = new System.Drawing.Point(447, 110);
            this.searchEmployee.Name = "searchEmployee";
            this.searchEmployee.Size = new System.Drawing.Size(566, 22);
            this.searchEmployee.TabIndex = 86;
            this.searchEmployee.Text = "search";
            this.searchEmployee.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // EmployeeGrid
            // 
            this.EmployeeGrid.AllowUserToAddRows = false;
            this.EmployeeGrid.AllowUserToDeleteRows = false;
            this.EmployeeGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EmployeeGrid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.EmployeeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeGrid.Location = new System.Drawing.Point(367, 138);
            this.EmployeeGrid.Name = "EmployeeGrid";
            this.EmployeeGrid.ReadOnly = true;
            this.EmployeeGrid.RowHeadersWidth = 51;
            this.EmployeeGrid.RowTemplate.Height = 24;
            this.EmployeeGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EmployeeGrid.Size = new System.Drawing.Size(1098, 594);
            this.EmployeeGrid.TabIndex = 87;
            this.EmployeeGrid.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmployeeGrid_CellEnter);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button2.Location = new System.Drawing.Point(1422, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(43, 37);
            this.button2.TabIndex = 91;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(577, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 35);
            this.label1.TabIndex = 92;
            this.label1.Text = "EMPLOYEE MANAGEMENT";
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // editBtn
            // 
            this.editBtn.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBtn.Location = new System.Drawing.Point(130, 635);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(86, 34);
            this.editBtn.TabIndex = 166;
            this.editBtn.Text = "EDIT";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.SystemColors.Info;
            this.clearBtn.Location = new System.Drawing.Point(179, 555);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 94;
            this.clearBtn.Text = "Clear details";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(369, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 20);
            this.label9.TabIndex = 181;
            this.label9.Text = "Search";
            // 
            // EmpgenderCb
            // 
            this.EmpgenderCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpgenderCb.FormattingEnabled = true;
            this.EmpgenderCb.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.EmpgenderCb.Location = new System.Drawing.Point(130, 364);
            this.EmpgenderCb.Name = "EmpgenderCb";
            this.EmpgenderCb.Size = new System.Drawing.Size(179, 26);
            this.EmpgenderCb.TabIndex = 44;
            // 
            // Employeeform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1477, 744);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.EmployeeGrid);
            this.Controls.Add(this.searchEmployee);
            this.Controls.Add(this.txtEmpid);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.EmpgenderCb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtEmpaddress);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtEmpname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtContactno);
            this.Controls.Add(this.txtEmpemail);
            this.Controls.Add(this.txtEmpage);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1477, 744);
            this.MinimumSize = new System.Drawing.Size(1477, 744);
            this.Name = "Employeeform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Form";
            this.Load += new System.EventHandler(this.Employeeform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEmpaddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtEmpname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtContactno;
        private System.Windows.Forms.TextBox txtEmpemail;
        private System.Windows.Forms.TextBox txtEmpage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmpid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox searchEmployee;
        private System.Windows.Forms.DataGridView EmployeeGrid;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox EmpgenderCb;
    }
}