using System;
using System.Windows.Forms;
using System.IO;

namespace lab3
{
    public partial class FormAuthentification : Form
    {
        public FormAuthentification()
        {
            InitializeComponent();
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            User.AddUser(textBoxLogin.Text, textBoxPassword.Text);
            DialogResult = DialogResult.OK;
        }
        private void buttonEnter_Click(object sender, EventArgs e)
        {
            if (User.Authentificate(textBoxLogin.Text, textBoxPassword.Text))
                DialogResult = DialogResult.OK;
            else
                MessageBox.Show("Логин или пароль не верны");
        }
        private void FormAuthentification_Load(object sender, EventArgs e)
        {
            if (User.IsExistUser())
            {
                button.Text = "Войти";
                button.Click += new System.EventHandler(this.buttonEnter_Click);
            }
            else
            {
                button.Text = "Зарегистроваться";
                button.Click += new System.EventHandler(this.buttonAdd_Click);
            }            
        }
    }
}
