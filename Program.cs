using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

/**Author@ Nanabena**/
namespace inventory
{
    static class Program
    {
     
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            loading welform = new loading();
            welform.Show();
            System.Threading.Thread.Sleep(3000);
            welform.Hide();
            Application.Run(new Form1());
            

       
        }
    }
}
