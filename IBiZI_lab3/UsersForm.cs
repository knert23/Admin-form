using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IBiZI_lab3
{
    public partial class UsersForm : Form
    {
        public UsersForm(Dictionary<string, List<string>> users)
        {
            InitializeComponent();

            FillListBox(users);
        }

        private void FillListBox(Dictionary<string, List<string>> users)
        {
            foreach (var user in users)
            {
                string userInfo = "Username: " + user.Key + ", Ban: " + users[user.Key][1] + ", Digits: " + users[user.Key][2]
                    + ", Symbols: " + users[user.Key][3] + ", UpperCase: " + users[user.Key][4] + ", Pass Lenght: " + users[user.Key][5];
                UsersList.Items.Add(userInfo);
            }
        }
    }
}
