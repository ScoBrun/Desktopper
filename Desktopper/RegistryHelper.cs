using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Desktopper
{

    /// <summary>
    /// A small helper class to abstract import/export functionality for the registry.
    /// </summary>
    class RegistryHelper
    {
        /// <summary>
        /// Exports the required key to a specified .reg file.
        /// </summary>
        /// <param name="keypath">Path to registry we are exporting.</param>
        /// <param name="filepath">The absolute path to the file to export the registry data to.</param>
        public void export(String keypath, String filepath)
        {
            try
            {
                using (Process proc = new Process())
                {
                    proc.StartInfo.FileName = "reg.exe";
                    proc.StartInfo.Arguments = "export \"" + keypath + "\" \"" + filepath + "\" /y";

                    proc.StartInfo.UseShellExecute = false;
                    proc.StartInfo.RedirectStandardOutput = true;
                    proc.StartInfo.RedirectStandardError = true;
                    proc.StartInfo.CreateNoWindow = true;

                    proc.Start();

                    string stdout = proc.StandardOutput.ReadToEnd();
                    string stderr = proc.StandardError.ReadToEnd();

                    proc.WaitForExit();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }

        /// <summary>
        /// Imports the required key from the provided .reg file.
        /// </summary>
        /// <param name="filePath">The absolute path to the registry file to import.</param>
        internal void import(string filePath)
        {
            try
            {
                using (Process proc = new Process())
                {
                    proc.StartInfo.FileName = "reg.exe";
                    proc.StartInfo.Arguments = "import \"" + filePath + "\"";

                    proc.StartInfo.UseShellExecute = false;
                    proc.StartInfo.RedirectStandardOutput = true;
                    proc.StartInfo.RedirectStandardError = true;
                    proc.StartInfo.CreateNoWindow = true;

                    proc.Start();

                    string stdout = proc.StandardOutput.ReadToEnd();
                    string stderr = proc.StandardError.ReadToEnd();

                    proc.WaitForExit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }
    }
}