using System;
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
            SaveFileDialog safeFileDialog = new SaveFileDialog();

            // Initial directory.
            safeFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            safeFileDialog.RestoreDirectory = true;

            // Default extension for files.
            safeFileDialog.DefaultExt = "reg";
            safeFileDialog.Filter = "Registration Files|*.reg";

            // Set properties.
            safeFileDialog.CreatePrompt = false;
            safeFileDialog.OverwritePrompt = true;
            safeFileDialog.AddExtension = true;

            if (safeFileDialog.ShowDialog() == DialogResult.OK)
            {
                String keypath = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Taskband";
                String filepath = Path.GetFullPath(safeFileDialog.FileName);

                RegistryHelper registryHelper = new RegistryHelper();
                registryHelper.export(keypath, filepath);

                // This should show if all goes well.
                MessageBox.Show("Registry file has been exported to: " + filepath, "Task completed.");
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_load_layout_Click(object sender, EventArgs e)
        {
            // TODO
        }
    }
}
