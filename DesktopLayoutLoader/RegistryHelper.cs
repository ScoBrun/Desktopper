using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace DesktopLayoutLoader
{

    /// <summary>
    /// A small helper class to abstract import/export functionality for the registry.
    /// </summary>
    class RegistryHelper
    {

        /// <summary>
        /// This function uses "reg.exe" to export the required key to a .reg file.
        /// </summary>
        /// <param name="keypath">Path to key to be exported.</param>
        /// <param name="filepath">Location of exported key.</param>
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

        public void import()
        {
            // TODO
            // Also, this would require some method of checking this is a registry file that could fit in the provided path.
        }
    }
}
