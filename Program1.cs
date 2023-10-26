//34.4
//Console.WriteLine("Введите число");
//double n = Convert.ToDouble(Console.ReadLine());
//double a, b, c;
//a = 0;
//b = 0;
//c = 1;
//for (int i = 1; i <= n; i++)
//{
//    a = a + Math.Cos(i);
//    b = b + Math.Sin(i);
//    c = c * (a / b);
//}
//Console.WriteLine($"Ответ - {c}");
//21.25
//Console.WriteLine("Введите первую величину прямоугольного паралепипеда");
//double a = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Введите вторую величину первого прямоугольного паралепипеда");
//double b = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Введите третью величину первого прямоугольного паралепипеда");
//double c = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Введите первую величину второго прямоугольного паралепипеда");
//double d = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Введите вторую величину второго прямоугольного паралепипеда");
//double f = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Введите третью величину второго прямоугольного паралепипеда");
//double g = Convert.ToDouble(Console.ReadLine());
//double j = 0;
//double h = 0;
//j += a * b * c;
//h += d * f * g;
//if (j > h)
//    Console.WriteLine("Первый паралепипед больше чем второй");
//else
//    Console.WriteLine("Второй паралепипед больше чем первый");
//34.11
//double a, b;
//a = 1 + Math.Sin(0.1);
//for (double i = 0.2; i <= 10; i += 0.1)
//{
//    b = 1 + Math.Sin(i);
//    a = a * b;
//}
//Console.WriteLine($"Выражение равно ={a}");
//39.22
//double summa = 0;
//Console.WriteLine("Введите число a - ");
//int a = Convert.ToInt32(Console.ReadLine());
//while (a > 0)
//{
//    Console.WriteLine("Введите число последовательности b - ");
//    double b = Convert.ToDouble(Console.ReadLine());
//    double c = b % 10;
//    if (c / a == 1)
//        summa += b;
//    else
//    Console.WriteLine("Число не оканчивается на заданное");
//    Console.WriteLine("Продолжить? Y/N");
//    if (Console.ReadLine() == "N")
//        break;
//}
//Console.WriteLine($"Сумма последовательности равна - {summa}");
