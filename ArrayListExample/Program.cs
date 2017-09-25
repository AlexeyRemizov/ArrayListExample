using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ArrayListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Example arr = new Example();
            arr.ShowSmallArray();//Пример одномерного массива
            arr.ShowDoubleArray();//Пример двумерных массивов
            arr.ListWithNumbersExample();//Пример односвязного списка
            arr.ListPersonExample();
            arr.QueueNumbersExample();
            arr.QueuePersonExample();
            arr.DictionaryCollection();
            Console.ReadKey();
        }


        public class Example
        {
            public void ShowSmallArray()
            {
                Console.WriteLine("Amount of array are:");
                int size = int.Parse(Console.ReadLine());
                int[] array = new int[size];

                for (int i = 0; i < size; i++)
                {
                    array[i] = i*i;
                    Console.WriteLine("a[{0}]={1}",i, array[i]);
                }

            }

            public void ShowDoubleArray()
            {
                Console.WriteLine();
                Console.WriteLine("Example of array:");
                int[][] doubleArray = new int [4][];
                
                doubleArray[0] = new int[3];
                doubleArray[1] = new int[5];
                doubleArray[2] = new int[7];
                doubleArray[3] = new int[3];

                

                int[,] doubleArray2 = new int [4, 3];
                int k = 1;
                for (int i = 0; i < 4; i++)
                {
                    Console.WriteLine();
                    for (int j = 0; j < 3; j++)
                    {
                        doubleArray2[i, j] = k++;
                        Console.Write("a[{0},{1}] = {2} ", i, j, doubleArray2[i, j]);
                    }
                }
                Console.WriteLine();
                Console.WriteLine("Length of 'doubleArray2' is {0}",doubleArray2.Length);
                Console.WriteLine("Rank of this massive is {0}",doubleArray2.Rank);
            }

            public void ListWithNumbersExample()
            {
                Console.WriteLine();
                Console.WriteLine("Using of list collection with numbers:");
                List<int> numbers = new List<int>() { 1, 3, 6, 48, 29 };
                numbers.Add(110);// Добавление числа
                numbers.AddRange(new int[] { 32, 43, 15 });//Добавляем массив чисел в список
                numbers.Insert(3, 356);//Вставляем на 4 мето число 356
                numbers.RemoveAt(0);//Удвляем первый элемент

                foreach (int i in numbers)
                {
                    Console.WriteLine(i);
                }


            }

            public string FirstName { get; set; }

            public void ListPersonExample()
            {
                Console.WriteLine();
                Console.WriteLine("Using of list collection with person:");
                List<Example> person = new List<Example>(3);
                person.Add(new Example() { FirstName = "Robert"});
                person.Add(new Example() { FirstName = "Mary"});

                foreach (Example per in person)
                {
                    Console.WriteLine(per.FirstName);
                }

            }

            public void QueueNumbersExample()
            {
                Console.WriteLine();
                Console.WriteLine("Queue collection with numbers");
                Queue<int> number = new Queue<int>();
                number.Enqueue(13);
                number.Enqueue(17);
                number.Enqueue(233);
                number.Enqueue(78);

                foreach (int p in number)
                {
                    Console.WriteLine(p);
                }

                int queueElement = number.Dequeue();
                Console.WriteLine("Dequeue element is {0} ", queueElement);
                Console.WriteLine("Peek element is {0}", number.Peek());

                foreach (int pp in number)
                {
                    Console.WriteLine(pp);
                }
            }

            public void QueuePersonExample()
            {
                Console.WriteLine();
                Console.WriteLine("Queue collection with persons");
                Queue<Example> persons = new Queue<Example>();
                persons.Enqueue(new Example() { FirstName = "Alex" });
                persons.Enqueue(new Example() { FirstName = "Mike" });
                persons.Enqueue(new Example() { FirstName = "Darya" });

                Example person = persons.Peek();
                Console.WriteLine("Peek person is {0} ", person.FirstName);

                Example per = persons.Dequeue();
                Console.WriteLine("Dequeue person is {0}", per.FirstName);
                foreach (Example p in persons)
                {
                    Console.WriteLine(p.FirstName);
                }
            }

            public void DictionaryCollection()
            {
                Console.WriteLine();
                Console.WriteLine("Dictionary collection with countries");
                Dictionary<int, string> countries = new Dictionary<int, string>(5);
                countries.Add(1, "London");
                countries.Add(2, "Russia");
                countries.Add(3, "Ukraine");
                countries.Add(5, "China");
                countries.Add(4, "New Zeland");

                foreach (KeyValuePair<int, string> keyValue in countries)
                {
                    Console.WriteLine("Key is {0}, Value is {1}", keyValue.Key, keyValue.Value);
                }

                Console.WriteLine("Remove 'New Zeland' by Key [4] ");
                countries.Remove(4);

                countries[2] = "USA";
                Console.WriteLine("New element of dictionary [2] is {0}", countries[2]);

                foreach (KeyValuePair<int, string> keyValue in countries)
                {
                    Console.WriteLine("Key is {0}, Value is {1}", keyValue.Key, keyValue.Value);
                }
            }
        }

    }
}