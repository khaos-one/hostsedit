using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostsEdit {
    static class Program {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var isAdmin = false;

            try {
                var user = WindowsIdentity.GetCurrent();
                var principal = new WindowsPrincipal(user);
                isAdmin = principal.IsInRole(WindowsBuiltInRole.Administrator);
            }
            catch (UnauthorizedAccessException) { }

            if (!isAdmin) {
                MessageBox.Show("The program requires to be run with administrator privileges.", "Run as administrator",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            else {
                Application.Run(new MainForm());
            }
        }
    }
}
