using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LerEscrever
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEscrevertxt_Click(object sender, EventArgs e)
        {
            string path = @"c:\teste\file.txt";
            StreamWriter writer = new StreamWriter(path, true, Encoding.Default);

            try
            {
                //string linha = txtConteudo.Text;
                //writer.WriteLine(linha);

                string txt = txtConteudo.Text;
                writer.Write(txt);
            }
            catch (Exception)
            {
                //e.StackTrace;
            }
            finally
            {
                //writer.Flush();//limpa o buffer
                //writer.Dispose();
                writer.Close();
            }



        }
    }
}
