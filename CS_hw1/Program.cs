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
	class Task4
	{
		public void StartTask4()
										/*Пользователь вводит шестизначное число. После чего
										пользователь вводит номера разрядов для обмена цифр.
										Например, если пользователь ввёл один и шесть — это
										значит, что надо обменять местами первую и шестую
										цифры.
										Число 723895 должно превратиться в 523897.
										Если пользователь ввел не шестизначное число требуется
										вывести сообщение об ошибке.*/
		{
			{
				Console.WriteLine("Введите шестизначное число");
				string? sNumber = Console.ReadLine();
				if (sNumber == "") Console.WriteLine("error: число не введено");
				else if (Convert.ToDouble(sNumber) < 100000 || Convert.ToDouble(sNumber) > 999999)
					Console.WriteLine("error: введено не шестизначное число");
				else 
				{
					Console.WriteLine("введите позицию первой цыфры из пары (1-6)");
					Int32 start = Convert.ToInt32(Console.ReadLine());
					if (start < 1 || start > 6) 
					{ 
						Console.WriteLine("error: введено число вне диапазона (1-6)");
						return ;
					}
					Console.WriteLine("введите позицию второй цыфры из пары (1-6)");
					Int32 stop = Convert.ToInt32(Console.ReadLine());
					if (stop < 1 || stop > 6)
					{
						Console.WriteLine("error: введено число вне диапазона (1-6)");
						return;
					}
					if (start == stop )
					{
						Console.WriteLine("error: введены одинаковые позиции цыфр");
						return;
					}

					char st = sNumber[start-1];
					char sp = sNumber[stop-1];
					string result = "";
                    for (int i = 0; i < 6; i++)
                    {
						if(i == start-1) result += sp;
						else if (i == stop-1) result += st;
						else result += sNumber[i];
					}
					Console.WriteLine(result);
				}
			}

		}
	}
	class Task5
	{
		public void StartTask5()
							/*Пользователь вводит с клавиатуры дату.
							Приложение должно отобразить название сезона и дня недели.
							Например, если введено 22.12.2021, приложение должно
							отобразить Winter Wednesday.*/
		{
			{
				Console.Write("Введите день: ");
				Int32 dd = Convert.ToInt32(Console.ReadLine());
				Console.Write("Введите месяц: ");
				Int32 mm = Convert.ToInt32(Console.ReadLine());
				Console.Write("Введите год: ");
				Int32 yyyy = Convert.ToInt32(Console.ReadLine());

				if (mm == 12 || mm == 01 || mm == 02) Console.Write("Winter ");
				if (mm == 03 || mm == 04 || mm == 05) Console.Write("Spring ");
				if (mm == 06 || mm == 07 || mm == 08) Console.Write("Summer ");
				if (mm == 09 || mm == 10 || mm == 11) Console.Write("Autumn ");
				DateTime date1 = new DateTime(yyyy, mm, dd);
				Console.WriteLine(date1.DayOfWeek);

				// проблема как достать елемент из строки и перевести его в число

				Console.ReadKey(true);


			}
		}
	}
	class Task6
	{
		public void StartTask6()
		{

			Console.WriteLine("Введите показания температуры");
			double termo = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("1 - градусы цельсия в градусы фаренгейта\n" +
								"2 - градусы фаренгейта в градусы цельсия");
			int choose = Convert.ToInt32(Console.ReadLine());
			double cel = termo * 9 / 5 + 32;
			double far = (termo - 32) * 5 / 9;

			if (choose == 1) Console.WriteLine(termo + " градуса(ов) цельсия = " + cel + " градуса(ов) фаренгейта");
			if (choose == 2) Console.WriteLine(termo + " градуса(ов) фаренгейта = " + far + " градуса(ов) цельсия ");
			Console.ReadKey();
		}
	}
	class Task7
	{
		public void StartTask7()
		{
			Console.WriteLine("Введите 2 числа");
			double start = Convert.ToDouble(Console.ReadLine());
			double finis = Convert.ToDouble(Console.ReadLine());
			if (finis < start)
			{
				var temp = start;
				start = finis;
				finis = temp;
			}
			for (int i = Convert.ToInt32(start); i <= Convert.ToInt32(finis); i++)
			{
				if (i % 2 == 0) Console.Write(i + " ");
			}
			Console.ReadKey(true);
		}

	}
	class HomeWork
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("1 - задача 1\n2 - задача 2\n3 - задача 3\n" +
                "4 - задача 4\n5 - задача 5\n6 - задача 6\n7 - задача 7");
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
				case 4:
					Task4 task4 = new Task4();
					task4.StartTask4();
					break;
				case 5:
					Task5 task5 = new Task5();
					task5.StartTask5();
					break;
				case 6:
                    Task6 task6 = new Task6();
                    task6.StartTask6();
                    break;
				case 7:
                    Task7 task7 = new Task7();
                    task7.StartTask7();
                    break;
				
				default:
				break;

			}
				

		}
	}
}