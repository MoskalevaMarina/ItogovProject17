// <copyright file="Calculator.cs" company="My Company Marina">
// Copyright (c) 2021 All Rights Reserved
// </copyright>
using System;
using System.Collections.Generic;
using System.Text;

namespace ItogovProject17
{
    /// <summary>
    /// Класс Calculator
    /// </summary>
    public class Calculator
    {
        /// <summary>
        /// Загружает счет в виде аргумента
        /// </summary>
        /// <param name="calculateInterest">Ввод счета</param>
        /// <param name="account">Ввод акаунта</param>
        public void ExecutionCalculation(ICalculateInterest calculateInterest, Account account)
        {
            calculateInterest.Calculation(account);
        }
    }
}
