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
            resultTextBox.Text = FormatLine("Name", "Amount");

            foreach (var name in amounts.Keys)
                resultTextBox.Text += FormatLine(name, amounts[name].ToString());
        }

        private string FormatLine(string name, string amount) => 
            $"{name}\t{amount}{Environment.NewLine}";

        private Dictionary<string, decimal> GroupByNames(string[] lines)
        {
            var amounts = new Dictionary<string, decimal>();

            for (var i = 1; i < lines.Length; i++)
            {
                var invoice = new Invoice(lines[i].Split('\t'));
                
                amounts[invoice.Name] = amounts.ContainsKey(invoice.Name)
                    ? amounts[invoice.Name] + invoice.Amount
                    : invoice.Amount;
            }

            return amounts;
        }
    }
}
