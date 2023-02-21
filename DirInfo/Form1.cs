using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DirInfo
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
            DirectoryInfo info = new DirectoryInfo(@"c:\curso");

            lista.Items.Add(info.FullName);
            lista.Items.Add(info.Parent);
            lista.Items.Add(info.Name);
            lista.Items.Add(info.CreationTime);
            lista.Items.Add(info.Exists);
            lista.Items.Add(info.Root);
            lista.Items.Add("----------------------");

            var directories = info.GetDirectories();
            foreach (var dir in directories)
            {
                lista.Items.Add(dir.FullName);
            }

            lista.Items.Add("----------------------");

            var files = info.GetFiles();
            foreach (var file in files)
            {
                lista.Items.Add(file.Name);
            }
        }
    }
}
