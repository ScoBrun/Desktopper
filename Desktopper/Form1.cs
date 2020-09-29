using System;s
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktopper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handler function for "Save Layout" button.
        /// NOTE: Currently, this doesn't remember exact icon layouts and assumes the software itself is installed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_save_layout_Click(object sender, EventArgs e)
        {
            var keypath = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Taskband";
            var filepath = String.Empty;

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                saveFileDialog.RestoreDirectory = true;
                saveFileDialog.DefaultExt = "reg";
                saveFileDialog.Filter = "Registration Files|*.reg";
                saveFileDialog.CreatePrompt = false;
                saveFileDialog.OverwritePrompt = true;
                saveFileDialog.AddExtension = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filepath = Path.GetFullPath(saveFileDialog.FileName);
                }
            }

            RegistryHelper registryHelper = new RegistryHelper();
            registryHelper.export(keypath, filepath);

            MessageBox.Show("Registry file has been exported to: " + filepath, "Task completed.");
        }

        /// <summary>
        /// Handler function for "Load Layout" button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_load_layout_Click(object sender, EventArgs e)
        {
            var filePath = String.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                openFileDialog.RestoreDirectory = true;
                openFileDialog.DefaultExt = "reg";
                openFileDialog.Filter = "Registration Files|*.reg";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                }
            }

            RegistryHelper registryHelper = new RegistryHelper();
            registryHelper.import(filePath);

            MessageBox.Show("Finished! Please restart explorer.exe to see changes.", "Finished importing keys..");
        }
    }
}