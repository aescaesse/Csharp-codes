using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;

namespace CarsCatalog
{
    public class Program
    {
        public static void DrawHeaders()
        {
            Console.WriteLine("ID  Brand \t    Model \t    Year     Engine Cap.  Mileage \t  Transmission");
        }
        public static bool CheckIndex(int id, List<Cars> cars)
        {
            if (id < 1 || id > cars.Count)
                return false;
            else
                return true;
        }
        static void Main()
        {
            int option;
            bool loop = true;
            int ile = 0;
            string FileToLoadDestination;
            var cars = new List<Cars>();
            Cars AddNewCar = new Cars();
            Console.WriteLine("\t\tCars database, Will Smith");
            while (loop)
            {
                Console.WriteLine("\t+-------------------------------------+");
                Console.WriteLine("1. Load cars from file \t 2. Show all cars \t 3. Sort cars");
                Console.WriteLine("4. Find specific cars \t 5. Show according by \t 6. Add new car");
                Console.WriteLine("7. Delete car \t 8. Clear Window ");
                Console.WriteLine("Select option: ");
                Console.Write("> ");
                int.TryParse(Console.ReadLine(), out int h);
                option = h;
                switch (option)
                {
                    case 1:
                        FileToLoadDestination = "Cars.txt";
                        try
                        {
                            using (StreamReader FileWithCars = new StreamReader(FileToLoadDestination))
                            {
                                string line;
                               
                                int index = 0, NewCars = 0;
                                while ((line = FileWithCars.ReadLine()) != null)
                                {
                                    index++;
                                    switch (index)
                                    {
                                        case 1: AddNewCar.Brand = line; AddNewCar.Id = cars.Count + 1; break;
                                        case 2: AddNewCar.Model = line; break;
                                        case 3: AddNewCar.Year = Int32.Parse(line); break;
                                        case 4: AddNewCar.EngineCapacity = Int32.Parse(line); break;
                                        case 5: AddNewCar.Mileage = Int32.Parse(line); break;
                                        case 6: AddNewCar.Transmission = line; break;
                                    }

                                    if (line == "" && index > 0)
                                    {
                                        cars.Add(AddNewCar);
                                        NewCars++;
                                        index = 0;
                                        AddNewCar = new Cars();
                                    }
                                }
                                if (index > 0)
                                {
                                    cars.Add(AddNewCar);
                                    NewCars++;
                                }
                                FileWithCars.Close();
                                Console.WriteLine("" + NewCars + " cars added.");
                            }

                        }
                        catch (IOException e)
                        {
                            Console.WriteLine("There is no file or file is broken." + e + "");
                        }
                        break;
                    case 2:

                        ile = cars.Count;
                        Console.WriteLine("You have [" + ile + "] cars.");
                        Console.WriteLine("\t+-------------------------------------+");
                        DrawHeaders();
                        foreach (Cars rekord in cars)
                        {
                            Console.WriteLine(rekord.ToString());
                        }
                        break;
                    case 3:
                        Console.WriteLine("Sort by: 1. Brand 2. Year 3. Mileage");
                        Console.Write("> ");
                        int.TryParse(Console.ReadLine(), out int choose);
                        while (choose < 1 || choose > 3)
                        {
                            Console.WriteLine("Wrong option.");
                            Console.Write("> ");
                            int.TryParse(Console.ReadLine(), out choose);
                        }
                        Console.WriteLine("\t+-------------------------------------+");
                        if (choose == 1)
                        {
                            cars.Sort((p, q) => p.Brand.CompareTo(q.Brand));
                        }
                        else if (choose == 2)
                        {
                            cars.Sort((p, q) => p.Year.CompareTo(q.Year));
                        }
                        else if (choose == 3)
                        {
                            cars.Sort((p, q) => p.Mileage.CompareTo(q.Mileage));

                        }

                        DrawHeaders();
                        foreach (Cars rekord in cars)
                        {
                            Console.WriteLine(rekord.ToString());
                        }

                        break;
                    case 4:
                        string brand = "", model = "", transmission = "";
                        int year = 0, enginecapacity = 0, mileage = 0;
                        int IfAny = 0, Header = 0;
                        Console.WriteLine("Provide data to search or press ENTER to skip current filter.");
                        Console.Write("Brand: ");
                        brand = Console.ReadLine();
                        Console.Write("Model: ");
                        model = Console.ReadLine();
                        Console.Write("Year: ");
                        int.TryParse(Console.ReadLine(), out int ToInt);
                        year = ToInt;
                        Console.Write("Engine capacity: ");
                        int.TryParse(Console.ReadLine(), out ToInt);
                        enginecapacity = ToInt;
                        Console.Write("Mileage: ");
                        int.TryParse(Console.ReadLine(), out ToInt);
                        mileage = ToInt;
                        Console.Write("Transmission: ");
                        transmission = Console.ReadLine();
                        Console.WriteLine("\t+-------------------------------------+");
                        foreach (Cars FoundCar in cars)
                        {
                            if (
                                    (FoundCar.Brand.Equals(brand) || brand.Equals("")) &&
                                    (FoundCar.Model.Equals(model) || model.Equals("")) &&
                                    (FoundCar.Year.Equals(year) || year.Equals(0)) &&
                                    (FoundCar.EngineCapacity.Equals(enginecapacity) || enginecapacity.Equals(0)) &&
                                    (FoundCar.Mileage.Equals(mileage) || mileage.Equals(0)) &&
                                    (FoundCar.Transmission.Equals(transmission) || transmission.Equals(""))
                                )
                            {

                                if (Header == 0)
                                {
                                    Header = 1;
                                    DrawHeaders();
                                }
                                    Console.WriteLine(FoundCar.ToString());
                                IfAny = 1;
                            }
                        }
                        if (IfAny == 0) Console.WriteLine("\t\t     Wrong filters");
                        break;
                    case 5:
                        string sign;
                        string[] Filter = new string[2];
                        Console.WriteLine("\t+-------------------------------------+");
                        Console.WriteLine("Find by: 1. Engine capacity 2. Year 3. Mileage");
                        Console.Write("> ");
                        int.TryParse(Console.ReadLine(), out int parametr);
                        Console.WriteLine("\t+-------------------------------------+");
                        switch (parametr)
                        {
                            case 1:
                                Console.WriteLine("Which capacity? eg. > 1600 lub < 2400");
                                sign = Console.ReadLine();
                                Array.Clear(Filter, 0, Filter.Length);
                                Filter = sign.Split(' ');
                                int.TryParse(Filter[1], out int FilterCapacity);
                                switch (Filter[0])
                                {
                                    case ">":
                                        DrawHeaders();
                                        foreach (Cars FoundCar in cars)
                                        {
                                            if (FoundCar.EngineCapacity >= FilterCapacity)
                                                Console.WriteLine(FoundCar.ToString());
                                        }
                                        break;
                                    case "<":
                                        DrawHeaders();
                                        foreach (Cars FoundCar in cars)
                                        {
                                            if (FoundCar.EngineCapacity <= FilterCapacity)
                                                Console.WriteLine(FoundCar.ToString());
                                        }
                                        break;
                                    case "=":
                                        Console.WriteLine("If you are looking for specific cars, go to option 4.");
                                        break;
                                    default:
                                        Console.WriteLine("Wrong operator.");
                                        break;
                                }

                                break;

                            case 2:
                                Console.WriteLine("\t+-------------------------------------+");
                                sign = "";
                                Console.WriteLine("Which year? eg. > 2003 lub < 2015");
                                sign = Console.ReadLine();
                                Filter = sign.Split(' ');
                                int.TryParse(Filter[1], out int FilterYear);
                                switch (Filter[0])
                                {
                                    case ">":
                                        DrawHeaders();
                                        foreach (Cars FoundCar in cars)
                                        {
                                            if (FoundCar.Year >= FilterYear)
                                                Console.WriteLine(FoundCar.ToString());
                                        }
                                        break;
                                    case "<":
                                        DrawHeaders();
                                        foreach (Cars FoundCar in cars)
                                        {
                                            if (FoundCar.Year <= FilterYear)
                                                Console.WriteLine(FoundCar.ToString());
                                        }
                                        break;
                                    case "=":
                                        Console.WriteLine("If you are looking for specific cars, go to option 4.");
                                        break;
                                    default:
                                        Console.WriteLine("Wrong operator");
                                        break;
                                }
                                break;
                            case 3:
                                Console.WriteLine("\t+-------------------------------------+");
                                sign = "";
                                Console.WriteLine("Which mileage? eg. > 200000 lub < 350000");
                                sign = Console.ReadLine();
                                Filter = sign.Split(' ');
                                int.TryParse(Filter[1], out int FilterMileage);
                                switch (Filter[0])
                                {
                                    case ">":
                                        DrawHeaders();
                                        foreach (Cars FoundCar in cars)
                                        {
                                            if (FoundCar.Mileage >= FilterMileage)
                                                Console.WriteLine(FoundCar.ToString());
                                        }
                                        break;
                                    case "<":
                                        DrawHeaders();
                                        foreach (Cars FoundCar in cars)
                                        {
                                            if (FoundCar.Mileage <= FilterMileage)
                                                Console.WriteLine(FoundCar.ToString());
                                        }
                                        break;
                                    case "=":
                                        Console.WriteLine("If you are looking for specific cars, go to option 4.");
                                        break;
                                    default:
                                        Console.WriteLine("Wrong operator");
                                        break;
                                }
                                break;
                        }
                        break;
                    case 6:
                        Console.WriteLine("\t+-------------------------------------+");
                        AddNewCar = new Cars();
                        AddNewCar.AddCar();
                        AddNewCar.Id = cars.Count + 1;
                        cars.Add(AddNewCar);
                        break;
                    case 7:
                        Console.WriteLine("\t+-------------------------------------+");
                        Console.WriteLine("Provide car`s ID to delete: ( or 0 to exit )");
                        Console.WriteLine("ID");
                        foreach (Cars rekord in cars)
                        {
                            Console.WriteLine(rekord.ToString());
                        }
                        Console.Write("> ");
                        Int32.TryParse(Console.ReadLine(), out int ID);
                        if (ID == 0) { break; }
                        while (!CheckIndex(ID, cars))
                        {
                            Console.WriteLine("Wrong ID.");
                            Console.Write("> ");
                            Int32.TryParse(Console.ReadLine(), out ID);
                            if (ID == 0) { break; }
                        }
                        Cars CarToRemove = cars.Single(x => x.Id == ID);
                        cars.Remove(CarToRemove);
                        int i = 1;
                        foreach (Cars CarByIndex in cars)
                        {
                            CarByIndex.Id = i;
                            i++;
                        }
                        break;
                    case 8:
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Wrong option.");
                        break;
                }
            }
        }
    }
}
