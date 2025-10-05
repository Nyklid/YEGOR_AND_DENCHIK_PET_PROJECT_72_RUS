using System;

namespace calc
{
    class Program
    {
        static void Main(string[] args)
        {
            string disciprtion = ("Хуйня из под коня соси жопу еблан ебучий сучий уебок сын хуйни пошел ты нахуй парашник ебливый уебок");
            int gavno = Convert.ToInt32(Console.ReadLine());
            int mocha = Convert.ToInt32(Console.ReadLine());
            string kall = Console.ReadLine();

            CheckInfo checkInfo = new CheckInfo(gavno, mocha);

            switch (kall)
            {
                case "+":
                    Console.WriteLine($"Слажения: {checkInfo.addition(gavno, mocha)}");
                    break;

                case "*":
                    Console.WriteLine($"Умнажения: {checkInfo.multiply(gavno, mocha)}");
                    break;

                case "/":
                    Console.WriteLine($"Деления: {checkInfo.divide(gavno, mocha)}");
                    break;

                case "%":
                    Console.WriteLine($"Астатак с писи: {checkInfo.modulo(gavno, mocha)}");
                    break;

                case "-":
                    Console.WriteLine($"Дешовое вычитос: {checkInfo.subtraction(gavno, mocha)}");
                    break;

                default:
                    Console.WriteLine($"{disciprtion}");
                    break;
            }
            Console.ReadKey();
        }
    }
}
