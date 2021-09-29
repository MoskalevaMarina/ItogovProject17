// <copyright file="Account.cs" company="My Company Marina">
// Copyright (c) 2021 All Rights Reserved
// </copyright>

using System;
using System.Collections.Generic;
using System.Text;

namespace ItogovProject17
{
    /// <summary>
    /// Класс Account
    /// </summary>
    public class Account
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Account"/> class.
        /// </summary>
        /// <param name="type">Ввод тип счета</param>
        /// <param name="balance">Ввод баланса счета</param>
        public Account(string type, double balance)
        {
            this.Type = type;
            this.Balance = balance;
            this.Interest = 0;
        }

        /// <summary>
        /// Gets or sets a value indicating whether поле для хранения типа учетной записи
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether поле для хранения баланса учетной записи
        /// </summary>
        public double Balance { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether поле для хранения процентной ставки
        /// </summary> 
        public double Interest { get; set; }

        /// <summary>
        /// Метод вывода данных
        /// </summary>
        public void Print()
        {
            Console.WriteLine($" Тип счета: {this.Type}, баланс  {this.Balance}, ставка {this.Interest}");
        }
    }
}
