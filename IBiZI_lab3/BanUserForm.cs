using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace IBiZI_lab3
{
    public partial class BanUserForm : Form
    {
        private Dictionary<string, List<string>> users;
        public BanUserForm(Dictionary<string, List<string>> users)
        {
            InitializeComponent();

            this.users = users;
        }

        private void buttonBanUser_Click(object sender, EventArgs e)
        {
            string username = textBoxUserName.Text;

            if (!users.ContainsKey(username))
            {
                MessageBox.Show("Пользователь не найден.");
                return;
            }

            users[username][1] = "true";

            MessageBox.Show($"Пользователь с именем {username} заблокирован");
        }

        private void buttonUnbanUser_Click(object sender, EventArgs e)
        {
            string username = textBoxUserName.Text;

            if (!users.ContainsKey(username))
            {
                MessageBox.Show("Пользователь не найден.");
                return;
            }

            users[username][1] = "false";

            MessageBox.Show($"Пользователь с именем {username} разблокирован");
        }
    }
}
