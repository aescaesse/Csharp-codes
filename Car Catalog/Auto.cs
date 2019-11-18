using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsCatalog
{
    public class Cars
    {
        
        private int id;
        private string brand;
        private string model;
        private int year;
        private int engingecapacity;
        private int mileage;
        private string transmission;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public int EngineCapacity
        {
            get { return engingecapacity; }
            set { engingecapacity = value; }
        }
        public int Mileage
        {
            get { return mileage; }
            set { mileage = value; }
        }
        public string Transmission
        {
            get { return transmission; }
            set { transmission = value; }
        }
        public Cars()
        {

        }

        public Cars(int id, string brand, string model, int year, int engingecapacity, int mileage, string transmission)
        {
            this.Id = id;
            this.Brand = brand;
            this.Model = model;
            this.Year = year;
            this.EngineCapacity = engingecapacity;
            this.Mileage = mileage;
            this.Transmission = transmission;
        }

        public override string ToString()
        {
            return string.Format("{0,-2}  {1,-16}{2,-16}{3,-9}{4,-13}{5,-16}{6,-10}", Id, Brand, Model, Year, EngineCapacity, Mileage, Transmission); 
        }
        
        public virtual void AddCar()
        {
            Console.Write("Brand: ");
            brand = Console.ReadLine();
            Console.Write("Model: ");
            model = Console.ReadLine();
            Console.Write("Year: ");
            int.TryParse(Console.ReadLine(), out int h);
            year = h;
            Console.Write("Engine capacity: ");
            int.TryParse(Console.ReadLine(), out h);
            engingecapacity = h;
            Console.Write("Mileage: ");
            int.TryParse(Console.ReadLine(), out h);
            mileage = h;
            Console.Write("Transmission: ");
            transmission = Console.ReadLine();
        }  
    }
}
