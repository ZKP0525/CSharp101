using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetFramworkConsole
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            /*Form myForm = new Form();
            myForm.Text = "My Form";
            myForm.ShowDialog();*/
            //Form myform = new Form();
            Student student = default;
            int a = default;
            if (student == null) Console.WriteLine("null");
            if (a == 0) Console.WriteLine("0");
            Console.WriteLine(student);
            Console.WriteLine(a);
            Console.ReadLine();
            Form myform;
        }
        class Student
        {
            public int id;
        }
    }
}
