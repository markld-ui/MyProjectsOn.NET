using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    enum Operate
    {
        P,
        M,
        Mltp, 
        Dv
    }
    /// <summary>
    /// Перед началом работы, Вы должны установить язык, который хотите использовать! 
    /// </summary>
    class UICalc : IUICalc
    {
        protected string lang = "Undefined";
        private string Lang 
        {
            set
            {
                try
                {
                    if (value == "ru" || value == "en")
                    {
                        lang = value;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect lang");
                    }
                }
                catch (Exception ex) 
                {
                    Console.WriteLine($"ERROR: {ex}... You didn't choose the lang or incorrect input-data");
                }
                
            }
        }
        public UICalc() 
        {
           // empty constructor 
        }

        private void ShowRuInfo()
        {
            Calculator calculator = new Calculator();
            Console.WriteLine("Здравуйте! Что бы вы хотели посчитать?");

            bool flag = true;
            while (flag)
            {
                Console.Write("Выберите Операцию из представленных: ");

                foreach (var item in Enum.GetValues(typeof(Operate)))
                {
                    Console.Write($"{item} \t");
                }

                Console.WriteLine();
                var choise = Console.ReadLine();

                switch (choise)
                {
                    case "P":
                        Console.WriteLine("Сколько чисел будете использовать?");
                        int countP = int.Parse(Console.ReadLine());
                        while (countP < 0 || countP == null)
                        {
                            countP = int.Parse(Console.ReadLine());
                        }
                        if (countP == 0)
                        {
                            Console.WriteLine($"Результат суммы всех Ваших чисел: {0}");
                        }
                        else
                        {
                            List<int> numbForSum = new(countP);
                            int i = 0;
                            while (true)
                            {
                                if (i != countP)
                                {
                                    Console.Write("Введите число: ");
                                    numbForSum.Add(int.Parse(Console.ReadLine()));
                                    i++;
                                    Console.WriteLine();
                                }
                                else
                                {
                                    break;
                                }
                            }
                            Console.WriteLine($"Результат суммы всех Ваших чисел: {calculator.SumNumbers(numbForSum.ToArray())}");
                        }
                        break;

                    case "Mltp":
                        Console.WriteLine("Сколько чисел будете использовать?");
                        int countMltp = int.Parse(Console.ReadLine());
                        while (countMltp < 0)
                        {
                            countMltp = int.Parse(Console.ReadLine());
                        }
                        if (countMltp == 0)
                        {
                            Console.WriteLine($"Результат перемножения всех Ваших чисел: {0}");
                        }
                        else
                        {
                            List<int> numbForMltp = new(countMltp);
                            int i = 0;
                            while (true)
                            {
                                if (i != countMltp)
                                {
                                    Console.Write("Введите число: ");
                                    numbForMltp.Add(int.Parse(Console.ReadLine()));
                                    i++;
                                    Console.WriteLine();
                                }
                                else
                                {
                                    break;
                                }
                            }
                            Console.WriteLine($"Результат перемножения всех Ваших чисел: {calculator.MultiplyNumbers(numbForMltp.ToArray())}");
                        }
                        break;

                    case "M":
                        Console.WriteLine("Сколько чисел будете использовать?");
                        int countM = int.Parse(Console.ReadLine());
                        while (countM < 0)
                        {
                            countM = int.Parse(Console.ReadLine());
                        }
                        if (countM == 0)
                        {
                            Console.WriteLine($"Результат разницы всех Ваших чисел: {0}");
                        }
                        else
                        {
                            List<int> numbForM = new(countM);
                            int i = 0;
                            while (true)
                            {
                                if (i != countM)
                                {
                                    Console.Write("Введите число: ");
                                    numbForM.Add(int.Parse(Console.ReadLine()));
                                    i++;
                                    Console.WriteLine();
                                }
                                else
                                {
                                    break;
                                }
                            }
                            Console.WriteLine($"Результат разницы всех Ваших чисел: {calculator.MinusNumbers(numbForM.ToArray())}");
                        }
                        break;
                    case "Dv":
                        Console.WriteLine("Сколько чисел будете использовать?");
                        int countDv = int.Parse(Console.ReadLine());
                        Console.WriteLine("Вы хотите поделить большее на меньшие(-ее) (1) или меньшее на большие(-ее) (2)?");
                        int numbSize = int.Parse(Console.ReadLine());
                        bool isMaxOrOther = true;

                        if (numbSize == 1)
                        { 
                            isMaxOrOther = true;
                        }
                        else if (numbSize == 2) { isMaxOrOther = false; }
                        else
                        {
                            while (true)
                            {
                                Console.WriteLine("Вы выбрали неверный номер! попробуйте еще!");
                                numbSize = int.Parse(Console.ReadLine());
                                if (numbSize == 1 || numbSize == 2 )
                                { break; }
                                else { continue; }
                            }
                        }
                        while (countDv < 0)
                        {
                            countDv = int.Parse(Console.ReadLine());
                        }
                        if (countDv == 0)
                        {
                            Console.WriteLine($"Результат Деления всех Ваших чисел: {0}");
                        }
                        else
                        {
                            List<int> numbForDv = new(countDv);
                            int i = 0;
                            while (true)
                            {
                                if (i != countDv)
                                {
                                    Console.Write("Введите число: ");
                                    numbForDv.Add(int.Parse(Console.ReadLine()));
                                    i++;
                                    Console.WriteLine();
                                }
                                else
                                {
                                    break;
                                }
                            }
                            Console.WriteLine($"Результат деления всех Ваших чисел: {calculator.DevNumbers(isMaxOrOther, numbForDv.ToArray())}");
                        }
                        break;
                }

                Console.WriteLine("Хотите начать заново? Да/Нет");
                string inp = Console.ReadLine();

                if (inp =="Да")
                {
                    continue;
                }
                else if (inp == "Нет")
                { Console.WriteLine("До свидания"); flag = false; }
                else
                {
                    Console.WriteLine("Такого варианта ответа нет. Завершение программы!");
                    flag = false;
                }
            }
        }

        private void ShowEnInfo()
        {
            Calculator calculator = new Calculator();
            Console.WriteLine("Hello! What would you like to count?");

            bool flag = true;
            while (flag)
            {
                Console.Write("Select an Operation from those presented: ");

                foreach (var item in Enum.GetValues(typeof(Operate)))
                {
                    Console.Write($"{item} \t");
                }

                Console.WriteLine();
                var choise = Console.ReadLine();

                switch (choise)
                {
                    case "P":
                        Console.WriteLine("How many numbers will you use?");
                        int countP = int.Parse(Console.ReadLine());
                        while (countP < 0)
                        {
                            countP = int.Parse(Console.ReadLine());
                        }
                        if (countP == 0)
                        {
                            Console.WriteLine($"The result of the sum of all your numbers: {0}");
                        }
                        else
                        {
                            List<int> numbForSum = new(countP);
                            int i = 0;
                            while (true)
                            {
                                if (i != countP)
                                {
                                    Console.Write("Enter the number: ");
                                    numbForSum.Add(int.Parse(Console.ReadLine()));
                                    i++;
                                    Console.WriteLine();
                                }
                                else
                                {
                                    break;
                                }
                            }
                            Console.WriteLine($"The result of the sum of all your numbers: {calculator.SumNumbers(numbForSum.ToArray())}");
                        }
                        break;

                    case "Mltp":
                        Console.WriteLine("How many numbers will you use?");
                        int countMltp = int.Parse(Console.ReadLine());
                        while (countMltp < 0)
                        {
                            countMltp = int.Parse(Console.ReadLine());
                        }
                        if (countMltp == 0)
                        {
                            Console.WriteLine($"The result of multiplying all your numbers: {0}");
                        }
                        else
                        {
                            List<int> numbForMltp = new(countMltp);
                            int i = 0;
                            while (true)
                            {
                                if (i != countMltp)
                                {
                                    Console.Write("Enter the number: ");
                                    numbForMltp.Add(int.Parse(Console.ReadLine()));
                                    i++;
                                    Console.WriteLine();
                                }
                                else
                                {
                                    break;
                                }
                            }
                            Console.WriteLine($"The result of multiplying all your numbers: {calculator.MultiplyNumbers(numbForMltp.ToArray())}");
                        }
                        break;

                    case "M":
                        Console.WriteLine("How many numbers will you use?");
                        int countM = int.Parse(Console.ReadLine());
                        while (countM < 0)
                        {
                            countM = int.Parse(Console.ReadLine());
                        }
                        if (countM == 0)
                        {
                            Console.WriteLine($"The result of the difference of all your numbers: {0}");
                        }
                        else
                        {
                            List<int> numbForM = new(countM);
                            int i = 0;
                            while (true)
                            {
                                if (i != countM)
                                {
                                    Console.Write("Enter the number: ");
                                    numbForM.Add(int.Parse(Console.ReadLine()));
                                    i++;
                                    Console.WriteLine();
                                }
                                else
                                {
                                    break;
                                }
                            }
                            Console.WriteLine($"The result of the difference of all your numbers: {calculator.MinusNumbers(numbForM.ToArray())}");
                        }
                        break;
                    case "Dv":
                        Console.WriteLine("How many numbers will you use?");
                        int countDv = int.Parse(Console.ReadLine());
                        Console.WriteLine("Do you want to divide more by less(1) or less by more (2)?");
                        int numbSize = int.Parse(Console.ReadLine());
                        bool isMaxOrOther = true;

                        if (numbSize == 1)
                        {
                            isMaxOrOther = true;
                        }
                        else if (numbSize == 2) { isMaxOrOther = false; }
                        else
                        {
                            while (true)
                            {
                                Console.WriteLine("You have chosen the wrong number! Try again!");
                                numbSize = int.Parse(Console.ReadLine());
                                if (numbSize == 1 || numbSize == 2)
                                { break; }
                                else { continue; }
                            }
                        }
                        while (countDv < 0)
                        {
                            countDv = int.Parse(Console.ReadLine());
                        }
                        if (countDv == 0)
                        {
                            Console.WriteLine($"The result of Dividing all your numbers: {0}");
                        }
                        else
                        {
                            List<int> numbForDv = new(countDv);
                            int i = 0;
                            while (true)
                            {
                                if (i != countDv)
                                {
                                    Console.Write("Enter the number: ");
                                    numbForDv.Add(int.Parse(Console.ReadLine()));
                                    i++;
                                    Console.WriteLine();
                                }
                                else
                                {
                                    break;
                                }
                            }
                            Console.WriteLine($"The result of Dividing all your numbers: {calculator.DevNumbers(isMaxOrOther, numbForDv.ToArray())}");
                        }
                        break;
                }

                Console.WriteLine("Do you want to start over? Y/N");
                string inp = Console.ReadLine();

                if (inp == "Y")
                {
                    continue;
                }
                else if (inp == "N")
                { Console.WriteLine("Goodbye"); flag = false; }
                else
                {
                    Console.WriteLine("There is no such answer. Completion of the program!");
                    flag = false;
                }
            }
        }

        public void MainLoop()
        {
            Console.WriteLine("Choise the lang: ru/en");
            Lang = Console.ReadLine();

            switch (lang)
            {
                case "ru":
                    ShowRuInfo(); 
                    break;
                case "en":
                    ShowEnInfo();
                    break;
                default:
                    Console.WriteLine("Undefined Lang");
                    break;
            }
        }
    }
}
