using System;
using System.Windows.Forms;

namespace lab3
{
    public partial class FormInterface : Form
    {
        NetInterface netInterface;
        public FormInterface(NetInterface netInterface)
        {
            InitializeComponent();
            this.netInterface = netInterface;
        }
        public NetInterface Interface {
            get
            {
                return netInterface;
            }
        }
        private void FormInterface_Load(object sender, EventArgs e)
        {
            foreach (string setName in netInterface.Settings.Keys)
            {
                Label label = new Label();
                label.Text = setName;
                tableLayoutPanel1.Controls.Add(label);

                TextBoxValidating textBox = new TextBoxValidating();
                textBox.Width += 20;
                textBox.IsValidating = netInterface.Settings[setName].IsFormat;
                textBox.Text = netInterface.Settings[setName].Value;
                this.Controls.Add(textBox);
                tableLayoutPanel1.Controls.Add(textBox);

                tableLayoutPanel1.RowStyles.Clear();
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
                tableLayoutPanel1.RowCount++;
            }
            Button buttonOk = new Button();
            buttonOk.Text = "OK";
            buttonOk.DialogResult = DialogResult.OK;
            buttonOk.Click += buttonOk_Click;
            tableLayoutPanel1.Controls.Add(buttonOk);

            Button buttonCancel = new Button();
            buttonCancel.Text = "Отмена";
            buttonCancel.DialogResult = DialogResult.Cancel;
            tableLayoutPanel1.Controls.Add(buttonCancel);
        }
        private void buttonOk_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < tableLayoutPanel1.RowCount - 1; i++)
            {
                netInterface.ChangeSetting(tableLayoutPanel1.GetControlFromPosition(0, i).Text,
                    tableLayoutPanel1.GetControlFromPosition(1, i).Text);
            }
        }
    }
}
