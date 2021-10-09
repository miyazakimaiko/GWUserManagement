using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GWUserManagement
{
    class UtilityFilePath
    {
        public static bool findFilepath(TextBox textBoxImage)
        {
            int size = -1;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                textBoxImage.Text = file;
                try
                {
                    string text = File.ReadAllText(file);
                    size = text.Length;

                    return true;
                }
                catch (IOException exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
            return false;
        }

        public static void clearErrorLabel(Control control)
        {
            if (control is Label)
            {
                Label lbl = (Label)control;
                if (lbl.Name.StartsWith("labelError"))
                    lbl.Text = String.Empty;

            }
            else
                foreach (Control child in control.Controls)
                {
                    clearErrorLabel(child);
                }
        }
    }
}
