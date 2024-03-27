using AuthorizationForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IBiZI_lab3
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoginForm loginForm = new LoginForm();
            Application.Run(loginForm);

            if (loginForm.IsNeedToCloseAllForm) return;

            AdminForm adminForm = new AdminForm(loginForm.OpenformType, loginForm.Users, loginForm.Username, loginForm.UsersFilePath);
            Application.Run(adminForm);
        }
    }
}
