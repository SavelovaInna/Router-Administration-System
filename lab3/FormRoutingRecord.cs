using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace lab3
{
    public partial class FormRoutingRecord : Form
    {
        public RoutingRecord record;
        public FormRoutingRecord()
        {
            InitializeComponent();
        }
        bool IpValidating(string ip)
        {
            Regex rgxIp = new Regex(@"(25[0-5]|2[0-4][0-9]|[0-1][0-9]{2}|[0-9]{2}|[0-9])(\.(25[0-5]|2[0-4][0-9]|[0-1][0-9]{2}|[0-9]{2}|[0-9])){3}");
            return rgxIp.IsMatch(ip);
        }
        private void FormRoutingRecord_Load(object sender, EventArgs e)
        {
            textBoxDest.IsValidating = IpValidating;
            textBoxGateway.IsValidating = IpValidating;
            textBoxMask.IsValidating = IpValidating;
            textBoxMask.Text = "255.255.255.0";
        }
        private void buttonОк_Click(object sender, EventArgs e)
        {
            if (textBoxDest.Text.Equals("") || textBoxMask.Text.Equals("") ||
                textBoxGateway.Text.Equals("") ||textBoxMetric.Text.Equals(""))
            {
                MessageBox.Show("Поля заполнены не верно");
            }
            else
            {
                record = new RoutingRecord();
                record.dest = textBoxDest.Text;
                record.mask = textBoxMask.Text;
                record.gateway = textBoxGateway.Text;
                record.metric =Convert.ToInt32(textBoxMetric.Text);
                DialogResult = DialogResult.OK;
            }
        }
    }
}
