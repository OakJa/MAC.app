using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAC.app
{
    internal class Item
    {
        int BlackCoffee;
        int Mocca;
        int Latte;
        int Chocolate;
        int Water;
        int Coffee;
        int ChocolatePowder;
        int Milk;

        

        // คอนสตรักเตอร์ที่ถูกต้อง
        public Item(int blackCoffee, int mocca, int latte, int chocolate,
                              int water, int coffee, int chocolatePowder, int milk)
        {
            this.BlackCoffee = blackCoffee;
            this.Mocca = mocca;
            this.Latte = latte;
            this.Chocolate = chocolate;
            this.Water = water;
            this.Coffee = coffee;
            this.ChocolatePowder = chocolatePowder;
            this.Milk = milk;


        }

        public bool BuyBlackCoffee(int amount)
        {
            if (Water >= 300 * amount && Coffee >= 20 * amount)
            {
                Water -= 300 * amount;
                Coffee -= 20 * amount;
                BlackCoffee += amount;
                Console.WriteLine("Black Coffee: " + BlackCoffee);
                return true;
            }
            return false;
        }

        public bool BuyMoccaCoffee(int amount)
        {
            if (Water >= 300 * amount && Coffee >= 20 * amount && ChocolatePowder >= 10 * amount)
            {
                Water -= 300 * amount;
                Coffee -= 20 * amount;
                ChocolatePowder -= 10 * amount;
                Mocca += amount;
                Console.WriteLine("Mocca: " + Mocca);
                return true;
            }
            return false;
        }

        public bool BuyLatteCoffee(int amount)
        {
            if (Water >= 300 * amount && Coffee >= 20 * amount && Milk >= 10 * amount)
            {
                Water -= 300 * amount;
                Coffee -= 20 * amount;
                Milk -= 10 * amount;
                Latte += amount;
                Console.WriteLine("Latte: " + Latte);
                return true;
            }
            return false;
        }

        public bool BuyChocolate(int amount)
        {
            if (Water >= 300 * amount && ChocolatePowder >= 20 * amount)
            {
                Water -= 300 * amount;
                ChocolatePowder -= 20 * amount;
                Chocolate += amount;
                Console.WriteLine("Chocolate: " + Chocolate);
                return true;
            }
            return false;
        }

      

        public void IncreaseStock(int blackCoffee, int mocca, int latte, int chocolate,
                                  int water, int coffee, int chocolatePowder, int milk)
        {
            

                BlackCoffee += blackCoffee;
                Mocca += mocca;
                Latte += latte;
                Chocolate += chocolate;
                Water += water;
                Coffee += coffee;
                ChocolatePowder += chocolatePowder;
                Milk += milk;
           
        }

        public string GetStockInfo()
        {
            return $"วัถุดิบในเครื่อง\n" +
                   $"--------------\n" +
                   $"Stok update\n"+
                   
                   $"Water: {Water}\n" +
                   $"Coffee: {Coffee}\n" +
                   $"Chocolate Powder: {ChocolatePowder}\n" +
                   $"Milk: {Milk}";
        }

        public int GetBlackCoffeeStock()
        {
            return BlackCoffee;
        }

        public int GetMoccaStock()
        {
            return Mocca;
        }

        public int GetLatteStock()
        {
            return Latte;
        }

        public int GetChocolateStock()
        {
            return Chocolate;
        }

    }
}