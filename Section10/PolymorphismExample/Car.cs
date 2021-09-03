using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExample
{
    class Car
    {
        public int HP { get; set; }
        public string Color { get; set; }

        // Has a relationship
        protected CarIDInfo carIDInfo = new CarIDInfo();

        public void SetCarIDInfo(int idNum, string owner)
        {
            carIDInfo.IDNum = idNum;
            carIDInfo.Owner = owner;
        }

        public void GetCarIDInfo()
        {
            Console.WriteLine("The car has the ID of {0} and is owned by {1}", carIDInfo.IDNum, carIDInfo.Owner);
        }

        public Car(int hp, string color)
        {
            this.HP = hp;
            this.Color = color;
        }

        // Default constructor
        public Car()
        {

        }

        public void ShowDetails()
        {
            Console.WriteLine("HP: " + HP + " color:" + Color);
        }

        public  virtual void Repair()
        {
            Console.WriteLine("Car was repaired");
        }

    }
}
