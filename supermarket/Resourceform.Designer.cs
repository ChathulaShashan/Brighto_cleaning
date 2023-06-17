namespace supermarket
{
    partial class Resourceform
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.ResourcesGrid = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.labledescription = new System.Windows.Forms.Label();
            this.txtProID = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.txtRID = new System.Windows.Forms.TextBox();
            this.na = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmpId = new System.Windows.Forms.TextBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.searchResources = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.CategoryCb = new System.Windows.Forms.ComboBox();
            this.txtquantity = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ResourcesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(134, 587);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(86, 34);
            this.btnUpdate.TabIndex = 166;
            this.btnUpdate.Text = "EDIT";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // ResourcesGrid
            // 
            this.ResourcesGrid.AllowUserToAddRows = false;
            this.ResourcesGrid.AllowUserToDeleteRows = false;
            this.ResourcesGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ResourcesGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ResourcesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResourcesGrid.Location = new System.Drawing.Point(367, 138);
            this.ResourcesGrid.Name = "ResourcesGrid";
            this.ResourcesGrid.ReadOnly = true;
            this.ResourcesGrid.RowHeadersWidth = 51;
            this.ResourcesGrid.RowTemplate.Height = 24;
            this.ResourcesGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ResourcesGrid.Size = new System.Drawing.Size(1098, 594);
            this.ResourcesGrid.TabIndex = 175;
            this.ResourcesGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ResourcesGrid_CellContentClick);
            this.ResourcesGrid.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.ResourcesGrid_CellEnter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gold;
            this.label4.Location = new System.Drawing.Point(577, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(363, 37);
            this.label4.TabIndex = 174;
            this.label4.Text = "RESOURSES AVAILIBILITY";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Aqua;
            this.label2.Location = new System.Drawing.Point(7, 386);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 173;
            this.label2.Text = "Quantity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(7, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 172;
            this.label1.Text = "Category";
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(42, 587);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(86, 34);
            this.addBtn.TabIndex = 177;
            this.addBtn.Text = "ADD";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
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
            this.button2.TabIndex = 170;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labledescription
            // 
            this.labledescription.AutoSize = true;
            this.labledescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labledescription.ForeColor = System.Drawing.Color.Aqua;
            this.labledescription.Location = new System.Drawing.Point(7, 266);
            this.labledescription.Name = "labledescription";
            this.labledescription.Size = new System.Drawing.Size(57, 20);
            this.labledescription.TabIndex = 169;
            this.labledescription.Text = "Pro ID";
            // 
            // txtProID
            // 
            this.txtProID.Location = new System.Drawing.Point(124, 266);
            this.txtProID.Name = "txtProID";
            this.txtProID.Size = new System.Drawing.Size(185, 22);
            this.txtProID.TabIndex = 168;
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(864, 17);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(51, 39);
            this.button5.TabIndex = 163;
            this.button5.Text = "X";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // txtRID
            // 
            this.txtRID.Location = new System.Drawing.Point(124, 144);
            this.txtRID.Name = "txtRID";
            this.txtRID.Size = new System.Drawing.Size(185, 22);
            this.txtRID.TabIndex = 167;
            // 
            // na
            // 
            this.na.AutoSize = true;
            this.na.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.na.ForeColor = System.Drawing.Color.Aqua;
            this.na.Location = new System.Drawing.Point(7, 203);
            this.na.Name = "na";
            this.na.Size = new System.Drawing.Size(61, 20);
            this.na.TabIndex = 166;
            this.na.Text = "Emp Id";
            this.na.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Aqua;
            this.label3.Location = new System.Drawing.Point(7, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 165;
            this.label3.Text = "RID";
            // 
            // txtEmpId
            // 
            this.txtEmpId.Location = new System.Drawing.Point(124, 206);
            this.txtEmpId.Name = "txtEmpId";
            this.txtEmpId.Size = new System.Drawing.Size(185, 22);
            this.txtEmpId.TabIndex = 164;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(226, 587);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(90, 34);
            this.deleteBtn.TabIndex = 178;
            this.deleteBtn.Text = "DELETE";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // searchResources
            // 
            this.searchResources.Location = new System.Drawing.Point(447, 110);
            this.searchResources.Name = "searchResources";
            this.searchResources.Size = new System.Drawing.Size(556, 22);
            this.searchResources.TabIndex = 180;
            this.searchResources.TextChanged += new System.EventHandler(this.searchResources_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(134, 638);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 34);
            this.button1.TabIndex = 181;
            this.button1.Text = "HOME";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.BackColor = System.Drawing.SystemColors.Info;
            this.ClearBtn.Location = new System.Drawing.Point(174, 445);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(75, 23);
            this.ClearBtn.TabIndex = 182;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = false;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
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
            this.btnRefresh.TabIndex = 183;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(369, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 184;
            this.label5.Text = "Search";
            // 
            // CategoryCb
            // 
            this.CategoryCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryCb.FormattingEnabled = true;
            this.CategoryCb.Items.AddRange(new object[] {
            "Post-construction cleaning",
            "Commercial cleaning",
            "Residential cleaning. "});
            this.CategoryCb.Location = new System.Drawing.Point(124, 326);
            this.CategoryCb.Name = "CategoryCb";
            this.CategoryCb.Size = new System.Drawing.Size(179, 26);
            this.CategoryCb.TabIndex = 185;
            this.CategoryCb.Text = "select";
            // 
            // txtquantity
            // 
            this.txtquantity.Location = new System.Drawing.Point(124, 386);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(179, 22);
            this.txtquantity.TabIndex = 186;
            // 
            // Resourceform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1477, 744);
            this.Controls.Add(this.txtquantity);
            this.Controls.Add(this.CategoryCb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.searchResources);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.ResourcesGrid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.labledescription);
            this.Controls.Add(this.txtProID);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.txtRID);
            this.Controls.Add(this.na);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmpId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1477, 744);
            this.MinimumSize = new System.Drawing.Size(1477, 744);
            this.Name = "Resourceform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "testResourceform";
            this.Load += new System.EventHandler(this.testResourceform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ResourcesGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView ResourcesGrid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labledescription;
        private System.Windows.Forms.TextBox txtProID;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox txtRID;
        private System.Windows.Forms.Label na;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmpId;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.TextBox searchResources;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CategoryCb;
        private System.Windows.Forms.TextBox txtquantity;
    }
}