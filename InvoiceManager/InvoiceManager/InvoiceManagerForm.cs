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

            resultTextBox.Text = File.ReadAllText(path);
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

            var amounts = GroupByNames(lines);

            DisplayGroupedByNames(amounts);
        }

        private void DisplayGroupedByNames(Dictionary<string, decimal> amounts)
        {
            resultTextBox.Text = $"Name\tAmount{Environment.NewLine}";

            foreach (var name in amounts.Keys)
                resultTextBox.Text += $"{name}{'\t'}{amounts[name]}{Environment.NewLine}";
        }

        private Dictionary<string, decimal> GroupByNames(string[] lines)
        {
            var amounts = new Dictionary<string, decimal>();

            for (var i = 1; i < lines.Length; i++)
            {
                var invoice = new Invoice(lines[i].Split('\t'));

                if (amounts.ContainsKey(invoice.Name))
                    amounts[invoice.Name] += invoice.Amount;
                else
                    amounts[invoice.Name] = invoice.Amount;
            }

            return amounts;
        }
    }
}
