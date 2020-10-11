 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Theme_04
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задание 1.
            // Заказчик просит вас написать приложение по учёту финансов
            // и продемонстрировать его работу.
            // Суть задачи в следующем: 
            // Руководство фирмы по 12 месяцам ведет учет расходов и поступлений средств. 
            // За год получены два массива – расходов и поступлений.
            // Определить прибыли по месяцам
            // Количество месяцев с положительной прибылью.
            // Добавить возможность вывода трех худших показателей по месяцам, с худшей прибылью, 
            // если есть несколько месяцев, в некоторых худшая прибыль совпала - вывести их все.
            // Организовать дружелюбный интерфейс взаимодействия и вывода данных на экран

            // Пример
            //       
            // Месяц      Доход, тыс. руб.  Расход, тыс. руб.     Прибыль, тыс. руб.
            //     1              100 000             80 000                 20 000
            //     2              120 000             90 000                 30 000
            //     3               80 000             70 000                 10 000
            //     4               70 000             70 000                      0
            //     5              100 000             80 000                 20 000
            //     6              200 000            120 000                 80 000
            //     7              130 000            140 000                -10 000
            //     8              150 000             65 000                 85 000
            //     9              190 000             90 000                100 000
            //    10              110 000             70 000                 40 000
            //    11              150 000            120 000                 30 000
            //    12              100 000             80 000                 20 000
            // 
            // Худшая прибыль в месяцах: 7, 4, 1, 5, 12
            // Месяцев с положительной прибылью: 10

            int[] income = new int[12];       //массив, хранящий доходы
            int[] consuption = new int[12];   //массив, хранящий расходы
            int[] arrived = new int[12];      //массив, хранящий прибыль
            int[] months = new int[12]; //массив, хранящий месяца 
            Random r = new Random();
            int count = 0;                    // переменная для хранения количества месяцев с положительной прибылью
            int firstProfit;


            //Заполняем два массива (расходов и доходов). Определяем прибыли по месяцам:

            Console.WriteLine("{0,7}{1,21}{2,20}{3,20}", "Месяц", "Доход, тыс.руб.", "Расход, тыс. руб.", "Прибыль, тыс. руб.");

            for (int i = 0; i < income.Length; i++)
            {
                income[i] = r.Next(100_000, 100_010);
                consuption[i] = r.Next(100_000, 100_010);
                arrived[i] = income[i] - consuption[i];
                months[i] = i + 1;
                if (arrived[i] > 0) count++;
                Console.WriteLine("{0,8}{1,19}{2,20}{3,20}", months[i], income[i], consuption[i], arrived[i]);
            }
            Console.WriteLine();
            Console.WriteLine($"Месяцев с положительной прибылью: {count}");
            Console.WriteLine();
            Array.Sort(arrived, months);
            //for (int i = 0; i < income.Length; i++)
            //{
            //    Console.WriteLine("{0,8}{1,19}{2,20}{3,20}", months[i], income[i], consuption[i], arrived[i]);
            //}
            Console.Write("Худшая прибыль в месяцах: ");
            count = 1;
            firstProfit = arrived[0];
            for (int i = 0; i < income.Length; i++)
            {

                if (firstProfit == arrived[i])
                {
                    Console.Write($"  {months[i]}");
                }
                else if (firstProfit < arrived[i] && count < 3)
                {
                    firstProfit = arrived[i];
                    Console.Write($"  {months[i]}");
                    count++;
                }
                else break;
            }
            Console.WriteLine("\n\n\n");

            //int[,] arrRevenue = new int[12, 2];  // массив дохода по месяцам
            //int[,] arrExpense = new int[12, 2];  // массив расхода по месяцам
            //int[,] arrProfit = new int[12, 2];   // массив прибыли
            //int[] arrWorstProfit = new int[12];        // массив худшей прибыли
            //Random r = new Random();
            //int count=0;                         // переменная для хранения количества месяцев с положительной прибылью
            //int countWorstProfit = 0;            // переменная для хранения количества месяцев с худшей прибылью (до 3)
            //int firstProfit;                     // промежуточная переменная для хранения первой и последующей по порядку прибыли

            ////Заполняем два массива (расходов и доходов). Определяем прибыли по месяцам:

            //Console.WriteLine("{0,5}{1,20}{2,20}{3,20}", "Месяц", "Доход, тыс.руб.", "Расход, тыс. руб.", "Прибыль, тыс. руб.");

            //for (int i=0; i < arrExpense.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arrExpense.GetLength(1); j++)
            //    {
            //        if (0 == j)
            //        {
            //            arrRevenue[i, j] = i;
            //            arrExpense[i, j] = i;
            //            arrProfit[i, j] = i;
            //        }
            //        else
            //        {
            //            arrRevenue[i, j] = r.Next(20_000,200_000);
            //            arrExpense[i, j] = r.Next(20_000, 200_000);
            //            Console.Write("{0,5}{1,19}{2,20}{3,20}", i + 1, arrRevenue[i, j], arrExpense[i, j], arrRevenue[i, j] - arrExpense[i, j]);
            //            arrProfit[i,j]= arrRevenue[i, j] - arrExpense[i, j];
            //        }
            //        if (arrRevenue[i, j] - arrExpense[i, j]>0) count++;   // Считаем количество месяцев с положительной прибылью
            //    }
            //    Console.WriteLine();
            //}

            //// Сортировка массива прибыли

            //for (int i = 0; i < arrProfit.GetLength(0); i++)
            //{
            //    firstProfit = arrProfit[i, 1];
            //    for (int j = 0; j < arrProfit.GetLength(0); j++)
            //    {
            //            if (firstProfit < arrProfit[j, 1])
            //            {
            //            firstProfit = arrProfit[j, 1];
            //            arrProfit[j, 1] ^= arrProfit[i, 1];
            //            arrProfit[i, 1] ^= arrProfit[j, 1];
            //            arrProfit[j, 1] ^= arrProfit[i, 1];
            //            arrProfit[i, 0] ^= arrProfit[j, 0];
            //            arrProfit[j, 0] ^= arrProfit[i, 0];
            //            arrProfit[i, 0] ^= arrProfit[j, 0];
            //        }
            //    }
            //}
            //Console.WriteLine();
            //Console.Write($"Худшая прибыль в месяцах: ");
            //firstProfit = arrProfit[0, 1];
            //Console.Write($"{arrProfit[0, 0] + 1}  ");
            //for (int i = 1; i < arrProfit.GetLength(0); i++)
            //{
            //    for (int j = 1; j < arrProfit.GetLength(1); j++)
            //    {
            //        if (firstProfit < arrProfit[i, j])
            //        {
            //            countWorstProfit++;
            //        }
            //        if (firstProfit <= arrProfit[i, j] && countWorstProfit < 3)
            //        {
            //            Console.Write($"{arrProfit[i, 0] + 1}  ");
            //        }
            //    }
            //}
            //Console.WriteLine();
            //Console.WriteLine($"Месяцев с положительной прибылью: {count}");
            //Console.WriteLine();





            //for (int i = 0; i < arrProfit.GetLength(0); i++)
            //{
            //    for (int j = 1; j < arrProfit.GetLength(1); j++)
            //    {
            //        Console.Write("{0,5}{1,59}", arrProfit[i, 0] + 1, arrProfit[i, j]);
            //    }
            //    Console.WriteLine();
            //}

            Console.ReadKey();

            // * Задание 2
            // Заказчику требуется приложение строящее первых N строк треугольника паскаля. N < 25
            // 
            // При N = 9. Треугольник выглядит следующим образом:
            //                                 1
            //                             1       1
            //                         1       2       1
            //                     1       3       3       1
            //                 1       4       6       4       1
            //             1       5      10      10       5       1
            //         1       6      15      20      15       6       1
            //     1       7      21      35      35       21      7       1
            //                                                              
            //                                                              
            // Простое решение:                                                             
            // 1
            // 1       1
            // 1       2       1
            // 1       3       3       1
            // 1       4       6       4       1
            // 1       5      10      10       5       1
            // 1       6      15      20      15       6       1
            // 1       7      21      35      35       21      7       1
            // 
            // Справка: https://ru.wikipedia.org/wiki/Треугольник_Паскаля

            Console.Write("Введите количество строк треугольника Паскаля: ");
            int n = int.Parse(Console.ReadLine());
            int[][] trianglePascal = new int[n][];
            string[][] trianglePascalStr = new string[n][];
            trianglePascal[0] = new int[] { 1 };
            trianglePascalStr[0] = new string[] { "" };
            string str;
            for (int i = 1; i < trianglePascal.Length; i++)
            {
                trianglePascal[i] = new int[i + 1];
                trianglePascalStr[i] = new string[i + 1];
                for (int j = 0; j <= i; j++)
                {
                    if (j == 0 || j == i)
                        trianglePascal[i][j] = 1;
                    else
                    {
                        trianglePascal[i][j] = trianglePascal[i - 1][j - 1] + trianglePascal[i - 1][j];
                    }
                }
            }

            for (int i = 0; i < trianglePascal.Length; i++)
            {
                for (int j = 0; j < trianglePascal[i].Length; j++)
                {
                    Console.Write("{0,-7} ", trianglePascal[i][j]);  // При выводе используем выравнивание по левому краю 3-х символьного поля
                }
                Console.WriteLine();
            }

            for (int i = 0; i < trianglePascal.Length; i++)
            {
                Console.Write("".PadLeft(n * 4 - i * 4));
                for (int j = 0; j < trianglePascal[i].Length; j++)
                {
                    trianglePascalStr[i][j] = Convert.ToString(trianglePascal[i][j]);
                    str = trianglePascalStr[i][j];
                    Console.Write("{0,-7} ", str);
                }
                Console.WriteLine();
                Console.WriteLine();
            }

            Console.ReadKey();


            //-------------------------------------------------------------------------------------------------------------------------------- 
            // * Задание 3.1
            // Заказчику требуется приложение позволяющщее умножать математическую матрицу на число
            // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)
            // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)#Умножение_матрицы_на_число
            // Добавить возможность ввода количество строк и столцов матрицы и число,
            // на которое будет производиться умножение.
            // Матрицы заполняются автоматически. 
            // Если по введённым пользователем данным действие произвести невозможно - сообщить об этом
            //
            // Пример
            //
            //      |  1  3  5  |   |  5  15  25  |
            //  5 х |  4  5  7  | = | 20  25  35  |
            //      |  5  3  1  |   | 25  15   5  |
            //





            // Решение:





            //Console.WriteLine($"Введите количество строк матрицы:");
            //int a = int.Parse(Console.ReadLine());
            //while (a <= 0){
            //    Console.WriteLine($"Введите число строк, большее 0:");
            //    a = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine($"Введите количество столбцов матрицы:");
            //int b = int.Parse(Console.ReadLine());
            //while (b <= 0)
            //{
            //    Console.WriteLine($"Введите число столбцов, большее 0:");
            //    b = int.Parse(Console.ReadLine());
            //}
            //int[,] matrix = new int[a, b];
            //Random r = new Random();
            //for(int i = 0; i < a; i++)
            //{
            //    for (int j = 0; j < b; j++)
            //    {
            //        matrix[i, j] = r.Next(10);
            //        Console.Write($"{matrix[i, j]} ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine($"Введите число, на которое нужно умножить матрицу:");
            //int c = int.Parse(Console.ReadLine());
            //Console.WriteLine();
            //for (int i = 0; i < a; i++)
            //{
            //    for (int j = 0; j < b; j++)
            //    {
            //        matrix[i, j] *= c;
            //        Console.Write($"{matrix[i, j]} ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadLine();






            // ** Задание 3.2
            // Заказчику требуется приложение позволяющщее складывать и вычитать математические матрицы
            // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)
            // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)#Сложение_матриц
            // Добавить возможность ввода количество строк и столцов матрицы.
            // Матрицы заполняются автоматически
            // Если по введённым пользователем данным действие произвести невозможно - сообщить об этом
            //
            // Пример
            //  |  1  3  5  |   |  1  3  4  |   |  2   6   9  |
            //  |  4  5  7  | + |  2  5  6  | = |  6  10  13  |
            //  |  5  3  1  |   |  3  6  7  |   |  8   9   8  |
            //  
            //  
            //  |  1  3  5  |   |  1  3  4  |   |  0   0   1  |
            //  |  4  5  7  | - |  2  5  6  | = |  2   0   1  |
            //  |  5  3  1  |   |  3  6  7  |   |  2  -3  -6  |


            //Console.WriteLine($"Введите количество строк матрицы №1 и матрицы №2 (складывать можно матрицы только одинакового размера):");
            //int a = int.Parse(Console.ReadLine());
            //while (a <= 0)
            //{
            //    Console.WriteLine($"Введите количество строк, большее 0:");
            //    a = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine($"Введите количество столбцов матрицы №1 и матрицы №2:");
            //int b = int.Parse(Console.ReadLine());
            //while (b <= 0)
            //{
            //    Console.WriteLine($"Введите количество столбцов, большее 0:");
            //    b = int.Parse(Console.ReadLine());
            //}
            //int[,] matrix1 = new int[a, b];
            //int[,] matrix2 = new int[a, b];

            //Random r = new Random();
            //Console.WriteLine($"Матрица 1:");
            //for (int i = 0; i < a; i++)
            //{
            //    for (int j = 0; j < b; j++)
            //    {
            //        matrix1[i, j] = r.Next(10);
            //        Console.Write($"{matrix1[i, j]} ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine($"Матрица 2:");
            //for (int i = 0; i < a; i++)
            //{
            //    for (int j = 0; j < b; j++)
            //    {
            //        matrix2[i, j] = r.Next(10);
            //        Console.Write($"{matrix2[i, j]} ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine($"Результат сложения матриц №1 и  №2:");


            //for (int i = 0; i < a; i++)
            //{
            //    for (int j = 0; j < b; j++)
            //    {
            //        matrix1[i, j] += matrix2[i, j];
            //        Console.Write($"{matrix1[i, j]} ");
            //    }
            //    Console.WriteLine();
            //}           
            //    Console.ReadLine();
            //
            // *** Задание 3.3
            // Заказчику требуется приложение позволяющщее перемножать математические матрицы
            // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)
            // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)#Умножение_матриц
            // Добавить возможность ввода количество строк и столцов матрицы.
            // Матрицы заполняются автоматически
            // Если по введённым пользователем данным действие произвести нельзя - сообщить об этом
            //  
            //  |  1  3  5  |   |  1  3  4  |   | 22  48  57  |
            //  |  4  5  7  | х |  2  5  6  | = | 35  79  95  |
            //  |  5  3  1  |   |  3  6  7  |   | 14  36  45  |
            //
            //  
            //                  | 4 |   
            //  |  1  2  3  | х | 5 | = | 32 |
            //                  | 6 |  



            //Решение:

            //Console.WriteLine($"Введите количество строк матрицы №1");
            //int a = int.Parse(Console.ReadLine());
            //while (a <= 0)
            //{
            //    Console.WriteLine($"Введите количество строк, большее 0:");
            //    a = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine($"Введите количество столбцов матрицы №1:");
            //int b = int.Parse(Console.ReadLine());
            //while (b <= 0)
            //{
            //    Console.WriteLine($"Введите количество столбцов, большее 0:");
            //    b = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine($"Количество строк матрицы №2 при умножении должно равняться количеству столбцов матрицы #1:\n{b}");
            //Console.WriteLine($"Введите количество столбцов матрицы №2:");
            //int d = int.Parse(Console.ReadLine());
            //while (d <= 0)
            //{
            //    Console.WriteLine($"Введите количество столбцов, большее 0:");
            //    d = int.Parse(Console.ReadLine());
            //}
            //int[,] matrix1 = new int[a, b];
            //int[,] matrix2 = new int[b, d];
            //int[,] matrixX = new int[a, d];

            //Random r = new Random();
            //Console.WriteLine($"Матрица 1:");
            //for (int i = 0; i < a; i++)
            //{
            //    for (int j = 0; j < b; j++)
            //    {
            //        matrix1[i, j] = r.Next(10);
            //        Console.Write($"{matrix1[i, j]} ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine($"Матрица 2:");
            //for (int i = 0; i < b; i++)
            //{
            //    for (int j = 0; j < d; j++)
            //    {
            //        matrix2[i, j] = r.Next(10);
            //        Console.Write($"{matrix2[i, j]} ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine($"Результат умножения матриц №1 и  №2:");

            //for (int i = 0; i < a; i++)
            //{
            //    for (int j = 0; j < d; j++)
            //    {
            //        for (int k = 0; k < b; k++)
            //        {
            //            matrixX[i, j] += matrix1[i, k] * matrix2[k, j];
            //        }
            //    }
            //}

            //for (int i = 0; i < a; i++)
            //{
            //    for (int j = 0; j < d; j++)
            //    {
            //        Console.Write($"{matrixX[i, j]} ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadLine();

        }
    }
}
