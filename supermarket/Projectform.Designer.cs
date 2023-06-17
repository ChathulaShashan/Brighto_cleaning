namespace supermarket
{
    partial class Projectform
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
            this.addbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.prosearch = new System.Windows.Forms.TextBox();
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.editbtn = new System.Windows.Forms.Button();
            this.txtProowner = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStartdate = new System.Windows.Forms.TextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ProjectGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // addbtn
            // 
            this.addbtn.AutoSize = true;
            this.addbtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.addbtn.FlatAppearance.BorderSize = 0;
            this.addbtn.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.ForeColor = System.Drawing.Color.Black;
            this.addbtn.Location = new System.Drawing.Point(42, 587);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(86, 34);
            this.addbtn.TabIndex = 177;
            this.addbtn.Text = "ADD";
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(577, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 37);
            this.label1.TabIndex = 175;
            this.label1.Text = "PROJECT MANAGEMENT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
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
            this.button2.TabIndex = 174;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // prosearch
            // 
            this.prosearch.Location = new System.Drawing.Point(447, 111);
            this.prosearch.Name = "prosearch";
            this.prosearch.Size = new System.Drawing.Size(556, 22);
            this.prosearch.TabIndex = 173;
            this.prosearch.TextChanged += new System.EventHandler(this.prosearch_TextChanged);
            // 
            // txtEmpID
            // 
            this.txtEmpID.Location = new System.Drawing.Point(117, 190);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(179, 22);
            this.txtEmpID.TabIndex = 172;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Aqua;
            this.label8.Location = new System.Drawing.Point(12, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 20);
            this.label8.TabIndex = 171;
            this.label8.Text = "Pro Id";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(134, 635);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 34);
            this.button1.TabIndex = 170;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Aqua;
            this.label6.Location = new System.Drawing.Point(12, 401);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 169;
            this.label6.Text = "Start date";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.Location = new System.Drawing.Point(1009, 109);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(116, 24);
            this.btnRefresh.TabIndex = 168;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // editbtn
            // 
            this.editbtn.AutoSize = true;
            this.editbtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.editbtn.FlatAppearance.BorderSize = 0;
            this.editbtn.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editbtn.ForeColor = System.Drawing.Color.Black;
            this.editbtn.Location = new System.Drawing.Point(134, 587);
            this.editbtn.Name = "editbtn";
            this.editbtn.Size = new System.Drawing.Size(86, 34);
            this.editbtn.TabIndex = 166;
            this.editbtn.Text = "EDIT";
            this.editbtn.UseVisualStyleBackColor = false;
            this.editbtn.Click += new System.EventHandler(this.editbtn_Click);
            // 
            // txtProowner
            // 
            this.txtProowner.Location = new System.Drawing.Point(117, 241);
            this.txtProowner.Name = "txtProowner";
            this.txtProowner.Size = new System.Drawing.Size(179, 22);
            this.txtProowner.TabIndex = 165;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Aqua;
            this.label5.Location = new System.Drawing.Point(12, 352);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 164;
            this.label5.Text = "Cost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Aqua;
            this.label4.Location = new System.Drawing.Point(12, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 163;
            this.label4.Text = "Location";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Aqua;
            this.label3.Location = new System.Drawing.Point(12, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 162;
            this.label3.Text = "Pro Owner";
            // 
            // txtStartdate
            // 
            this.txtStartdate.Location = new System.Drawing.Point(117, 401);
            this.txtStartdate.Name = "txtStartdate";
            this.txtStartdate.Size = new System.Drawing.Size(179, 22);
            this.txtStartdate.TabIndex = 161;
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(117, 350);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(179, 22);
            this.txtCost.TabIndex = 160;
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(117, 293);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(179, 22);
            this.txtLocation.TabIndex = 159;
            // 
            // deleteBtn
            // 
            this.deleteBtn.AutoSize = true;
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(226, 587);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(90, 34);
            this.deleteBtn.TabIndex = 178;
            this.deleteBtn.Text = "DELETE";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // ClearBtn
            // 
            this.ClearBtn.BackColor = System.Drawing.SystemColors.Info;
            this.ClearBtn.Location = new System.Drawing.Point(165, 451);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(75, 23);
            this.ClearBtn.TabIndex = 179;
            this.ClearBtn.Text = "Clear details";
            this.ClearBtn.UseVisualStyleBackColor = false;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(369, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 180;
            this.label2.Text = "Search";
            // 
            // ProjectGrid
            // 
            this.ProjectGrid.AllowUserToAddRows = false;
            this.ProjectGrid.AllowUserToDeleteRows = false;
            this.ProjectGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProjectGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProjectGrid.Location = new System.Drawing.Point(367, 138);
            this.ProjectGrid.MaximumSize = new System.Drawing.Size(1098, 594);
            this.ProjectGrid.MinimumSize = new System.Drawing.Size(1098, 594);
            this.ProjectGrid.Name = "ProjectGrid";
            this.ProjectGrid.ReadOnly = true;
            this.ProjectGrid.RowHeadersWidth = 51;
            this.ProjectGrid.RowTemplate.Height = 24;
            this.ProjectGrid.Size = new System.Drawing.Size(1098, 594);
            this.ProjectGrid.TabIndex = 181;
            this.ProjectGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProjectGrid_CellContentClick_1);
            this.ProjectGrid.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProjectGrid_CellEnter_1);
            // 
            // Projectform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1477, 744);
            this.Controls.Add(this.ProjectGrid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.prosearch);
            this.Controls.Add(this.txtEmpID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.editbtn);
            this.Controls.Add(this.txtProowner);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtStartdate);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.txtLocation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Projectform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "testproject";
            this.Load += new System.EventHandler(this.testproject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProjectGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox prosearch;
        private System.Windows.Forms.TextBox txtEmpID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button editbtn;
        private System.Windows.Forms.TextBox txtProowner;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStartdate;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Button deleteBtn;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView ProjectGrid;
    }
}