using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML;
using System.Collections;
using System.IO;
using ClosedXML.Excel;

namespace Seperator
{
    public partial class Form1 : Form
    {

        public string Step { get; set; }
        public string Path { get; set; }
        public string WsName { get; set; }

        OpenFileDialog ofd = new OpenFileDialog();

        FolderBrowserDialog diag=new FolderBrowserDialog();

        ExcellOperations excellOperations = new ExcellOperations();

        ProgressBar pb = new ProgressBar();


        public Form1()
        {
            InitializeComponent();

            Console.WriteLine("UserName: {0}", Environment.SystemDirectory);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel_Back_Paint(object sender, PaintEventArgs e)
        {

        }


        private void button_Browse_Click(object sender, EventArgs e)        //Browse file
        {
            ofd.Filter = "Excell|*.xlsx";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox_Browse.Text = ofd.FileName;
            }

            Path = textBox_Browse.Text;

        }


        private void texbox_Browse_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_worksheet_Click(object sender, EventArgs e)
        {

        }

        private void textBox_worksheet_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_stepWarn_Click(object sender, EventArgs e)
        {

        }

        private void textBox_step_TextChanged(object sender, EventArgs e)
        {
            excellOperations.Part = Convert.ToInt32(textBox_step.Text);
        }

        private void label_Browse_Save_Click(object sender, EventArgs e)
        {

        }

        private void button_Browse2_Click(object sender, EventArgs e)
        {

            if (diag.ShowDialog()==DialogResult.OK)
            {
                var x = diag.SelectedPath;
                textBox_Browse2.Text = x;
            }

            excellOperations.PathNew = textBox_Browse2.Text;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_start_Click(object sender, EventArgs e)
        {

            excellOperations.Path = textBox_Browse.Text;
            excellOperations.WsName = textBox_worksheet.Text;

            excellOperations.Start();

            MessageBox.Show("Keydedildi!!");
        }

        private void progressBar_Click(object sender, EventArgs e)
        {
            pb.Show();
        }
    }

}