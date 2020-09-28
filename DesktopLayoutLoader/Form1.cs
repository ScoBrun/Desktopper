using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopLayoutLoader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handler function for "Save Layout" button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_save_layout_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            // Initial directory is "My Documents" folder.
            sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            sfd.RestoreDirectory = true;

            // Default extension for registration files.
            sfd.DefaultExt = "reg";
            sfd.Filter = "Registration Files (.reg)|*.reg";

            // Set properties so user is prompted to create/overwrite if the registration file doesn't exist.
            sfd.CreatePrompt = true;
            sfd.OverwritePrompt = true;
            sfd.AddExtension = true;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                // TODO - DO SOMETHING!
            }




        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_load_layout_Click(object sender, EventArgs e)
        {

        }
    }
}
