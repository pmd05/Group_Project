using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chatgpt
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
  customSort(arr);  

    std::cout << "Mảng sau khi sắp xếp: ";  
    for (int num : arr) {  
        std::cout << num << " ";  
    }  
    std::cout << std::endl;  

    return 0;  
}  
