using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace pandocGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); 
            configGUI();
        }
        //private Dictionary<int, string> support_Format;
        
        private void configGUI()
        { 
            //int enumSize=Enum.GetNames(typeof(checkboxEnum)).GetLength(0);
            if (check_pandoc())
            {
                //checkBox_pandoc.Enabled = false;
                checkBox_pandoc.Checked = true;
                button_openfile.Enabled = true;
                textBox_result.Text = "1. 软件环境检测结束...\r\n* Pandoc已经安装\r\n"
                + "* 转换器目前可以运行。"
                + "\r\n2. 请选择源文件...";
                textBox_result.BackColor = Color.LightBlue;          
            }
            else
            {
                textBox_result.Text = "1. 软件环境检测结束...\r\n* Pandoc没有安装\r\n"
                +"* 转换器无法运行，请确定至少有pandoc已经安装！";
                textBox_result.BackColor = Color.Red;  
            }
        }
        
        private bool check_pandoc()
        {
            string string_path = Environment.GetEnvironmentVariable("PATH", EnvironmentVariableTarget.User)
                + Environment.GetEnvironmentVariable("PATH", EnvironmentVariableTarget.Machine);
            return string_path.Contains("Pandoc"); 
        }
        private bool config_output_Format()
        {
            string[] support_Format = { ".md", ".txt", ".epub", ".docx", ".html" };
            string sourceFormat = Path.GetExtension(textBox_filepath.Text);
            textBox_result.Text += "\r\n* 当前源文件格式: " + sourceFormat;
            foreach (string item_format in support_Format)
            {
                if (item_format.Equals(sourceFormat))
                {
                    for (int i = 0; i < checkedListBox_format.Items.Count; i++)
                    {
                        string item = checkedListBox_format.Items[i].ToString();
                        if (item.Equals(sourceFormat))
                            checkedListBox_format.SetItemChecked(i, false);
                        else
                            checkedListBox_format.SetItemChecked(i, true);
                    }
                    return true;
                }
                else
                    continue;
            }
            return false;
            //textBox_result.Text = textBox_result.Text + checkedListBox_format.Items[0].ToString();
        }
        private void button_openfile_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            textBox_filepath.Text = openFileDialog1.FileName;
            if (config_output_Format())
            {
                string sourceFormat = Path.GetExtension(textBox_filepath.Text);
                textBox_result.Text +=
                "\r\n* 该格式受支持"
                + "\r\n3. 请取消不必要的勾选后点击开始转换..."
                + "\r\n* 已经默认勾选了所有支持的输出格式";
                checkedListBox_format.Enabled = true;
                textBox_result.BackColor = Color.LightBlue;
                button_start.Enabled = true;
            }
            else
            {
                textBox_result.Text +=
                    "\r\n* 不支持doc，jpg等格式的源文件，请另存为支持的格式，比如："
                    + ".md, .txt, .epub, .docx, .html";
                textBox_result.BackColor = Color.Red;
                button_start.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_start_Click(object sender, EventArgs e)
        {
            string string_pandoc_cmd = "pandoc";
            string sourceFormat = Path.GetExtension(textBox_filepath.Text);
            string pandoc_outInfo = "";
            //textBox_result.Text += "\r\n" + sourceFormat;
            for (int i = 0; i < checkedListBox_format.Items.Count; i++)
            {
                if (checkedListBox_format.GetItemChecked(i))
                {
                    if(checkedListBox_format.Items[i].ToString().Equals(sourceFormat))
                    {
                        textBox_result.Text += "\r\n"
                            + "勾选了与源文件格式相同的格式，将自动取消勾选";
                        checkedListBox_format.SetItemChecked(i,false);
                    }
                    else
                    {
                        string pandoc_args = " " + textBox_filepath.Text
                            + " -o " + Path.GetDirectoryName(textBox_filepath.Text)
                            + "\\" + Path.GetFileNameWithoutExtension(textBox_filepath.Text)
                            + checkedListBox_format.Items[i].ToString();
                        Process pandoc_cmd = new Process();
                        pandoc_cmd.StartInfo.FileName = string_pandoc_cmd;
                        pandoc_cmd.StartInfo.Arguments = pandoc_args;
                        pandoc_cmd.StartInfo.CreateNoWindow = false;
                        pandoc_cmd.StartInfo.RedirectStandardOutput = true;
                        pandoc_cmd.StartInfo.RedirectStandardError = true;
                        pandoc_cmd.StartInfo.UseShellExecute = false;
                        pandoc_cmd.Start();
                        string outinfo = pandoc_cmd.StandardOutput.ReadToEnd() +
                            pandoc_cmd.StandardError.ReadToEnd();
                        pandoc_cmd.WaitForExit();
                        pandoc_cmd.Close();
                        textBox_result.Text += "\r\n* "
                            + string_pandoc_cmd
                            + pandoc_args
                            + "\r\n " + outinfo;
                        pandoc_outInfo += outinfo;
                    }
                }
            }
            if (pandoc_outInfo.Length==0)
            {
                textBox_result.Text += "\r\n文件格式转换完成!";
                textBox_result.BackColor = Color.LightGreen;
            }
            else
            {
                textBox_result.Text += "\r\n文件格式转换失败或部分失败!";
                textBox_result.BackColor = Color.Red;
            }
                
            /*
            Process.Start(string_pandoc_cmd, textBox_filepath.Text
                + " -o " + Path.GetFullPath(textBox_filepath.Text)
                + Path.GetFileNameWithoutExtension(textBox_filepath.Text)
                + ".doc");
             * */
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
