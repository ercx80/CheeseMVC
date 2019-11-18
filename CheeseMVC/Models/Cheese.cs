using System;
namespace CheeseMVC.Models
{
    public class Cheese
    {
        public string  Name { get; set; }
        public string Description { get; set; }
        public int CheeseId { get; set; }
        private static int nextId = 1;

       /* public Cheese(string name, string description)//this constructor is used to initialize the objects
        {
            Name = name;
            Description = description;
        }*/
        public Cheese()// this is a default constructor
        {
            CheeseId = nextId;
            nextId++;
        }
    }
}
