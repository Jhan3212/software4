using System;
using System.Windows.Forms;

namespace GoEats
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogin());
        }
    }

    public static class AppData
    {
        public static FormCarrito Carrito = new FormCarrito();
    }
}
