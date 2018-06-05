namespace XML_6增删改查
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.txtPsw = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.rdoWoman = new System.Windows.Forms.RadioButton();
            this.rdoMan = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtUpdataPsw = new System.Windows.Forms.TextBox();
            this.txtUpdataAge = new System.Windows.Forms.TextBox();
            this.txtUpdataName = new System.Windows.Forms.TextBox();
            this.txtUpdataID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnUpData = new System.Windows.Forms.Button();
            this.rdoUpdataWoman = new System.Windows.Forms.RadioButton();
            this.rdoUpdataMan = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(47, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(653, 217);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 26);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(100, 22);
            this.toolStripMenuItem2.Text = "删除";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSignIn);
            this.groupBox1.Controls.Add(this.txtPsw);
            this.groupBox1.Controls.Add(this.txtAge);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.rdoWoman);
            this.groupBox1.Controls.Add(this.rdoMan);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(47, 261);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(653, 112);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "新增";
            // 
            // btnSignIn
            // 
            this.btnSignIn.Location = new System.Drawing.Point(379, 95);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(75, 23);
            this.btnSignIn.TabIndex = 13;
            this.btnSignIn.Text = "注册";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // txtPsw
            // 
            this.txtPsw.Location = new System.Drawing.Point(523, 41);
            this.txtPsw.Name = "txtPsw";
            this.txtPsw.Size = new System.Drawing.Size(86, 21);
            this.txtPsw.TabIndex = 12;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(360, 41);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(86, 21);
            this.txtAge.TabIndex = 11;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(206, 38);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(86, 21);
            this.txtName.TabIndex = 10;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(51, 38);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(86, 21);
            this.txtID.TabIndex = 9;
            // 
            // rdoWoman
            // 
            this.rdoWoman.AutoSize = true;
            this.rdoWoman.Location = new System.Drawing.Point(143, 84);
            this.rdoWoman.Name = "rdoWoman";
            this.rdoWoman.Size = new System.Drawing.Size(35, 16);
            this.rdoWoman.TabIndex = 8;
            this.rdoWoman.Text = "女";
            this.rdoWoman.UseVisualStyleBackColor = true;
            // 
            // rdoMan
            // 
            this.rdoMan.AutoSize = true;
            this.rdoMan.Checked = true;
            this.rdoMan.Location = new System.Drawing.Point(102, 84);
            this.rdoMan.Name = "rdoMan";
            this.rdoMan.Size = new System.Drawing.Size(35, 16);
            this.rdoMan.TabIndex = 7;
            this.rdoMan.TabStop = true;
            this.rdoMan.Text = "男";
            this.rdoMan.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(488, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "密码";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "性别";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(325, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "年龄";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "姓名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtUpdataPsw);
            this.groupBox2.Controls.Add(this.txtUpdataAge);
            this.groupBox2.Controls.Add(this.txtUpdataName);
            this.groupBox2.Controls.Add(this.txtUpdataID);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.btnUpData);
            this.groupBox2.Controls.Add(this.rdoUpdataWoman);
            this.groupBox2.Controls.Add(this.rdoUpdataMan);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(47, 379);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(653, 92);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "修改";
            // 
            // txtUpdataPsw
            // 
            this.txtUpdataPsw.Location = new System.Drawing.Point(523, 36);
            this.txtUpdataPsw.Name = "txtUpdataPsw";
            this.txtUpdataPsw.Size = new System.Drawing.Size(86, 21);
            this.txtUpdataPsw.TabIndex = 33;
            // 
            // txtUpdataAge
            // 
            this.txtUpdataAge.Location = new System.Drawing.Point(360, 36);
            this.txtUpdataAge.Name = "txtUpdataAge";
            this.txtUpdataAge.Size = new System.Drawing.Size(86, 21);
            this.txtUpdataAge.TabIndex = 32;
            // 
            // txtUpdataName
            // 
            this.txtUpdataName.Location = new System.Drawing.Point(206, 33);
            this.txtUpdataName.Name = "txtUpdataName";
            this.txtUpdataName.Size = new System.Drawing.Size(86, 21);
            this.txtUpdataName.TabIndex = 31;
            // 
            // txtUpdataID
            // 
            this.txtUpdataID.Location = new System.Drawing.Point(51, 33);
            this.txtUpdataID.Name = "txtUpdataID";
            this.txtUpdataID.Size = new System.Drawing.Size(86, 21);
            this.txtUpdataID.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(488, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 29;
            this.label6.Text = "密码";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(325, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 28;
            this.label8.Text = "年龄";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(171, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 27;
            this.label9.Text = "姓名";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 12);
            this.label11.TabIndex = 26;
            this.label11.Text = "ID";
            // 
            // btnUpData
            // 
            this.btnUpData.Location = new System.Drawing.Point(379, 70);
            this.btnUpData.Name = "btnUpData";
            this.btnUpData.Size = new System.Drawing.Size(75, 23);
            this.btnUpData.TabIndex = 25;
            this.btnUpData.Text = "确定";
            this.btnUpData.UseVisualStyleBackColor = true;
            this.btnUpData.Click += new System.EventHandler(this.btnUpData_Click);
            // 
            // rdoUpdataWoman
            // 
            this.rdoUpdataWoman.AutoSize = true;
            this.rdoUpdataWoman.Location = new System.Drawing.Point(174, 66);
            this.rdoUpdataWoman.Name = "rdoUpdataWoman";
            this.rdoUpdataWoman.Size = new System.Drawing.Size(35, 16);
            this.rdoUpdataWoman.TabIndex = 20;
            this.rdoUpdataWoman.Text = "女";
            this.rdoUpdataWoman.UseVisualStyleBackColor = true;
            // 
            // rdoUpdataMan
            // 
            this.rdoUpdataMan.AutoSize = true;
            this.rdoUpdataMan.Checked = true;
            this.rdoUpdataMan.Location = new System.Drawing.Point(133, 66);
            this.rdoUpdataMan.Name = "rdoUpdataMan";
            this.rdoUpdataMan.Size = new System.Drawing.Size(35, 16);
            this.rdoUpdataMan.TabIndex = 19;
            this.rdoUpdataMan.TabStop = true;
            this.rdoUpdataMan.Text = "男";
            this.rdoUpdataMan.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(80, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 17;
            this.label7.Text = "性别";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(-24, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 12);
            this.label10.TabIndex = 14;
            this.label10.Text = "ID";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID";
            this.Column1.HeaderText = "编号";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Name";
            this.Column2.HeaderText = "姓名";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Age";
            this.Column3.HeaderText = "年龄";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Gender";
            this.Column4.HeaderText = "性别";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Password";
            this.Column5.HeaderText = "密码";
            this.Column5.Name = "Column5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 493);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.TextBox txtPsw;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.RadioButton rdoWoman;
        private System.Windows.Forms.RadioButton rdoMan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnUpData;
        private System.Windows.Forms.RadioButton rdoUpdataWoman;
        private System.Windows.Forms.RadioButton rdoUpdataMan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtUpdataPsw;
        private System.Windows.Forms.TextBox txtUpdataAge;
        private System.Windows.Forms.TextBox txtUpdataName;
        private System.Windows.Forms.TextBox txtUpdataID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}

