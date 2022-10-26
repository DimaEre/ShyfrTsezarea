using System;
using System.Collections.Specialized;

class Program
{
   

    void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.InputEncoding = System.Text.Encoding.Unicode;

        int a = 0;
        string text;
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
                    text[i] = abetka[j + a];
                    break;
                }
                else if(abetka[j] == text[i] && j + a > abetka.Length)
                {
                    text[i] = abetka[0 + a];
                    break;
                }
            }
        }
    }
}
