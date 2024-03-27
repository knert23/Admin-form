using IBiZI_lab3;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Linq;

namespace AuthorizationForm
{
    public partial class LoginForm : Form
    {
        // Логин - информация о юзере
        private Dictionary<string, List<string>> users = new Dictionary<string, List<string>>();
        // Файл, в котором хранятся данные для авторизации
        private string usersFilePath = @"C:\Users\pc\source\repos\IBiZI_lab3\IBiZI_lab3\users.txt";
        // Username, под которым зашел пользователь
        private string currentUsername;
        private int incorrectPassCount = 0;

        // Если пароль введен неверно, то закрываются все остальные формы
        public bool IsNeedToCloseAllForm { get; set; } = false;
        public bool IsHackFormOpened { get; set; } = false;
        public string UsersFilePath { get => usersFilePath; }
        public string Username { get => currentUsername; }
        public Dictionary<string, List<string>> Users { get => users; }

        public FormType? OpenformType { get; set; }

        public LoginForm()
        {
            InitializeComponent();
            LoadUsers();
        }

        private void LoadUsers()
        {
            if (File.Exists(usersFilePath))
            {
                string[] lines = File.ReadAllLines(usersFilePath);
                foreach (var line in lines)
                {
                    string[] parts = line.Split(',');
                    List<string> userInfo = new List<string>();

                    userInfo.AddRange(parts.Skip(1));
                    users.Add(parts[0], userInfo);
                }
            }
            else
            {
                string adminInfo = "admin,,false,false,false,false,";
                File.WriteAllText(usersFilePath, adminInfo);

                // Вызов, чтобы всё распарсилось в словарь
                LoadUsers();
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPass.Text;
            currentUsername = username;


            if (!users.ContainsKey(username))
            {
                MessageBox.Show("Пользователь не найден.");
                return;
            }

            if (users[username][0] != password)
            {
               // MessageBox.Show("Неверный пароль.");
                /*incorrectPassCount++;
                if (incorrectPassCount == 3)
                {
                    IsNeedToCloseAllForm = true;
                    this.Close();

                } */
                return;
            }

            if (Boolean.Parse(users[username][1]))
            {
                MessageBox.Show("Вы заблокированы пользователем admin");
                return;
            }

            if (username == "admin")
            {
                OpenformType = FormType.Admin;
            }
            else
            {
                OpenformType = FormType.User;
            }
           
            if (!IsHackFormOpened) this.Close();
        }

        public enum FormType
        {
            Admin,
            User
        }

        private void buttonSearchPass_Click(object sender, EventArgs e)
        {
            HackPassForm form = new HackPassForm(this);
            // Чтобы форма авторизации не закрывалась, когда пароль был найден
            IsHackFormOpened = true;
            form.Show();
        }
    }
}
