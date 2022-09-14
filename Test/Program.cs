// See https://aka.ms/new-console-template for more information


string strInput = "abcdefghijklmnopqrstuvwxy";



static void divideStr(string str, int n)
{
    int str_size = str.Length;
    int n_size;
    int chars = str_size / n;
    if (str_size % n != 0)
    {
        Console.WriteLine("Invalid");
        return;
    }
    else
    {
        n_size = str_size / n;
        for (int i = 0; i < str_size; i = i+chars)
        {
            //if (i % str_size == 0)
            Console.WriteLine("");
            Console.Write(str.Substring(i,chars));
        }
    }    
}

divideStr(strInput, 5);