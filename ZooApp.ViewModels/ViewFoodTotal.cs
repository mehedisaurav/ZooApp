﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooApp.Models.Migrations;
using AnimalFood = ZooApp.Models.AnimalFood;

namespace ZooApp.ViewModels
{
   public class ViewFoodTotal
    {

        public ViewFoodTotal()
        {
            
        }
        public ViewFoodTotal(AnimalFood animalFood)
        {
            FoodName = animalFood.Food.Name;
            FoodPrice = animalFood.Food.Price;
            TotalQuantity = animalFood.Animal.Quantity*animalFood.Quantity;
            TotalPrice = FoodPrice*TotalQuantity;
            FoodId = animalFood.FoodId;
            Id = animalFood.Id;
        }

        public int Id { get; set; }
        public int FoodId { get; set; }
        public double TotalPrice { get; set; }

        public double TotalQuantity { get; set; }

        public double FoodPrice { get; set; }

        public string FoodName { get; set; }
    }
}
