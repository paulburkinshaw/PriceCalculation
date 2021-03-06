﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceCalculation
{
    public interface IBasketTotalCalculator
    {
        decimal CalculateBasketTotal();
        List<BasketItem> BasketItems { get; }
    }
}
