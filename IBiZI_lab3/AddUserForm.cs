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
    public partial class AddUserForm : Form
    {
        private Dictionary<string, List<string>> users;
        public AddUserForm(Dictionary<string, List<string>> users)
        {
            InitializeComponent();
            this.users = users;
        }

        private void buttonAddNewUser_Click(object sender, EventArgs e)
        {
            string newUsername = textBoxNewUsername.Text;

            // Проверка на существование имени пользователя
            foreach(var user in users)
            {
                if (user.Key == newUsername)
                {
                    MessageBox.Show("Пользователь с таким именем уже существует");
                    return;
                }
            }

            List<string> userInfo = new List<string>();
            // Пароль
            userInfo.Add("");
            // Бан
            userInfo.Add("false");
            // Цифры в пароле
            userInfo.Add("false");
            // Специальные символы в пароле
            userInfo.Add("false");
            // Заглавные буквы в пароле
            userInfo.Add("false");
            // Длина пароля
            userInfo.Add("");

            // Добавляем нового пользователя
            users.Add(newUsername, userInfo);

            if (users.ContainsKey(newUsername))
            {
                MessageBox.Show($"Пользователь с именем {newUsername} успешно добавлен");
            }
        }
    }
}
