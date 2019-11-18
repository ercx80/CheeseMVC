using System;
using System.Collections.Generic;
using System.Linq;
namespace CheeseMVC.Models
    
{
    public class CheeseData
    {
        static private List<Cheese> cheeses = new List<Cheese>();
        //Get all method
        public static List<Cheese>GetAll()
        {
            return cheeses;
        }
        //add method
        public static void Add(Cheese newCheese)
        {
            cheeses.Add(newCheese);
        }
        //remove meethod
        public static void Remove(int id)
        {
            Cheese cheeseToRemove = GetById(id);
            cheeses.Remove(cheeseToRemove);
        }
        //get  ID method
        public static Cheese GetById(int id)
        {
            return cheeses.Single(x => x.CheeseId == id);
        }
    }
}
