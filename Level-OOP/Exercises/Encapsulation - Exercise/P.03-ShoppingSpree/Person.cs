﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P._03_ShoppingSpree
{
    public class Person
    {
        private string name;
        private decimal money;
        private List<Product> products;

        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
            this.products = new List<Product>();
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }

                this.name = value;
            }
        }

        public decimal Money
        {
            get => this.money;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }

                this.money = value;
            }
        }

        public IReadOnlyCollection<Product> Products
        {
            get => this.products;
        }
        
        public void AddProduct(Product product)
        {
            //bool canAfford = this.Money - product.Cost >= this.Money;

            //if (canAfford)
            //{
            //    this.products.Add(product);
            //}

            this.Money -= product.Cost;
            this.products.Add(product);
        }
    }
}
