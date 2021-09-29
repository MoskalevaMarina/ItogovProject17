// <copyright file="ICalculateInterest.cs" company="My Company Marina">
// Copyright (c) 2021 All Rights Reserved
// </copyright>
using System;
using System.Collections.Generic;
using System.Text;

namespace ItogovProject17
{
    /// <summary>
    /// Общий интерфейс для разных типов счетов
    /// </summary>
    public interface ICalculateInterest
    {
        /// <summary>
        /// Метод для подсчета
        /// </summary>
        /// <param name="account">Ввод акаунта</param>
        void Calculation(Account account);
    }
}
