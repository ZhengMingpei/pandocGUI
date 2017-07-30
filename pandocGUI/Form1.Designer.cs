namespace pandocGUI
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox_tex = new System.Windows.Forms.CheckBox();
            this.checkBox_pandoc = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_filepath = new System.Windows.Forms.TextBox();
            this.button_end = new System.Windows.Forms.Button();
            this.button_start = new System.Windows.Forms.Button();
            this.button_checkEvn = new System.Windows.Forms.Button();
            this.button_openfile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.checkedListBox_format = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.checkedListBox_format);
            this.splitContainer1.Panel1.Controls.Add(this.textBox_result);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.checkBox_tex);
            this.splitContainer1.Panel1.Controls.Add(this.checkBox_pandoc);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.textBox_filepath);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.button_end);
            this.splitContainer1.Panel2.Controls.Add(this.button_start);
            this.splitContainer1.Panel2.Controls.Add(this.button_checkEvn);
            this.splitContainer1.Panel2.Controls.Add(this.button_openfile);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(504, 419);
            this.splitContainer1.SplitterDistance = 381;
            this.splitContainer1.TabIndex = 0;
            // 
            // textBox_result
            // 
            this.textBox_result.Location = new System.Drawing.Point(14, 247);
            this.textBox_result.Multiline = true;
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.ReadOnly = true;
            this.textBox_result.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_result.Size = new System.Drawing.Size(351, 146);
            this.textBox_result.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "运行状态显示";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "源文件路径";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "输出文件格式选择";
            // 
            // checkBox_tex
            // 
            this.checkBox_tex.AutoSize = true;
            this.checkBox_tex.Enabled = false;
            this.checkBox_tex.Location = new System.Drawing.Point(164, 52);
            this.checkBox_tex.Name = "checkBox_tex";
            this.checkBox_tex.Size = new System.Drawing.Size(156, 16);
            this.checkBox_tex.TabIndex = 3;
            this.checkBox_tex.Text = "MiKTeX/latex--暂不支持";
            this.checkBox_tex.UseVisualStyleBackColor = true;
            // 
            // checkBox_pandoc
            // 
            this.checkBox_pandoc.AutoSize = true;
            this.checkBox_pandoc.Enabled = false;
            this.checkBox_pandoc.Location = new System.Drawing.Point(14, 52);
            this.checkBox_pandoc.Name = "checkBox_pandoc";
            this.checkBox_pandoc.Size = new System.Drawing.Size(144, 16);
            this.checkBox_pandoc.TabIndex = 2;
            this.checkBox_pandoc.Text = "pandoc--运行必需环境";
            this.checkBox_pandoc.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "所需软件环境检查结果";
            // 
            // textBox_filepath
            // 
            this.textBox_filepath.AllowDrop = true;
            this.textBox_filepath.Enabled = false;
            this.textBox_filepath.Location = new System.Drawing.Point(14, 104);
            this.textBox_filepath.Multiline = true;
            this.textBox_filepath.Name = "textBox_filepath";
            this.textBox_filepath.ReadOnly = true;
            this.textBox_filepath.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_filepath.Size = new System.Drawing.Size(351, 33);
            this.textBox_filepath.TabIndex = 0;
            this.textBox_filepath.Text = "此处将会显示所选源文件的路径";
            // 
            // button_end
            // 
            this.button_end.Enabled = false;
            this.button_end.Location = new System.Drawing.Point(21, 299);
            this.button_end.Name = "button_end";
            this.button_end.Size = new System.Drawing.Size(75, 23);
            this.button_end.TabIndex = 4;
            this.button_end.Text = "终止转换";
            this.button_end.UseVisualStyleBackColor = true;
            // 
            // button_start
            // 
            this.button_start.Enabled = false;
            this.button_start.Location = new System.Drawing.Point(21, 270);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(75, 23);
            this.button_start.TabIndex = 3;
            this.button_start.Text = "开始转换";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // button_checkEvn
            // 
            this.button_checkEvn.Enabled = false;
            this.button_checkEvn.Location = new System.Drawing.Point(21, 48);
            this.button_checkEvn.Name = "button_checkEvn";
            this.button_checkEvn.Size = new System.Drawing.Size(75, 23);
            this.button_checkEvn.TabIndex = 1;
            this.button_checkEvn.Text = "检测配置";
            this.button_checkEvn.UseVisualStyleBackColor = true;
            this.button_checkEvn.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_openfile
            // 
            this.button_openfile.Enabled = false;
            this.button_openfile.Location = new System.Drawing.Point(21, 114);
            this.button_openfile.Name = "button_openfile";
            this.button_openfile.Size = new System.Drawing.Size(75, 23);
            this.button_openfile.TabIndex = 0;
            this.button_openfile.Text = "选择文件";
            this.button_openfile.UseVisualStyleBackColor = true;
            this.button_openfile.Click += new System.EventHandler(this.button_openfile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "操作";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // checkedListBox_format
            // 
            this.checkedListBox_format.Enabled = false;
            this.checkedListBox_format.FormattingEnabled = true;
            this.checkedListBox_format.IntegralHeight = false;
            this.checkedListBox_format.Items.AddRange(new object[] {
            ".md",
            ".txt",
            ".epub",
            ".doc",
            ".docx",
            ".html"});
            this.checkedListBox_format.Location = new System.Drawing.Point(14, 166);
            this.checkedListBox_format.MultiColumn = true;
            this.checkedListBox_format.Name = "checkedListBox_format";
            this.checkedListBox_format.Size = new System.Drawing.Size(351, 54);
            this.checkedListBox_format.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 419);
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(520, 380);
            this.Name = "Form1";
            this.Text = "pandocGUI-文本格式转换器";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button_openfile;
        private System.Windows.Forms.TextBox textBox_filepath;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_checkEvn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox_tex;
        private System.Windows.Forms.CheckBox checkBox_pandoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Button button_end;
        private System.Windows.Forms.TextBox textBox_result;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckedListBox checkedListBox_format;
    }
}

