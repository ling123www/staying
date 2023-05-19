namespace 文件操作
{
    partial class FrmMain
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnWriteLine = new System.Windows.Forms.Button();
            this.btnReadAll = new System.Windows.Forms.Button();
            this.btnWriteAll = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnMove = new System.Windows.Forms.Button();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.txtFrm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnGetFile = new System.Windows.Forms.Button();
            this.btnDelfile = new System.Windows.Forms.Button();
            this.btnShowAllFile = new System.Windows.Forms.Button();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnWriteLine);
            this.groupBox1.Controls.Add(this.btnReadAll);
            this.groupBox1.Controls.Add(this.btnWriteAll);
            this.groupBox1.Location = new System.Drawing.Point(38, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(970, 148);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "文本文件读写";
            // 
            // btnWriteLine
            // 
            this.btnWriteLine.Location = new System.Drawing.Point(555, 62);
            this.btnWriteLine.Name = "btnWriteLine";
            this.btnWriteLine.Size = new System.Drawing.Size(153, 35);
            this.btnWriteLine.TabIndex = 0;
            this.btnWriteLine.Text = "模拟写入系统日志";
            this.btnWriteLine.UseVisualStyleBackColor = true;
            this.btnWriteLine.Click += new System.EventHandler(this.btnWriteLine_Click);
            // 
            // btnReadAll
            // 
            this.btnReadAll.Location = new System.Drawing.Point(295, 62);
            this.btnReadAll.Name = "btnReadAll";
            this.btnReadAll.Size = new System.Drawing.Size(153, 35);
            this.btnReadAll.TabIndex = 0;
            this.btnReadAll.Text = "从文本文件中读取";
            this.btnReadAll.UseVisualStyleBackColor = true;
            this.btnReadAll.Click += new System.EventHandler(this.btnReadAll_Click);
            // 
            // btnWriteAll
            // 
            this.btnWriteAll.Location = new System.Drawing.Point(29, 62);
            this.btnWriteAll.Name = "btnWriteAll";
            this.btnWriteAll.Size = new System.Drawing.Size(153, 35);
            this.btnWriteAll.TabIndex = 0;
            this.btnWriteAll.Text = "写入文本文件";
            this.btnWriteAll.UseVisualStyleBackColor = true;
            this.btnWriteAll.Click += new System.EventHandler(this.btnWriteAll_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnMove);
            this.groupBox2.Controls.Add(this.txtTo);
            this.groupBox2.Controls.Add(this.btnCopy);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnDel);
            this.groupBox2.Controls.Add(this.txtFrm);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(38, 237);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(970, 155);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "文件操作";
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(558, 114);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(153, 35);
            this.btnMove.TabIndex = 0;
            this.btnMove.Text = "移动文件";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(673, 62);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(243, 25);
            this.txtTo.TabIndex = 3;
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(295, 114);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(153, 35);
            this.btnCopy.TabIndex = 0;
            this.btnCopy.Text = "复制文件";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(555, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "目的文件路径：";
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(29, 114);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(153, 35);
            this.btnDel.TabIndex = 0;
            this.btnDel.Text = "删除文件";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // txtFrm
            // 
            this.txtFrm.Location = new System.Drawing.Point(144, 65);
            this.txtFrm.Name = "txtFrm";
            this.txtFrm.Size = new System.Drawing.Size(216, 25);
            this.txtFrm.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "源文件路径：";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCreate);
            this.groupBox3.Controls.Add(this.btnGetFile);
            this.groupBox3.Controls.Add(this.btnDelfile);
            this.groupBox3.Controls.Add(this.btnShowAllFile);
            this.groupBox3.Location = new System.Drawing.Point(38, 432);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(970, 155);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "文件目录操作";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(49, 102);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(257, 35);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "在指定目录下创建一个子目录";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnGetFile
            // 
            this.btnGetFile.Location = new System.Drawing.Point(49, 42);
            this.btnGetFile.Name = "btnGetFile";
            this.btnGetFile.Size = new System.Drawing.Size(257, 35);
            this.btnGetFile.TabIndex = 0;
            this.btnGetFile.Text = "显示指定目录下的所有文件";
            this.btnGetFile.UseVisualStyleBackColor = true;
            this.btnGetFile.Click += new System.EventHandler(this.btnGetFile_Click);
            // 
            // btnDelfile
            // 
            this.btnDelfile.Location = new System.Drawing.Point(422, 102);
            this.btnDelfile.Name = "btnDelfile";
            this.btnDelfile.Size = new System.Drawing.Size(286, 35);
            this.btnDelfile.TabIndex = 0;
            this.btnDelfile.Text = "删除指定目录下所有的子目录和文件";
            this.btnDelfile.UseVisualStyleBackColor = true;
            this.btnDelfile.Click += new System.EventHandler(this.btnDelfile_Click);
            // 
            // btnShowAllFile
            // 
            this.btnShowAllFile.Location = new System.Drawing.Point(422, 42);
            this.btnShowAllFile.Name = "btnShowAllFile";
            this.btnShowAllFile.Size = new System.Drawing.Size(286, 35);
            this.btnShowAllFile.TabIndex = 0;
            this.btnShowAllFile.Text = "显示指定目录下的所有子目录";
            this.btnShowAllFile.UseVisualStyleBackColor = true;
            this.btnShowAllFile.Click += new System.EventHandler(this.btnShowAllFile_Click);
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(1078, 99);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(205, 25);
            this.txtContent.TabIndex = 3;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 720);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmMain";
            this.Text = "文件操作";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnWriteLine;
        private System.Windows.Forms.Button btnReadAll;
        private System.Windows.Forms.Button btnWriteAll;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFrm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnGetFile;
        private System.Windows.Forms.Button btnDelfile;
        private System.Windows.Forms.Button btnShowAllFile;
        private System.Windows.Forms.TextBox txtContent;
    }
}

