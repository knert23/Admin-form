using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using static AuthorizationForm.LoginForm;

namespace IBiZI_lab3
{
    public partial class AdminForm : Form
    {
        private Panel panelMenu;
        private Button buttonRestriction;
        private Button buttonBan;
        private Button buttonAddUser;
        private Button buttonUsers;
        private Button buttonExit;
        private Button buttonChangePass;
        private Button currentButton;
        private Panel panelMain;
        private Form activeForm;
        private string currentUsername;
        private Dictionary<string, List<string>> users;
        private string usersFilePath;

        public AdminForm(FormType? formType, Dictionary<string, List<string>> users, string currentUsername, string usersFilePath)
        {
            InitializeComponent();
            this.users = users;
            this.currentUsername = currentUsername;
            this.usersFilePath = usersFilePath;

            if (formType == FormType.User) DisableAdminsButton();
        }

        private void DisableAdminsButton()
        {
            buttonUsers.Enabled = false;
            buttonAddUser.Enabled = false;
            buttonBan.Enabled = false;
            buttonRestriction.Enabled = false;
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.Aqua;
                }
            }
        }

        private void DisableButton()
        {
            foreach(Control prevButton in panelMenu.Controls)
            {
                if (prevButton.GetType() == typeof(Button))
                {
                    prevButton.BackColor = Color.White;
                }
            }
        }

        private void OpenchildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void SaveUsers()
        {
            List<string> lines = new List<string>();
            foreach (var user in users)
            {
                lines.Add($"{user.Key},{user.Value[0]},{user.Value[1]},{user.Value[2]},{user.Value[3]},{user.Value[4]},{user.Value[5]}");
            }
            File.WriteAllLines(usersFilePath, lines);
        }

        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonRestriction = new System.Windows.Forms.Button();
            this.buttonBan = new System.Windows.Forms.Button();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.buttonUsers = new System.Windows.Forms.Button();
            this.buttonChangePass = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenu.Controls.Add(this.buttonExit);
            this.panelMenu.Controls.Add(this.buttonRestriction);
            this.panelMenu.Controls.Add(this.buttonBan);
            this.panelMenu.Controls.Add(this.buttonAddUser);
            this.panelMenu.Controls.Add(this.buttonUsers);
            this.panelMenu.Controls.Add(this.buttonChangePass);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(150, 579);
            this.panelMenu.TabIndex = 0;
            // 
            // buttonExit
            // 
            this.buttonExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Location = new System.Drawing.Point(0, 520);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(148, 57);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonRestriction
            // 
            this.buttonRestriction.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonRestriction.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonRestriction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRestriction.Location = new System.Drawing.Point(0, 228);
            this.buttonRestriction.Name = "buttonRestriction";
            this.buttonRestriction.Size = new System.Drawing.Size(148, 57);
            this.buttonRestriction.TabIndex = 4;
            this.buttonRestriction.Text = "Restriction";
            this.buttonRestriction.UseVisualStyleBackColor = true;
            this.buttonRestriction.Click += new System.EventHandler(this.buttonRestriction_Click);
            // 
            // buttonBan
            // 
            this.buttonBan.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonBan.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBan.Location = new System.Drawing.Point(0, 171);
            this.buttonBan.Name = "buttonBan";
            this.buttonBan.Size = new System.Drawing.Size(148, 57);
            this.buttonBan.TabIndex = 3;
            this.buttonBan.Text = "Ban User";
            this.buttonBan.UseVisualStyleBackColor = true;
            this.buttonBan.Click += new System.EventHandler(this.buttonBan_Click);
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAddUser.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddUser.Location = new System.Drawing.Point(0, 114);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(148, 57);
            this.buttonAddUser.TabIndex = 2;
            this.buttonAddUser.Text = "Add User";
            this.buttonAddUser.UseVisualStyleBackColor = true;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // buttonUsers
            // 
            this.buttonUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonUsers.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUsers.Location = new System.Drawing.Point(0, 57);
            this.buttonUsers.Name = "buttonUsers";
            this.buttonUsers.Size = new System.Drawing.Size(148, 57);
            this.buttonUsers.TabIndex = 1;
            this.buttonUsers.Text = "Users";
            this.buttonUsers.UseVisualStyleBackColor = true;
            this.buttonUsers.Click += new System.EventHandler(this.buttonUsers_Click);
            // 
            // buttonChangePass
            // 
            this.buttonChangePass.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonChangePass.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonChangePass.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonChangePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChangePass.Location = new System.Drawing.Point(0, 0);
            this.buttonChangePass.Name = "buttonChangePass";
            this.buttonChangePass.Size = new System.Drawing.Size(148, 57);
            this.buttonChangePass.TabIndex = 0;
            this.buttonChangePass.Text = "Change Password";
            this.buttonChangePass.UseVisualStyleBackColor = true;
            this.buttonChangePass.Click += new System.EventHandler(this.buttonChangePass_Click);
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(150, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(894, 579);
            this.panelMain.TabIndex = 1;
            // 
            // AdminForm
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1044, 579);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelMenu);
            this.Name = "AdminForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminForm_FormClosing);
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void buttonChangePass_Click(object sender, EventArgs e)
        {
            OpenchildForm(new ChangePasswordForm(currentUsername, users), sender);
        }

        private void buttonUsers_Click(object sender, EventArgs e)
        {
            OpenchildForm(new UsersForm(users), sender);
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            OpenchildForm(new AddUserForm(users), sender);
        }

        private void buttonBan_Click(object sender, EventArgs e)
        {
            OpenchildForm(new BanUserForm(users), sender);
        }

        private void buttonRestriction_Click(object sender, EventArgs e)
        {
            OpenchildForm(new RestrictionForm(users), sender);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveUsers();
        }
    }
}
