using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GridView
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

namespace StringExtensions
{

    public static class StringExtensionsClass
    {
        //... 

        public static bool Contains(this string target, string toCheck, StringComparison comp)
        {
            return target.IndexOf(toCheck, comp) >= 0;
        }
    }
}