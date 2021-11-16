using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Texteditor_Rossler
{
    public partial class Form1 : Form
    {
        string filePath;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog.FileName = "";
            OpenFileDialog.Filter = "All files|*.*|C# class|*.cs|Text file|*.txt";
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = OpenFileDialog.FileName;
                Text.filePath;
            }
        }
    }
}
