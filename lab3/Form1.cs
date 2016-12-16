using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;


namespace lab3
{
    public partial class Form1 : Form
    {
        Router router;
        public Form1()
        {
            InitializeComponent();
        }
        private void form_Load(object sender, EventArgs e)
        {
            FormAuthentification form = new FormAuthentification();
            InterfaceRouterParametrsServise parametrServise = new RouterParametersService("parConfig.txt");
            InterfaceRoutingTable routingTable = new RoutingTable("routingConfig.txt");
            router = new Router(parametrServise,routingTable);
            router.Load();
            if (form.ShowDialog() != DialogResult.OK)
                this.Close();           
            Setting mac = router.GetMac();
            textBoxMac.IsValidating = mac.IsFormat;
            textBoxMac.Text = mac.Value;
        }
        private void UpdateInterfaceList()
        {
            listViewInterface.Items.Clear();
            List<NetInterface> interfaces = router.GetInterfaces();
            var items = interfaces.Select(i => new ListViewItem(new string[] { i.name, i.Settings["ip"].Value }));
            listViewInterface.Items.AddRange(items.ToArray());
        }
        private void UpdateDataGrid()
        {
            Query queryDest = new DestQuery(textBoxDest.Text);
            Query queryGateway = new GatewayQuery(textBoxGateway.Text);
            List<RoutingRecord> table = router.GetRoutingTable(queryDest.And(queryGateway));
            dataGridView1.Rows.Clear();
            table.ForEach(r => dataGridView1.Rows.Add(r.dest, r.mask, r.gateway, r.metric));
        }
        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (((TabControl)sender).SelectedIndex)
            {
                case 1:
                    UpdateInterfaceList();
                    break;
                case 2:
                    UpdateDataGrid();
                    break;
            }
        }
        private void buttonChangeMac_Click(object sender, EventArgs e)
        {
            router.SetMac(textBoxMac.Text);
        }
        private void listViewInterface_DoubleClick(object sender, EventArgs e)
        {
            if (listViewInterface.SelectedIndices.Count > 0)
            {
                List<NetInterface> interfaces = router.GetInterfaces();
                FormInterface form = new FormInterface(interfaces[listViewInterface.SelectedIndices[0]]);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    if (router.SaveInterface(form.Interface))
                    UpdateInterfaceList();
                }
            }
        }
        private void textBoxDest_TextChanged(object sender, EventArgs e)
        {
            UpdateDataGrid();
        }

        private void textBoxGateway_TextChanged(object sender, EventArgs e)
        {
            UpdateDataGrid();
        }
        private void buttonAddRoutingRecord_Click(object sender, EventArgs e)
        {
            FormRoutingRecord form = new FormRoutingRecord();
            if (form.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.Rows.Add(form.record.dest, form.record.mask,
                    form.record.gateway, form.record.metric);
                router.AddRoutingRecord(form.record);
            }
        }
        private void DelRotingRecord_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];          
                RoutingRecord record = new RoutingRecord();
                record.SetParameters((string)row.Cells["dest"].Value,
                    (string)row.Cells["mask"].Value,
                    (string)row.Cells["gateway"].Value,
                    Convert.ToInt32(row.Cells["metric"].Value));
                    router.DeleteRoutingRecord(record);
                dataGridView1.Rows.Remove(row);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Выберите строку для удаления");
            }
        }
        private void buttonReset_Click(object sender, EventArgs e)
        {
            User.Reset();
            router.Reset();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            router.Save();
        }     
    }
}
