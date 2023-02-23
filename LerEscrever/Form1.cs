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
    public partial class btnLerTxt : Form
    {
        public btnLerTxt()
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
            txtConteudo.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtConteudo.Clear();

            string path = @"c:\teste\file.txt";
            StreamReader reader = new StreamReader(path, Encoding.Default);


            string txt = reader.ReadToEnd();
            txtConteudo.Text += txt;
            //string linha = reader.ReadLine();

            //while (linha != null)
            //{
            //    txtConteudo.Text += linha + "\n";
            //    linha = reader.ReadLine();
            //}

            
            //while (!reader.EndOfStream)
            //{
            //    char c = (char)reader.Read();
            //    txtConteudo.Text += c;
            //}

            reader.Close();
        }
    }
}
