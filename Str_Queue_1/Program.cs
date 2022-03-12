using System;
using System.Collections.Generic;

namespace Str_Queue_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Console.WriteLine("Введите длину массива:");
            int userMasN;
            while(!int.TryParse(Console.ReadLine(), out userMasN))
            {
                Console.WriteLine("Неверный Ввод числа N! Попробуйте снова:");
            }
            Console.WriteLine("С номера какого элемента начать ввод?");
            int firstIndexOfQueue;
            while (!(int.TryParse(Console.ReadLine(), out firstIndexOfQueue)) && !(firstIndexOfQueue <= userMasN))
            {
                Console.WriteLine("Неверный Ввод индекса первого элемента! Попробуйте снова:");
            }
            Console.WriteLine("Сколько элементов ввести?");
            int amountOfQueueElements;
            while (!(int.TryParse(Console.ReadLine(), out amountOfQueueElements)) && !(amountOfQueueElements <= userMasN - firstIndexOfQueue))
            {
                Console.WriteLine("Неверный Ввод количества элементов очереди! Попробуйте снова:");
            }
            string[] mass = new string[userMasN];
            for(int i = firstIndexOfQueue; i < amountOfQueueElements + firstIndexOfQueue; i++)
            {
                Console.Write($"Введите элемент номер {i}:");
                mass[i] = Console.ReadLine();
            }
            for (int i = firstIndexOfQueue; i < amountOfQueueElements + firstIndexOfQueue; i++)
            {
                Console.WriteLine($"Элемент №{i} равен {mass[i]}");
            }

            while(true)
            {
                bool isProgrammEnd = false;
                /*Console.WriteLine("Добавить элемент, очистить очередь, вывести содержимое, добавить в конец очереди или удалить первый элемент?");*/
                Console.WriteLine("1.Добавить элемент\n2.Очистить очередь\n3.Вывести содержимое\n4.Добавить в конец очереди\n5.Удалить первый элемент\n6-9 Завершить работу?");
                int userInput = -1;
                userInput = Int16.Parse(Console.ReadLine());
                switch(userInput)
                {
                    case 1:
                        Console.WriteLine("Введите элемент, который надо добавить:");
                        string newElem = Console.ReadLine();

                        break;
                    case 2:
                        Console.WriteLine("dasas");
                        break;
                    case 3:
                        Console.WriteLine("dasas");
                        break;
                    case 4:
                        Console.WriteLine("dasas");
                        break;
                    case 5:
                        Console.WriteLine("dasas");
                        break;
                    default:
                        isProgrammEnd = true;
                        break;
                }
                if(isProgrammEnd)
                {
                    Console.WriteLine("Программа завершила своё выполнение.");
                    break;
                }
            }
            void CheckIfLastIndexNotEmpty(string[] mass)
            {
                if (mass[mass.Length] == "asd")
                {

                }
            }
        }
    }
}
