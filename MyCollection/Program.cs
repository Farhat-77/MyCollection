using System;

namespace MyCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> list = new MyList<int>();
            for (int i = 0; i < 10; i++)
            {
                list.Add(i);
            }
                
            foreach (int r in list)
            {
                Console.WriteLine(r);
            }
            list.Clear(); 

            Console.WriteLine("Размер листа {0}", list.Count); 
            for (int i = 10; i > 0; i--)
            {
                list.Add(i);
            }
                
            foreach (int r in list) 
            {
                Console.WriteLine(r);
            }
            if (list.Contains(2)) 
            {
                Console.WriteLine("Входит");
            }
            else
            {
                Console.WriteLine("Значение не найдено!");
            }
            Console.ReadKey();
        }
        static int[] BubbleSort(int[] mas)
        {
            int temp;
            for (int i = 0; i < mas.Length - 1; i++)
            {
                for (int j = 0; j < mas.Length - i - 1; j++)
                {
                    if (mas[j + 1] < mas[j])
                    {
                        temp = mas[j + 1];
                        mas[j + 1] = mas[j];
                        mas[j] = temp;
                    }
                }
            }
            return mas;
        }
    }
}
