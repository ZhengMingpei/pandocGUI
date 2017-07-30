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
        private Dictionary<int, string> support_Format;
        private void configGUI()
        {
            //int enumSize=Enum.GetNames(typeof(checkboxEnum)).GetLength(0);
            if (check_pandoc())
            {
                //checkBox_pandoc.Enabled = false;
                checkBox_pandoc.Checked = true;
                button_openfile.Enabled = true;
                textBox_result.Text = "1. 软件环境检测结束...\r\n* Pandoc已经安装\r\n"
                + "* 转换器目前可以运行。\r\n------------------\r\n"
                + "2. 请选择源文件...";
                textBox_result.BackColor = Color.SpringGreen;          
            }
            else
            {
                textBox_result.Text = "1. 软件环境检测结束...\r\n* Pandoc没有安装\r\n"
                +"* 转换器无法运行，请确定至少有pandoc已经安装！";
                textBox_result.BackColor = Color.Red;  
            }
        }
        private void ban_button()
        {
            button_checkEvn.Enabled = false;
            button_openfile.Enabled = false;
            button_start.Enabled = false;
            button_end.Enabled = false;        
        }
        
        private bool check_pandoc()
        {
            string string_path = Environment.GetEnvironmentVariable("PATH", EnvironmentVariableTarget.User)
                + Environment.GetEnvironmentVariable("PATH", EnvironmentVariableTarget.Machine);
            return string_path.Contains("Pandoc"); 
        }
        private void config_output_Format()
        {
            string sourceFormat = Path.GetExtension(textBox_filepath.Text);
            //Console.WriteLine(sourceFormat);
            textBox_result.Text += "source file type: " + sourceFormat;
            checkedListBox_format.Enabled = true;
            for (int i = 0; i < checkedListBox_format.Items.Count; i++)
            {
                string item = checkedListBox_format.Items[i].ToString();
                
                if (item.Equals(sourceFormat))
                {
                    checkedListBox_format.SetItemChecked(i, false);
                    
                }
                else
                {
                    checkedListBox_format.SetItemChecked(i, true);
                    
                }
            }
            //textBox_result.Text = textBox_result.Text + checkedListBox_format.Items[0].ToString();
            
        }
        private void button_openfile_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            textBox_filepath.Text = openFileDialog1.FileName;
            button_start.Enabled = true;
            textBox_result.Text = textBox_result.Text + "\r\n已经选择了源文件\r\n" + textBox_filepath.Text
                + "\r\n------------------\r\n3. 请选择输出格式...";
            //checkedListBox_format.Enabled = true;
            config_output_Format();
            
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
            textBox_result.Text=
                string_pandoc_cmd
                + " " 
                + textBox_filepath.Text
                + " -o " + Path.GetDirectoryName(textBox_filepath.Text)
                + "\\" + Path.GetFileNameWithoutExtension(textBox_filepath.Text)
                + ".doc";
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
