// <copyright file="CalculateSalary.cs" company="My Company Marina">
// Copyright (c) 2021 All Rights Reserved
// </copyright>
using System;
using System.Collections.Generic;
using System.Text;

namespace ItogovProject17
{
    /// <summary>
    /// Класс для зарплатного счета
    /// </summary>
    public class CalculateSalary : ICalculateInterest
    {
        /// <summary>
        /// расчет процентной ставк зарплатного аккаунта по правилам банка
        /// </summary>
        /// <param name="account">Ввод акаунта</param>
        public void Calculation(Account account)
        {
            account.Interest = account.Balance * 0.5;
        }
    }
}
