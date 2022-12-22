using System;

namespace ConsoleApp20
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Notebook[] notebooks = new Notebook[3];

            notebooks[0] = new Notebook("Macbook Pro 2021", 2000);
            notebooks[1] = new Notebook("Macbook Pro M1", 3000);
            notebooks[3] = new Notebook("Asus ROG", 3000);
            int input;
            do
            {
                Console.Write("1.Notebooklar uzerinen axtarish et");
                Console.Write("2.Yeni notebook yarat");
                Console.Write("0.Menyudan cix");
                input=int.Parse(Console.ReadLine());
                if(input==1)
                {
                    Console.WriteLine("axtarish sozunu daxil edin");
                    string search=Console.ReadLine();
                 for(int i=0;i<notebooks.Length;i++)
                    {
                        Notebook[] newnotebooks = new Notebook[0];
                        if (notebooks[i].Name.Contains(search))
                        {
                            Array.Resize(ref newnotebooks,notebooks.Length+1);
                            newnotebooks[newnotebooks.Length-1] = notebooks[i];
                        }
                        for( i=0;i<newnotebooks.Length;i++)
                        {
                            Console.WriteLine(newnotebooks[i].GetInfo());
                        }

                            
                    }

                }

                
            } while (input!=0);
        }
    }
}
