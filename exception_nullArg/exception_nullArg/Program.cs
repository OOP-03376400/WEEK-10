using System;
class Program
{
    static void Main(string[] args)
    {
        string s = "Hello World";
        PrintArg(s);
        string t = null;
        PrintArg(t);
    }
    public static void PrintArg_old(string arg)
    {
        Console.WriteLine(arg);
    }
    public static void PrintArg(string arg)
    {
        try
        {
            if (null == arg)
            {
                ArgumentNullException myEX = new ArgumentNullException("arg");
                throw myEX;
            }

        }
        catch (ArgumentNullException e)
        {
            Console.WriteLine("Message : {0}", e.Message);
        }

    }
}

