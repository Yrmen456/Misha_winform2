using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trade
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        public static Authorization authorization;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MyApplicationContext Context = new MyApplicationContext();
            MyApplicationContext.Open(new Authorization());
            Application.Run();
        }
        public static int formCount;
        public class MyApplicationContext : ApplicationContext
        {
            static public void Open(Form form)
            {
                form.Closed += OnFormClosed;
                formCount++;
                form.Show();
            }

            static public void OnFormClosed(object sender, EventArgs e)
            {
                formCount--;
                if (formCount <=0)
                {
                    Application.Exit();
                }
            }
        }
    }
}
