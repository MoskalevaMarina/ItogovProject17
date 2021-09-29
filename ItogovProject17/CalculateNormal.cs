// <copyright file="CalculateNormal.cs" company="My Company Marina">
// Copyright (c) 2021 All Rights Reserved
// </copyright>
using System;
using System.Collections.Generic;
using System.Text;

namespace ItogovProject17
{
    /// <summary>
    /// Класс для обычного счета
    /// </summary>
    public class CalculateNormal : ICalculateInterest
    {
        /// <summary>
        /// расчет процентной ставки обычного аккаунта по правилам банка
        /// </summary>
        /// <param name="account">Ввод акаунта</param>
        public void Calculation(Account account)
        {
            account.Interest = account.Balance * 0.4;

            if (account.Balance < 1000)
            {
                account.Interest -= account.Balance * 0.2;
            }

            if (account.Balance < 50000)
            {
                account.Interest -= account.Balance * 0.4;
            }
        }
    }
}
