using System;
using System.Collections.Generic;
 
using System.Windows.Forms;

namespace MarvelRPG
{    

    static class Program
    {

        //public key
        //4b4e33c373b9d3555368bf2e1ebe0f38
        //static string BingMapsKey = "4b4e33c373b9d3555368bf2e1ebe0f38";
        //private key
        //ebd958deca0736e371e9ca8d2e01c289af77bed3

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 intro = new Form1();
            Form2 combat = new Form2();            
            Application.Run(combat);
            
        }
    }
}
