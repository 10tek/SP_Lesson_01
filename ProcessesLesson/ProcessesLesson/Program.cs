using System;
using System.Diagnostics;

namespace ProcessesLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            //Process.Start("https://mail.ru");
            //Console.WriteLine("Введите 1 для запуска калькулятора");
            //var currentProcess = Process.GetCurrentProcess();
            //Console.WriteLine($"{currentProcess.Id} - {currentProcess.ProcessName}");

            //currentProcess.Kill();

            var chromeProcess = Process.GetProcessesByName("devenv");
            foreach(var chrome in chromeProcess)
            {
                chrome.Kill();
            }
            //if(int.TryParse(Console.ReadLine(), out var number) && number == 1)
            //{
                
            //Process.Start("calc");
            //}
            //else
            //{
            //    Console.WriteLine("ПОШЕЛ НАХУЙ");
            //    Console.ReadKey();
            //    Console.WriteLine("Я сказал: ПОШЕЛ НАХУЙ");
            //}
        }
    }
}
