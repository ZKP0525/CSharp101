using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class PropertySample
{
    static void Main2(string[] args)
    {
        Encoding.Default.GetString();
        Console.WriteLine(Encoding.Default);
        Console.ReadLine();
    }
}
class coGetString
{
    public void GetString()
    {
        Console.WriteLine("hello");
    }
}
class Encoding
{
    //通过让Encoding类的Default属性返回coGetString的类的对象，从而使Encoding能通过Default属性获得coGetString的方法。
    public static coGetString Default
    {
        get
        {
            return new coGetString();
        }
    }

}
