using System;

namespace Test_7_PolesUP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int num = Convert.ToInt32(Console.ReadLine());
            string str_num = $"{num}";
            string number = "";
            for(int i = str_num.Length-1;i>0;i--)
            {
                if(str_num[i]>str_num[i-1])
                {
                    for (int j = 0; j<str_num.Length;j++)
                    {
                        if (j == i - 1)
                        {
                            j++;
                            number += str_num[j];
                            j--;
                            number += str_num[j];
                            j++;
                        }
                        else
                        {
                            number += str_num[j];
                        }
                    }
                    break;
                }
            }
            if (number != "") Console.WriteLine(number);
            else Console.WriteLine("0");
        }
    }
}
