using System;

namespace Lab2__PP_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int numb = 0;

            
            while (true)
            {
                Console.WriteLine("Введите целое число от 1 до 9999");
                if (int.TryParse(Console.ReadLine(), out int x))
                {
                    if ((x >= 1) && (x <= 9999))
                    {
                        numb = x;
                        break;
                    }
                }
            }

            switch (numb / 1000) // количество тысяч
            {
                case 1:
                    Console.Write("Одна тысяча ");
                    break;
                case 2:
                    Console.Write("Две тысячи ");
                    break;
                case 3:
                    Console.Write("Три тысячи ");
                    break;
                case 4:
                    Console.Write("Четыре тысячи ");
                    break;
                case 5:
                    Console.Write("Пять тысяч ");
                    break;
                case 6:
                    Console.Write("Шесть тысяч ");
                    break;
                case 7:
                    Console.Write("Семь тысяч ");
                    break;
                case 8:
                    Console.Write("Восемь тысяч ");
                    break;
                case 9:
                    Console.Write("Девять тысяч ");
                    break;
            }
            if (numb / 1000 != 0)
            {
                switch ((numb / 100) % 10) // количество сотен
                {
                    case 1:
                        Console.Write("сто ");
                        break;
                    case 2:
                        Console.Write("двести ");
                        break;
                    case 3:
                        Console.Write("триста ");
                        break;
                    case 4:
                        Console.Write("четыреста ");
                        break;
                    case 5:
                        Console.Write("пятьсот ");
                        break;
                    case 6:
                        Console.Write("шестьсот ");
                        break;
                    case 7:
                        Console.Write("семьсот ");
                        break;
                    case 8:
                        Console.Write("восемьсот ");
                        break;
                    case 9:
                        Console.Write("девятьсот ");
                        break;
                }
            }
            else
            {
                switch ((numb / 100) % 10) // количество сотен
                {
                    case 1:
                        Console.Write("Сто ");
                        break;
                    case 2:
                        Console.Write("Двести ");
                        break;
                    case 3:
                        Console.Write("Триста ");
                        break;
                    case 4:
                        Console.Write("Четыреста ");
                        break;
                    case 5:
                        Console.Write("Пятьсот ");
                        break;
                    case 6:
                        Console.Write("Шестьсот ");
                        break;
                    case 7:
                        Console.Write("Семьсот ");
                        break;
                    case 8:
                        Console.Write("Сосемьсот ");
                        break;
                    case 9:
                        Console.Write("Девятьсот ");
                        break;
                }
            }
            if ((numb % 100) > 10 && (numb % 100) < 20) // определение с десятками
            {
                if (numb / 100 != 0)
                {
                    switch (numb % 100)
                    {
                        case 11:
                            Console.Write("одиннадцать ");
                            Console.Write("рублей ");
                            break;
                        case 12:
                            Console.Write("двенадцать ");
                            Console.Write("рублей ");
                            break;
                        case 13:
                            Console.Write("триннадцать ");
                            Console.Write("рублей ");
                            break;
                        case 14:
                            Console.Write("четырнадцать ");
                            Console.Write("рублей ");
                            break;
                        case 15:
                            Console.Write("пятнадцать ");
                            Console.Write("рублей ");
                            break;
                        case 16:
                            Console.Write("шестнадцать ");
                            Console.Write("рублей ");
                            break;
                        case 17:
                            Console.Write("семнадцать ");
                            Console.Write("рублей ");
                            break;
                        case 18:
                            Console.Write("восемнадцать ");
                            Console.Write("рублей ");
                            break;
                        case 19:
                            Console.Write("девятнадцать ");
                            Console.Write("рублей ");
                            break;
                    }
                }
                else
                {
                    switch (numb % 100)
                    {
                        case 11:
                            Console.Write("Одиннадцать ");
                            Console.Write("рублей ");
                            break;
                        case 12:
                            Console.Write("Двенадцать ");
                            Console.Write("рублей ");
                            break;
                        case 13:
                            Console.Write("Триннадцать ");
                            Console.Write("рублей ");
                            break;
                        case 14:
                            Console.Write("Четырнадцать ");
                            Console.Write("рублей ");
                            break;
                        case 15:
                            Console.Write("Пятнадцать ");
                            Console.Write("рублей ");
                            break;
                        case 16:
                            Console.Write("Шестнадцать ");
                            Console.Write("рублей ");
                            break;
                        case 17:
                            Console.Write("Семнадцать ");
                            Console.Write("рублей ");
                            break;
                        case 18:
                            Console.Write("Восемнадцать ");
                            Console.Write("рублей ");
                            break;
                        case 19:
                            Console.Write("Девятнадцать ");
                            Console.Write("рублей ");
                            break;
                    }
                }

            }
            else
            {
                if (numb / 100 != 0)
                {

                    switch ((numb / 10) % 10) // количество десятков
                    {
                        case 1:
                            Console.Write("десять ");
                            break;
                        case 2:
                            Console.Write("двадцать ");
                            break;
                        case 3:
                            Console.Write("тридцать ");
                            break;
                        case 4:
                            Console.Write("сорок ");
                            break;
                        case 5:
                            Console.Write("пятьдесят ");
                            break;
                        case 6:
                            Console.Write("шестьдесят ");
                            break;
                        case 7:
                            Console.Write("семьдесят ");
                            break;
                        case 8:
                            Console.Write("восемьдесят ");
                            break;
                        case 9:
                            Console.Write("девяносто ");
                            break;
                    }

                    switch (numb % 10) // количество единиц
                    {
                        case 0:
                            break;
                        case 1:
                            Console.Write("один ");
                            break;
                        case 2:
                            Console.Write("два ");
                            break;
                        case 3:
                            Console.Write("три ");
                            break;
                        case 4:
                            Console.Write("четыре ");
                            break;
                        case 5:
                            Console.Write("пять ");
                            break;
                        case 6:
                            Console.Write("шесть ");
                            break;
                        case 7:
                            Console.Write("семь ");
                            break;
                        case 8:
                            Console.Write("восемь ");
                            break;
                        case 9:
                            Console.Write("девять ");
                            break;
                    }
                }
                else
                {
                    switch ((numb / 10) % 10) // количество десятков
                    {
                        case 1:
                            Console.Write("Десять ");
                            break;
                        case 2:
                            Console.Write("Двадцать ");
                            break;
                        case 3:
                            Console.Write("Тридцать ");
                            break;
                        case 4:
                            Console.Write("Сорок ");
                            break;
                        case 5:
                            Console.Write("Пятьдесят ");
                            break;
                        case 6:
                            Console.Write("Шестьдесят ");
                            break;
                        case 7:
                            Console.Write("Семьдесят ");
                            break;
                        case 8:
                            Console.Write("Восемьдесят ");
                            break;
                        case 9:
                            Console.Write("Девяносто ");
                            break;
                    }

                    if (numb / 10 != 0)
                    {

                        switch (numb % 10) // количество единиц
                        {
                            case 0:
                                break;
                            case 1:
                                Console.Write("один ");
                                break;
                            case 2:
                                Console.Write("два ");
                                break;
                            case 3:
                                Console.Write("три ");
                                break;
                            case 4:
                                Console.Write("четыре ");
                                break;
                            case 5:
                                Console.Write("пять ");
                                break;
                            case 6:
                                Console.Write("шесть ");
                                break;
                            case 7:
                                Console.Write("семь ");
                                break;
                            case 8:
                                Console.Write("восемь ");
                                break;
                            case 9:
                                Console.Write("девять ");
                                break;
                        }
                    }
                    else
                    {
                        switch (numb % 10) // количество единиц
                        {
                            case 0:
                                break;
                            case 1:
                                Console.Write("Один ");
                                break;
                            case 2:
                                Console.Write("Два ");
                                break;
                            case 3:
                                Console.Write("Три ");
                                break;
                            case 4:
                                Console.Write("Четыре ");
                                break;
                            case 5:
                                Console.Write("Пять ");
                                break;
                            case 6:
                                Console.Write("Шесть ");
                                break;
                            case 7:
                                Console.Write("Семь ");
                                break;
                            case 8:
                                Console.Write("Восемь ");
                                break;
                            case 9:
                                Console.Write("Девять ");
                                break;
                        }
                    }
                }

                switch (numb % 10)
                {
                    case 0:
                        Console.Write("рублей ");
                        break;
                    case 1:
                        Console.Write("рубль ");
                        break;
                    case 2:
                        Console.Write("рубля ");
                        break;
                    case 3:
                        Console.Write("рубля ");
                        break;
                    case 4:
                        Console.Write("рубля ");
                        break;
                    case 5:
                        Console.Write("рублей ");
                        break;
                    case 6:
                        Console.Write("рублей ");
                        break;
                    case 7:
                        Console.Write("рублей ");
                        break;
                    case 8:
                        Console.Write("рублей ");
                        break;
                    case 9:
                        Console.Write("рублей ");
                        break;
                }
            }
            
            Console.ReadLine();
        }
    }
}
