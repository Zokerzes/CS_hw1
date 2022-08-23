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
				Console.WriteLine("Введите дату в формате дд.мм.гггг");
				DateTime date = Convert.ToDateTime(Console.ReadLine());

				Console.WriteLine("день недели {1}.", date.DayOfWeek);



				Console.WriteLine();
			}
		}
	}
	class HomeWork
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("1 - задача 1\n2 - задача 2\n3 - задача 3\n4 - задача 4");
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
				default:
				break;

			}
				

		}
	}
}