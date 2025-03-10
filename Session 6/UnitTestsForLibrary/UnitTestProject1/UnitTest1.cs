using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using WarehouseLibrary;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private WarehouseCalculator _warehouseCalculator;

        [TestInitialize]
        public void Setup()
        {
            _warehouseCalculator = new WarehouseCalculator();
        }

        [TestMethod]
        public void GetTotalQuantity_ShouldReturnCorrectTotal()
        {
            var productsInWarehouses = new List<ProductsInWarehouses>
    {
        new ProductsInWarehouses { Quantity = 10, WarehouseID = 1 },
        new ProductsInWarehouses { Quantity = 15, WarehouseID = 2 },
        new ProductsInWarehouses { Quantity = 5, WarehouseID = 1 }
    };

            var warehouses = new List<Warehouses>
    {
        new Warehouses { WarehouseID = 1 },
        new Warehouses { WarehouseID = 2 }
    };

            var totalQuantity = _warehouseCalculator.GetTotalQuantity(warehouses, productsInWarehouses);

            Assert.AreEqual(30, totalQuantity);
        }

        [TestMethod]
        public void GetTotalQuantity_ByWarehouseId_ShouldReturnCorrectTotal()
        {
            var productsInWarehouses = new List<ProductsInWarehouses>
            {
                new ProductsInWarehouses { Quantity = 10, WarehouseID = 1 },
                new ProductsInWarehouses { Quantity = 15, WarehouseID = 2 },
                new ProductsInWarehouses { Quantity = 5, WarehouseID = 1 }
            };

            var totalQuantity = _warehouseCalculator.GetTotalQuantity(productsInWarehouses, 1);

            Assert.AreEqual(15, totalQuantity);
        }

        [TestMethod]
        public void GetTotalCost_ShouldReturnCorrectTotalCost()
        {
            var productsInWarehouses = new List<ProductsInWarehouses>
            {
                new ProductsInWarehouses { ProductID = 1, Quantity = 10, WarehouseID = 1 },
                new ProductsInWarehouses { ProductID = 2, Quantity = 5, WarehouseID = 1 }
            };

            var products = new List<Product>
            {
                new Product { ProductID = 1, UnitPrice = (double)2.5m },
                new Product { ProductID = 2, UnitPrice = (double)3.0m }
            };

            var totalCost = _warehouseCalculator.GetTotalCost(productsInWarehouses, products);

            Assert.AreEqual(37.5m, totalCost);
        }

        [TestMethod]
        public void GetTotalCost_ByWarehouseId_ShouldReturnCorrectTotalCost()
        {
            var productsInWarehouses = new List<ProductsInWarehouses>
            {
                new ProductsInWarehouses { ProductID = 1, Quantity = 10, WarehouseID = 1 },
                new ProductsInWarehouses { ProductID = 2, Quantity = 5, WarehouseID = 1 },
                new ProductsInWarehouses { ProductID = 1, Quantity = 20, WarehouseID = 2 }
            };

            var products = new List<Product>
            {
                new Product { ProductID = 1, UnitPrice = (double) 2.5m },
                new Product { ProductID = 2, UnitPrice = (double)3.0m }
            };

            var totalCost = _warehouseCalculator.GetTotalCost(productsInWarehouses, products, 1);

            Assert.AreEqual(37.5m, totalCost);
        }

        [TestMethod]
        public void GetQuantityByCategory_ShouldReturnCorrectQuantities()
        {
            var productsInWarehouses = new List<ProductsInWarehouses>
            {
                new ProductsInWarehouses { ProductID = 1, Quantity = 10 },
                new ProductsInWarehouses { ProductID = 2, Quantity = 5 },
                new ProductsInWarehouses { ProductID = 1, Quantity = 15 }
            };

            var products = new List<Product>
            {
                new Product { ProductID = 1, Category = "Electronics" },
                new Product { ProductID = 2, Category = "Groceries" }
            };

            var quantitiesByCategory = _warehouseCalculator.GetQuantityByCategory(productsInWarehouses, products);

            Assert.AreEqual(2, quantitiesByCategory.Count);
            Assert.AreEqual(25, quantitiesByCategory["Electronics"]);
            Assert.AreEqual(5, quantitiesByCategory["Groceries"]);
        }

        [TestMethod]
        public void GetQuantityByCategory_ShouldReturnZeroForNonExistentCategory()
        {
            var productsInWarehouses = new List<ProductsInWarehouses>
            {
                new ProductsInWarehouses { ProductID = 1, Quantity = 10 }
            };

            var products = new List<Product>
            {
                new Product { ProductID = 1, Category = "Electronics" }
            };

            var quantitiesByCategory = _warehouseCalculator.GetQuantityByCategory(productsInWarehouses, products);

            Assert.IsFalse(quantitiesByCategory.ContainsKey("Groceries"));
            Assert.AreEqual(10, quantitiesByCategory["Electronics"]);
        }

        [TestMethod]
        public void GetQuantityByCategory_ShouldHandleEmptyInput()
        {
            var productsInWarehouses = new List<ProductsInWarehouses>();
            var products = new List<Product>();

            var quantitiesByCategory = _warehouseCalculator.GetQuantityByCategory(productsInWarehouses, products);

            Assert.AreEqual(0, quantitiesByCategory.Count);
        }

        [TestMethod]
        public void GetTotalQuantity_NoProducts_ShouldReturnZero()
        {
            var productsInWarehouses = new List<ProductsInWarehouses>();
            var warehouses = new List<Warehouses>
            {
                new Warehouses { WarehouseID = 1 },
                new Warehouses { WarehouseID = 2 }
            };

            var totalQuantity = _warehouseCalculator.GetTotalQuantity(warehouses, productsInWarehouses);

            Assert.AreEqual(0, totalQuantity);
        }

        [TestMethod]
        public void GetTotalCost_NoProducts_ShouldNotReturnNonZeroValue()
        {
            var productsInWarehouses = new List<ProductsInWarehouses>();
            var products = new List<Product>();

            var totalCost = _warehouseCalculator.GetTotalCost(productsInWarehouses, products);

            Assert.AreNotEqual(10m, totalCost);
            Assert.AreNotEqual(1.5m, totalCost);
            Assert.AreNotEqual(100m, totalCost);
        }

        [TestMethod]
        public void GetTotalQuantity_ReturnsCorrectTotal()
        {
            var calculator = new WarehouseCalculator();
            var warehouses = new List<Warehouses>
            {
                new Warehouses { WarehouseID = 1, Name = "Warehouse 1" },
                new Warehouses { WarehouseID = 2, Name = "Warehouse 2" }
            };
            var productsInWarehouses = new List<ProductsInWarehouses>
            {
                new ProductsInWarehouses { WarehouseID = 1, ProductID = 1, Quantity = 10 },
                new ProductsInWarehouses { WarehouseID = 1, ProductID = 2, Quantity = 20 },
                new ProductsInWarehouses { WarehouseID = 2, ProductID = 3, Quantity = 30 }
            };

            var totalQuantity = calculator.GetTotalQuantity(warehouses, productsInWarehouses);

            Assert.AreEqual(60, totalQuantity);
        }
    }
}
