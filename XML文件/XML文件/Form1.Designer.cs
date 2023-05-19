namespace XML文件
{
    partial class FrmReadXML
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvStu = new System.Windows.Forms.DataGridView();
            this.stuName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stuAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gander = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stuClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLoadXML = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStu)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStu
            // 
            this.dgvStu.AllowUserToAddRows = false;
            this.dgvStu.AllowUserToDeleteRows = false;
            this.dgvStu.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvStu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stuName,
            this.stuAge,
            this.Gander,
            this.stuClass});
            this.dgvStu.GridColor = System.Drawing.SystemColors.Control;
            this.dgvStu.Location = new System.Drawing.Point(55, 66);
            this.dgvStu.Name = "dgvStu";
            this.dgvStu.ReadOnly = true;
            this.dgvStu.RowHeadersWidth = 51;
            this.dgvStu.RowTemplate.Height = 27;
            this.dgvStu.Size = new System.Drawing.Size(650, 297);
            this.dgvStu.TabIndex = 0;
            // 
            // stuName
            // 
            this.stuName.DataPropertyName = "StuName";
            this.stuName.HeaderText = "姓名";
            this.stuName.MinimumWidth = 6;
            this.stuName.Name = "stuName";
            this.stuName.ReadOnly = true;
            this.stuName.Width = 125;
            // 
            // stuAge
            // 
            this.stuAge.DataPropertyName = "StuAge";
            this.stuAge.HeaderText = "年龄";
            this.stuAge.MinimumWidth = 6;
            this.stuAge.Name = "stuAge";
            this.stuAge.ReadOnly = true;
            this.stuAge.Width = 125;
            // 
            // Gander
            // 
            this.Gander.DataPropertyName = "Gander";
            this.Gander.HeaderText = "性别";
            this.Gander.MinimumWidth = 6;
            this.Gander.Name = "Gander";
            this.Gander.ReadOnly = true;
            this.Gander.Width = 125;
            // 
            // stuClass
            // 
            this.stuClass.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stuClass.DataPropertyName = "StuClass";
            this.stuClass.HeaderText = "班级";
            this.stuClass.MinimumWidth = 6;
            this.stuClass.Name = "stuClass";
            this.stuClass.ReadOnly = true;
            // 
            // btnLoadXML
            // 
            this.btnLoadXML.Location = new System.Drawing.Point(55, 401);
            this.btnLoadXML.Name = "btnLoadXML";
            this.btnLoadXML.Size = new System.Drawing.Size(193, 23);
            this.btnLoadXML.TabIndex = 1;
            this.btnLoadXML.Text = "显示版本信息";
            this.btnLoadXML.UseVisualStyleBackColor = true;
            this.btnLoadXML.Click += new System.EventHandler(this.btnLoadXML_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(512, 401);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(193, 23);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "加载XML文件";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // FrmReadXML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnLoadXML);
            this.Controls.Add(this.dgvStu);
            this.Name = "FrmReadXML";
            this.Text = "XML读取示例";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStu;
        private System.Windows.Forms.Button btnLoadXML;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuName;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gander;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuClass;
    }
}

