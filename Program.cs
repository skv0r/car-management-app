using System;
using System.Windows.Forms;

namespace CarManagementApp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            // Инициализация графического интерфейса
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1()); // Запуск главной формы
        }
    }
}
