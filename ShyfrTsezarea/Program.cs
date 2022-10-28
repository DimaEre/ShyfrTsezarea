using System;
using System.Collections.Specialized;
using System.Reflection;

class Program
{
   

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.InputEncoding = System.Text.Encoding.Unicode;

        int a = 0;
        string text;
        string btext = "";
        string abetka = "абвгґдеєжзиіїйклмнопртстуфхцчшщюя";

        Console.WriteLine("\t\t\tШифр Цезаря");
        Console.Write("Зсув:    ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Текст:   ");        
        text = Console.ReadLine();


        for (int i = 0; i < text.Length; i++)
        { 
            for (int j = 0; j < abetka.Length; j++)
            {
                if (abetka[j] == text[i] && j + a < abetka.Length)
                {
                    btext += abetka[j + a];
                    break;
                }
                else if(abetka[j] == text[i] && j + a > abetka.Length)
                {
                    btext += abetka[0 + a - (abetka.Length - j)];
                    break;
                }
            }
        }
        text = btext;
        Console.WriteLine(text);
    }
}
