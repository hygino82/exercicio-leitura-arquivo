using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diretorio
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

            string path = @"C:\curso\";
            string folder = "dilma";

            bool res = Directory.Exists(path + folder);
            //lista.Items.Add(res);

            //if (!res)
            //{
            //    Directory.CreateDirectory(path + folder);
            //    lista.Items.Add("Criada a pasta " + folder);
            //}

            //if(res)
            //{
            //    Directory.Delete(path + folder);
            //    lista.Items.Add("Removida a pasta " + folder);
            //}

            //if (res)
            //{
            //    Directory.Move(path + folder, path + "destino\\dilmaCopia");
            //    lista.Items.Add("Movido para a pasta destino");
            //}


            //string[] pastas = Directory.GetDirectories(path);
            //foreach (string pasta in pastas)
            //{
            //    lista.Items.Add(pasta);
            //}

            //string[] arquivos = Directory.GetFiles(path);
            //foreach (string arquivo in arquivos)
            //{
            //    lista.Items.Add(arquivo);
            //}

            //lista.Items.Add(Directory.GetDirectoryRoot(path));

            //string[] drives = Directory.GetLogicalDrives();
            //lista.Items.AddRange(drives);

            //var info = Directory.GetParent(path);
            //lista.Items.Add(info.FullName);

            var caminho = Directory.GetCurrentDirectory();
            //diretório aonde a aplicação é executada
            lista.Items.Add(caminho);
        }
    }
}


