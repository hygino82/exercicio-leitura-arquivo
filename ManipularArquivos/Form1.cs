using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManipularArquivos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();
            FileInfo info = new FileInfo(@"c:\curso\teste.txt");
            if (info.Exists)
            {
                lista.Items.Add(info.FullName);//caminho completo do arquivo
                lista.Items.Add(info.Name);//nome do arquivo
                lista.Items.Add(info.Extension);
                lista.Items.Add(info.Directory.FullName);
                lista.Items.Add(info.DirectoryName);
                lista.Items.Add(info.CreationTime);
                lista.Items.Add(info.CreationTimeUtc);
                lista.Items.Add(info.Length);
            }
            else
            {
                lista.Items.Add("O Arquivo " + info.Name + " não existe!");
            }

        }
    }
}
