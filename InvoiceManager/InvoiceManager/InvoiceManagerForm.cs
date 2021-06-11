using System;
using System.Collections.Generic;
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

        private void byNameButton_Click(object sender, EventArgs e)
        {
            var path = pathTextBox.Text;

            if (!File.Exists(path))
            {
                MessageBox.Show("File does not exist. Cannot continue");
                return;
            }

            var lines = File.ReadAllLines(path);

            var amounts = new Dictionary<string, decimal>();

            for (int i = 1; i < lines.Length; i++)
            {
                var line = lines[i];
                var split = line.Split('\t');

                var name = split[0];
                var amount = decimal.Parse(split[1]);

                if (!amounts.ContainsKey(name))
                {
                    amounts[name] = amount;
                }
                else
                {
                    amounts[name] += amount;
                }
            }

            resultTextBox.Text = "Name\tAmount" + Environment.NewLine;

            foreach (var name in amounts.Keys)
            {
                resultTextBox.Text += (name + '\t' + amounts[name] + Environment.NewLine);
            }
        }
    }
}
