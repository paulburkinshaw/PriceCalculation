﻿using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace PriceCalculation.Tests
{
    [TestFixture]
    public class BasketTests
    {
        [Test]
        public void AddBasketItem_SingleItem_ItemIsAdded()
        {
            // Arrange
            var item = new BasketItem { Name = "Butter", Cost = 0.80M, Quantity = 1 };
            var basket = new Basket();

            var expected = new List<BasketItem>
            {
                item
            };

            // Act
            basket.AddBasketItem(item);
            var result = basket.BasketItems;

            // Assert
            Assert.AreEqual(expected.Count, result.Count);
        }
    }
}
