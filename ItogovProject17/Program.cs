// <copyright file="Program.cs" company="My Company Marina">
// Copyright (c) 2021 All Rights Reserved
// </copyright>
using System;

namespace ItogovProject17
{
    /// <summary>
    /// Класс Program
    /// </summary>
    public class Program
    {
        /// <summary>
        ///  Метод Main
        /// </summary>
        public static void Main()
        {
            var calc = new Calculator();

            Account account1 = new Account("Обычный", 1000);
            Account account2 = new Account("Зарплатный", 1500);
           
            calc.ExecutionCalculation(new CalculateNormal(), account1);
            account1.Print();
           
            Console.WriteLine();

            calc.ExecutionCalculation(new CalculateSalary(), account2);
            account2.Print();
        }
    }
}
