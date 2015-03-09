using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //try
            //{
            //    string algo = args[0];

            //    Console.WriteLine(args[0]);
            //}
            //catch (IndexOutOfRangeException e) { Console.WriteLine("not working!"); };

            //Console.ReadKey();


        //    MainView v1 = new MainView();
        //    v1.ShowDialog(); // method used to call the form




            Application.Run(new MainView()); // better method used to call the form
            //for this method to work, we need to call System.Drawing and System.Windows.Forms






            //double var2 = 0;
            //double var3 = 0;
            //var2 = (double)8 / 2;
            //Console.WriteLine(var2);
            //Console.ReadKey();
         
          

        }
    }
}
