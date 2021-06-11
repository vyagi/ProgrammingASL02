using System;
using System.Windows.Forms;
using System.IO;

namespace InvoiceManager
{
    public partial class InvoiceManagerForm : Form
    {
        public InvoiceManagerForm()
        {
            InitializeComponent();
        }

        private void readFileButton_Click(object sender, EventArgs e)
        {
            var path = pathTextBox.Text;

            if (!File.Exists(path))
            {
                MessageBox.Show("File does not exist. Cannot continue");
                return;
            }

            var content = File.ReadAllText(path);

            resultTextBox.Text = content;
        }
    }
}
