using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
namespace hw1
{
	class Task1
    {
		public void StartTask1()
		{
			int? num = 0;
			do
			{
				Console.WriteLine("Введите число от 1 до 100");
				string? numer = Console.ReadLine();//при отсутствии значения строка 21 в ошибке .net 4.0
				if (numer == "") numer = "101";  //STRING ? НЕТ В .NET 4.0 	


				num = Convert.ToInt32(numer);
				if (num < 1 || num > 100)
					Console.WriteLine("Ошибка: число вне диапазона или не введено.");
				else if (num % 3 == 0 & num % 5 == 0)
					Console.WriteLine("Fizz Buzz");
				else if (num % 3 == 0)
					Console.WriteLine("Fizz");
				else if (num % 5 == 0)
					Console.WriteLine("Buzz");
				else if (num % 3 == 0 & num % 5 == 0)
					Console.WriteLine("Fizz Buzz");
				else
					Console.WriteLine(num);
				//Console.ReadKey(true); //to old .net
			} while (num > 0);
		}
	}
	class Task2
	{
		public void StartTask2()
		{
			{
				Console.WriteLine("Введите 2 числа, например Х процентов от У");
				Console.Write(" Х (процентs) = ");
				double percent = Convert.ToDouble(Console.ReadLine());
				Console.Write(" Y (число) = ");
				double number = Convert.ToDouble(Console.ReadLine());
				if (percent <= 0)
					Console.WriteLine("Ошибка: вне диапазона. Процент должен быть >= 0 .");
				else
					Console.WriteLine(number * (percent / 100));
				//Console.ReadKey(true);
			}

		}
	}
	class Task3
	{
		public void StartTask3()
		{
			{
				Console.WriteLine("Введите 4 числа");
				string? sNumber = null;
				for (int i = 0; i < 4; i++)
				{
					sNumber += Console.ReadLine();
				}
				if (sNumber == "") Console.WriteLine("error:ничего не введено");
				else
				{
					double number = Convert.ToDouble(sNumber);
					Console.WriteLine(number);
				}
			}

		}
	}
	class HomeWork
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("1 - задача 1\n2 - задача 2\n3 - задача 3");
			Int32 key = Convert.ToInt32(Console.ReadLine());
			switch (key)
			{
				case 1:
					Task1 task1 = new Task1();
					task1.StartTask1();
					break;
				case 2:
					Task2 task2 = new Task2();
					task2.StartTask2();
					break;
				case 3:
					Task3 task3 = new Task3();
					task3.StartTask3();
					break;
				default:
				break;

			}
				

		}
	}
}