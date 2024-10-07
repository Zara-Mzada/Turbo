using System;
using System.Collections;
using System.Text.RegularExpressions;

namespace Turbo.az
{
    class Program
    {
        static void Main(string[] args)
        {
            CarController carController = new CarController();
            TruckController truckController = new TruckController();
            MotoController motoController = new MotoController();
            UserController userController = new UserController();
            
            // Users
            User user1 = new User("Zahra", "Malikzada", "zahra@gmail.com", "z1234");
            User user2 = new User("Madina", "Quliyeva", "madina@gmail.com", "m1234");
            User user3 = new User("Mirvari", "Muradova", "mirvari@gmail.com", "mir1234");
            User user4 = new User("Roya", "Abbasova", "roya@gmail.com", "r1234");

            userController.Users.Add(user1);
            userController.Users.Add(user2);
            userController.Users.Add(user3);
            userController.Users.Add(user4);
            
            // Cars
            Car car1 = new Car("Mercedes", "E23", 1234, 10000);
            Car car2 = new Car("Lexus", "RX 350h", 0, 128418);
            Car car3 = new Car("Toyoto", "Carolla", 340000, 14500);
            Car car4 = new Car("Audi", "Q7", 95000, 65450);
            
            carController.AddVehicle(car1);
            carController.AddVehicle(car2);
            carController.AddVehicle(car3);
            carController.AddVehicle(car4);
            
            // Motos
            Moto moto1 = new Moto("BMW", "bm12", 25000, 12000);
            Moto moto2 = new Moto("Mercedes", "moped", 20100, 10000);
            Moto moto3 = new Moto("Audi", "f4", 200000, 8000);
            Moto moto4 = new Moto("Ducati", "D23", 34000, 11500);
            
            motoController.AddVehicle(moto1);
            motoController.AddVehicle(moto2);
            motoController.AddVehicle(moto3);
            motoController.AddVehicle(moto4);
            
            // Truck
            Truck truck1 = new Truck("Ford", "Ranger", 245000, 30000);
            Truck truck2 = new Truck("Mercedes", "GLC", 50000, 96220);
            Truck truck3 = new Truck("Shachman", "F3000", 800000, 55000);
            Truck truck4 = new Truck("Ford", "Transit", 158000, 32500);
            
            truckController.AddVehicle(truck1);
            truckController.AddVehicle(truck2);
            truckController.AddVehicle(truck3);
            truckController.AddVehicle(truck4);
// =======================================================================================================================================
            
            // Regexs
            string regex = "^[A-Za-z]+$";
            
            ReStart:
            Console.Write("Welcome Turbo.az! Are you User or Guest (U/G): ");

            string role = Console.ReadLine();
            if (role == "u" || role == "U")
            {
                ReSignIn:
                Console.Write("Please, sign in!\n" +
                                  "Enter your mail: ");
                string mail = Console.ReadLine();
                Console.Write("Enter your password: ");
                string password = Console.ReadLine();

                bool isSignTrue = userController.SignIn(mail, password);

                if (isSignTrue)
                {
                    ReChoose:
                    Console.Write("What dou you want to do:\n" +
                                      "1. Add vehicle\n" +
                                      "2. Update vehicle\n" +
                                      "3. Remove vehicle\n" +
                                      "4. See vehicles\n" +
                                      "5. Filter\n" +
                                      "6. Exit\n" +
                                      "Enter a number of variant: ");
                    string choice = Console.ReadLine();
                    if (choice == "1")
                    {
                        ReCategory:
                        Console.Write("Which category do you want to add:\n" +
                                      "1. Car\n" +
                                      "2. Moto\n" +
                                      "3. Truck\n" +
                                      "Enter your choice: ");
                        string catChoice = Console.ReadLine();
                        if (catChoice == "1")
                        {
                            ReBrand:
                            Console.Write("Enter car brand: ");
                            string brand = Console.ReadLine();
                            Console.WriteLine("Enter car model: ");
                            string model = Console.ReadLine();

                            if (Regex.IsMatch(brand, regex) && Regex.IsMatch(model, regex))
                            {
                                ReMile:
                                Console.WriteLine("Enter car mileage: ");
                                var mile = Console.ReadLine();
                                decimal a;
                                bool checkMileage = decimal.TryParse(mile, out a);
                                decimal mileage;

                                if (checkMileage)
                                {
                                    mileage = Convert.ToDecimal(mile);
                                }
                                else
                                {
                                    Console.WriteLine("It is not decimal number! Enter again");
                                    goto ReMile;
                                }
                                
                                RePrice:
                                Console.WriteLine("Enter car price: ");
                                var consolePrice = Console.ReadLine();
                                bool checkPrice = decimal.TryParse(consolePrice, out a);
                                decimal price;

                                if (checkPrice)
                                {
                                    price = Convert.ToDecimal(consolePrice);
                                }
                                else
                                {
                                    Console.WriteLine("It is not decimal number! Enter again");
                                    goto RePrice;
                                }
                                
                                carController.AddVehicle(new Car(brand, model, mileage, price));
                                carController.ShowVehicles();
                                goto ReChoose;
                            }
                            else
                            {
                                Console.WriteLine("Wrong format of brand or model! Enter again");
                                goto ReBrand;
                            }
                        }
                        else if (catChoice == "2")
                        {
                            ReBrand:
                            Console.Write("Enter moto brand: ");
                            string brand = Console.ReadLine();
                            Console.WriteLine("Enter moto model: ");
                            string model = Console.ReadLine();

                            if (Regex.IsMatch(brand, regex) && Regex.IsMatch(model, regex))
                            {
                                ReMile:
                                Console.WriteLine("Enter moto mileage: ");
                                var mile = Console.ReadLine();
                                decimal a;
                                bool checkMileage = decimal.TryParse(mile, out a);
                                decimal mileage;

                                if (checkMileage)
                                {
                                    mileage = Convert.ToDecimal(mile);
                                }
                                else
                                {
                                    Console.WriteLine("It is not decimal number! Enter again");
                                    goto ReMile;
                                }
                                
                                RePrice:
                                Console.WriteLine("Enter moto price: ");
                                var consolePrice = Console.ReadLine();
                                bool checkPrice = decimal.TryParse(consolePrice, out a);
                                decimal price;
                                if (checkPrice)
                                {
                                    price = Convert.ToDecimal(consolePrice);
                                }
                                else
                                {
                                    Console.WriteLine("It is not decimal number! Enter again");
                                    goto RePrice;
                                }
                                
                                motoController.AddVehicle(new Moto(brand, model, mileage, price));
                                motoController.ShowVehicles();
                                goto ReChoose;
                            }
                            else
                            {
                                Console.WriteLine("Wrong format of brand or model! Enter again");
                                goto ReBrand;
                            }
                        }
                        else if (catChoice == "3")
                        {
                            ReBrand:
                            Console.Write("Enter truck brand: ");
                            string brand = Console.ReadLine();
                            Console.WriteLine("Enter truck model: ");
                            string model = Console.ReadLine();

                            if (Regex.IsMatch(brand, regex) && Regex.IsMatch(model, regex))
                            {
                                ReMile:
                                Console.WriteLine("Enter truck mileage: ");
                                var mile = Console.ReadLine();
                                decimal a;
                                bool checkMileage = decimal.TryParse(mile, out a);
                                decimal mileage;

                                if (checkMileage)
                                {
                                    mileage = Convert.ToDecimal(mile);
                                }
                                else
                                {
                                    Console.WriteLine("It is not decimal number! Enter again");
                                    goto ReMile;
                                }
                                
                                RePrice:
                                Console.WriteLine("Enter truck price: ");
                                var consolePrice = Console.ReadLine();
                                bool checkPrice = decimal.TryParse(consolePrice, out a);
                                decimal price;
                                if (checkPrice)
                                {
                                    price = Convert.ToDecimal(consolePrice);
                                }
                                else
                                {
                                    Console.WriteLine("It is not decimal number! Enter again");
                                    goto RePrice;
                                }
                                
                                truckController.AddVehicle(new Truck(brand, model, mileage, price));
                                truckController.ShowVehicles();
                                goto ReChoose;
                            }
                            else
                            {
                                Console.WriteLine("Wrong format of brand or model! Enter again");
                                goto ReBrand;
                            }
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Wrong choice! Enter again");
                            goto ReCategory;
                        }
                    }
                    else if (choice == "2")
                    {
                        Console.Clear();
                        ReCategory:
                        Console.Write("Which category do you want to update:\n" +
                                          "1. Car\n" +
                                          "2. Moto\n" +
                                          "3. Truck\n" +
                                          "Enter your choice: ");
                        string catChoice = Console.ReadLine();
                        if (catChoice == "1")
                        {
                            ReProp:
                            Console.Write("Which property do you want to update:\n" +
                                              "1. Brand\n" +
                                              "2. Model\n" +
                                              "3. Mileage\n" +
                                              "4. Price\n" +
                                              "Enter your chocie: ");
                            string propChoice = Console.ReadLine();
                            if (propChoice == "1")
                            {
                                ReID:
                                Console.WriteLine("CARS");
                                carController.ShowVehicles();
                                
                                Console.Write("Give me product id and new brand name: \n" +
                                                  "ID: ");
                                var ConsoleCarID = Console.ReadLine();
                                int b;
                                bool checkID = int.TryParse(ConsoleCarID, out b);
                                int carID;
                                if (checkID)
                                {
                                    carID = Convert.ToInt32(ConsoleCarID);
                                    if (carID <= carController.Cars.Count && carID>0)
                                    {
                                        ReBrand:
                                        Console.Write("New brand: ");
                                        string brand = Console.ReadLine();
                                        if (Regex.IsMatch(brand, regex))
                                        {
                                            carController.UpdateVehicleByBrand(carID, brand);
                                            carController.ShowVehicles();
                                            goto ReChoose;
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Brand can't be this type! Enter again");
                                            goto ReBrand;
                                        }
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("There is not this id! Enter again");
                                        goto ReID;
                                    }
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("It is not number! Enter again");
                                    goto ReID;
                                }
                            }
                            else if (propChoice == "2")
                            {
                                ReID:
                                Console.WriteLine("CARS");
                                carController.ShowVehicles();
                                
                                Console.Write("Give me product id and new model name: \n" +
                                                  "ID: ");
                                var ConsoleCarID = Console.ReadLine();
                                int b;
                                bool checkID = int.TryParse(ConsoleCarID, out b);
                                int carID;
                                if (checkID)
                                {
                                    carID = Convert.ToInt32(ConsoleCarID);
                                    if (carID <= carController.Cars.Count && carID>0)
                                    {
                                        ReBrand:
                                        Console.Write("New model: ");
                                        string model = Console.ReadLine();
                                        carController.UpdateVehicleByModel(carID, model);
                                        carController.ShowVehicles();
                                        goto ReChoose;
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("There is not this id! Enter again");
                                        goto ReID;
                                    }
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("It is not number! Enter again");
                                    goto ReID;
                                }
                            }
                            else if (propChoice == "3")
                            {
                                ReID:
                                Console.WriteLine("CARS");
                                carController.ShowVehicles();
                                
                                Console.Write("Give me product id and new mileage: \n" +
                                                  "ID: ");
                                var ConsoleCarID = Console.ReadLine();
                                int b;
                                bool checkID = int.TryParse(ConsoleCarID, out b);
                                int carID;
                                if (checkID)
                                {
                                    carID = Convert.ToInt32(ConsoleCarID);
                                    if (carID <= carController.Cars.Count && carID>0)
                                    {
                                        ReBrand:
                                        Console.Write("New mileage: ");
                                        var mile = Console.ReadLine();
                                        decimal a;
                                        bool checkMile = decimal.TryParse(mile, out a);
                                        decimal newMileage;
                                        if (checkMile)
                                        {
                                            newMileage = Convert.ToDecimal(mile);
                                            carController.UpdateVehicleByMileage(carID, newMileage);
                                            carController.ShowVehicles();
                                            goto ReChoose;
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Mileage can't be this type! Enter again");
                                            goto ReBrand;
                                        }
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("There is not this id! Enter again");
                                        goto ReID;
                                    }
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("It is not number! Enter again");
                                    goto ReID;
                                }
                            }
                            else if (propChoice == "4")
                            {
                                ReID:
                                Console.WriteLine("CARS");
                                carController.ShowVehicles();
                                
                                Console.Write("Give me product id and new price: \n" +
                                                  "ID: ");
                                var ConsoleCarID = Console.ReadLine();
                                int b;
                                bool checkID = int.TryParse(ConsoleCarID, out b);
                                int carID;
                                if (checkID)
                                {
                                    carID = Convert.ToInt32(ConsoleCarID);
                                    if (carID <= carController.Cars.Count && carID>0)
                                    {
                                        ReBrand:
                                        Console.Write("New price: ");
                                        var consPrice = Console.ReadLine();
                                        decimal a;
                                        bool checkPrice = decimal.TryParse(consPrice, out a);
                                        decimal newPrice;
                                        if (checkPrice)
                                        {
                                            newPrice = Convert.ToDecimal(consPrice);
                                            carController.UpdateVehicleByMileage(carID, newPrice);
                                            carController.ShowVehicles();
                                            goto ReChoose;
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Price can't be this type! Enter again");
                                            goto ReBrand;
                                        }
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("There is not this id! Enter again");
                                        goto ReID;
                                    }
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("It is not number! Enter again");
                                    goto ReID;
                                }
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("There is not this variant! Enter again");
                                goto ReProp;
                            }
                        }
                        else if (catChoice == "2")
                        {
                            ReProp:
                            Console.Write("Which property do you want to update:" +
                                              "1. Brand\n" +
                                              "2. Model\n" +
                                              "3. Mileage\n" +
                                              "4. Price\n" +
                                              "Enter your chocie: ");
                            string propChoice = Console.ReadLine();
                            if (propChoice == "1")
                            {
                                ReID:
                                Console.WriteLine("MOTOS");
                                motoController.ShowVehicles();
                                
                                Console.Write("Give me product id and new brand name: \n" +
                                                  "ID: ");
                                var ConsoleMotoID = Console.ReadLine();
                                int b;
                                bool checkID = int.TryParse(ConsoleMotoID, out b);
                                int motoID;
                                if (checkID)
                                {
                                    motoID = Convert.ToInt32(ConsoleMotoID);
                                    if (motoID <= motoController.Motos.Count && motoID>0)
                                    {
                                        ReBrand:
                                        Console.Write("New brand: ");
                                        string brand = Console.ReadLine();
                                        if (Regex.IsMatch(brand, regex))
                                        {
                                            motoController.UpdateVehicleByBrand(motoID, brand);
                                            motoController.ShowVehicles();
                                            goto ReChoose;
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Brand can't be this type! Enter again");
                                            goto ReBrand;
                                        }
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("There is not this id! Enter again");
                                        goto ReID;
                                    }
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("It is not number! Enter again");
                                    goto ReID;
                                }
                            }
                            else if (propChoice == "2")
                            {
                                ReID:
                                Console.WriteLine("MOTOS");
                                motoController.ShowVehicles();
                                
                                Console.Write("Give me product id and new model name: \n" +
                                                  "ID: ");
                                var ConsoleMotoID = Console.ReadLine();
                                int b;
                                bool checkID = int.TryParse(ConsoleMotoID, out b);
                                int motoID;
                                if (checkID)
                                {
                                    motoID = Convert.ToInt32(ConsoleMotoID);
                                    if (motoID <= motoController.Motos.Count && motoID>0)
                                    {
                                        ReBrand:
                                        Console.Write("New model: ");
                                        string model = Console.ReadLine();
                                        motoController.UpdateVehicleByModel(motoID, model);
                                        motoController.ShowVehicles();
                                        goto ReChoose;
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("There is not this id! Enter again");
                                        goto ReID;
                                    }
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("It is not number! Enter again");
                                    goto ReID;
                                }
                            }
                            else if (propChoice == "3")
                            {
                                ReID:
                                Console.WriteLine("MOTOS");
                                motoController.ShowVehicles();
                                
                                Console.Write("Give me product id and new mileage: \n" +
                                                  "ID: ");
                                var ConsoleMotoID = Console.ReadLine();
                                int b;
                                bool checkID = int.TryParse(ConsoleMotoID, out b);
                                int motoID;
                                if (checkID)
                                {
                                    motoID = Convert.ToInt32(ConsoleMotoID);
                                    if (motoID <= motoController.Motos.Count && motoID>0)
                                    {
                                        ReBrand:
                                        Console.Write("New mileage: ");
                                        var mile = Console.ReadLine();
                                        decimal a;
                                        bool checkMile = decimal.TryParse(mile, out a);
                                        decimal newMileage;
                                        if (checkMile)
                                        {
                                            newMileage = Convert.ToDecimal(mile);
                                            motoController.UpdateVehicleByMileage(motoID, newMileage);
                                            motoController.ShowVehicles();
                                            goto ReChoose;
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Mileage can't be this type! Enter again");
                                            goto ReBrand;
                                        }
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("There is not this id! Enter again");
                                        goto ReID;
                                    }
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("It is not number! Enter again");
                                    goto ReID;
                                }
                            }
                            else if (propChoice == "4")
                            {
                                ReID:
                                Console.WriteLine("MOTOS");
                                motoController.ShowVehicles();
                                
                                Console.Write("Give me product id and new price: \n" +
                                                  "ID: ");
                                var ConsoleMotoID = Console.ReadLine();
                                int b;
                                bool checkID = int.TryParse(ConsoleMotoID, out b);
                                int motoID;
                                if (checkID)
                                {
                                    motoID = Convert.ToInt32(ConsoleMotoID);
                                    if (motoID <= motoController.Motos.Count && motoID>0)
                                    {
                                        ReBrand:
                                        Console.Write("New price: ");
                                        var consPrice = Console.ReadLine();
                                        decimal a;
                                        bool checkPrice = decimal.TryParse(consPrice, out a);
                                        decimal newPrice;
                                        if (checkPrice)
                                        {
                                            newPrice = Convert.ToDecimal(consPrice);
                                            motoController.UpdateVehicleByMileage(motoID, newPrice);
                                            motoController.ShowVehicles();
                                            goto ReChoose;
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Price can't be this type! Enter again");
                                            goto ReBrand;
                                        }
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("There is not this id! Enter again");
                                        goto ReID;
                                    }
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("It is not number! Enter again");
                                    goto ReID;
                                }
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("There is not this variant! Enter again");
                                goto ReProp;
                            }
                        }
                        else if (catChoice == "3")
                        {
                            ReProp:
                            Console.Write("Which property do you want to update:" +
                                              "1. Brand\n" +
                                              "2. Model\n" +
                                              "3. Mileage\n" +
                                              "4. Price\n" +
                                              "Enter your chocie: ");
                            string propChoice = Console.ReadLine();
                            if (propChoice == "1")
                            {
                                ReID:
                                Console.WriteLine("TRUCKS");
                                truckController.ShowVehicles();
                                
                                Console.Write("Give me product id and new brand name: \n" +
                                                  "ID: ");
                                var ConsoleTruckID = Console.ReadLine();
                                int b;
                                bool checkID = int.TryParse(ConsoleTruckID, out b);
                                int truckID;
                                if (checkID)
                                {
                                    truckID = Convert.ToInt32(ConsoleTruckID);
                                    if (truckID <= truckController.Trucks.Count && truckID>0)
                                    {
                                        ReBrand:
                                        Console.Write("New brand: ");
                                        string brand = Console.ReadLine();
                                        if (Regex.IsMatch(brand, regex))
                                        {
                                            truckController.UpdateVehicleByBrand(truckID, brand);
                                            truckController.ShowVehicles();
                                            goto ReChoose;
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Brand can't be this type! Enter again");
                                            goto ReBrand;
                                        }
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("There is not this id! Enter again");
                                        goto ReID;
                                    }
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("It is not number! Enter again");
                                    goto ReID;
                                }
                            }
                            else if (propChoice == "2")
                            {
                                ReID:
                                Console.WriteLine("TRUCKS");
                                truckController.ShowVehicles();
                                
                                Console.Write("Give me product id and new model name: \n" +
                                                  "ID: ");
                                var ConsoleTruckID = Console.ReadLine();
                                int b;
                                bool checkID = int.TryParse(ConsoleTruckID, out b);
                                int truckID;
                                if (checkID)
                                {
                                    truckID = Convert.ToInt32(ConsoleTruckID);
                                    if (truckID <= truckController.Trucks.Count && truckID>0)
                                    {
                                        ReBrand:
                                        Console.Write("New model: ");
                                        string model = Console.ReadLine();
                                        truckController.UpdateVehicleByModel(truckID, model);
                                        truckController.ShowVehicles();
                                        goto ReChoose;
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("There is not this id! Enter again");
                                        goto ReID;
                                    }
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("It is not number! Enter again");
                                    goto ReID;
                                }
                            }
                            else if (propChoice == "3")
                            {
                                ReID:
                                Console.WriteLine("TRUCKS");
                                truckController.ShowVehicles();
                                
                                Console.Write("Give me product id and new mileage: \n" +
                                                  "ID: ");
                                var ConsoleTruckID = Console.ReadLine();
                                int b;
                                bool checkID = int.TryParse(ConsoleTruckID, out b);
                                int truckID;
                                if (checkID)
                                {
                                    truckID = Convert.ToInt32(ConsoleTruckID);
                                    if (truckID <= truckController.Trucks.Count && truckID>0)
                                    {
                                        ReBrand:
                                        Console.Write("New mileage: ");
                                        var mile = Console.ReadLine();
                                        decimal a;
                                        bool checkMile = decimal.TryParse(mile, out a);
                                        decimal newMileage;
                                        if (checkMile)
                                        {
                                            newMileage = Convert.ToDecimal(mile);
                                            truckController.UpdateVehicleByMileage(truckID, newMileage);
                                            truckController.ShowVehicles();
                                            goto ReChoose;
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Mileage can't be this type! Enter again");
                                            goto ReBrand;
                                        }
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("There is not this id! Enter again");
                                        goto ReID;
                                    }
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("It is not number! Enter again");
                                    goto ReID;
                                }
                            }
                            else if (propChoice == "4")
                            {
                                ReID:
                                Console.WriteLine("TRUCKS");
                                truckController.ShowVehicles();
                                
                                Console.Write("Give me product id and new price: \n" +
                                                  "ID: ");
                                var ConsoleTruckID = Console.ReadLine();
                                int b;
                                bool checkID = int.TryParse(ConsoleTruckID, out b);
                                int truckID;
                                if (checkID)
                                {
                                    truckID = Convert.ToInt32(ConsoleTruckID);
                                    if (truckID <= truckController.Trucks.Count && truckID>0)
                                    {
                                        ReBrand:
                                        Console.Write("New price: ");
                                        var consPrice = Console.ReadLine();
                                        decimal a;
                                        bool checkPrice = decimal.TryParse(consPrice, out a);
                                        decimal newPrice;
                                        if (checkPrice)
                                        {
                                            newPrice = Convert.ToDecimal(consPrice);
                                            truckController.UpdateVehicleByMileage(truckID, newPrice);
                                            truckController.ShowVehicles();
                                            goto ReChoose;
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Price can't be this type! Enter again");
                                            goto ReBrand;
                                        }
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("There is not this id! Enter again");
                                        goto ReID;
                                    }
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("It is not number! Enter again");
                                    goto ReID;
                                }
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("There is not this variant! Enter again");
                                goto ReProp;
                            }
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("There is not this variant! Enter again");
                            goto ReCategory;
                        }
                    }
                    else if (choice == "3")
                    {
                        ReRemove:
                        Console.Write("From which category you want remove:\n" +
                                          "1. Car\n" +
                                          "2. Moto\n" +
                                          "3. Truck\n" +
                                          "Enter choice: ");
                        string remCategory = Console.ReadLine();
                        if (remCategory == "1")
                        {
                            ReID:
                            carController.ShowVehicles();
                            Console.Write("Which car do you want to remove, give me product id: ");
                            var remID = Console.ReadLine();
                            int a;
                            bool checkID = int.TryParse(remID, out a);
                            int id;
                            if (checkID)
                            {
                                id = Convert.ToInt32(remID);
                                if (id <= carController.Cars.Count && id>0)
                                {
                                    carController.RemoveVehicle(id);
                                    goto ReChoose;
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("This product doesn't exist! Enter again");
                                    goto ReID;
                                }
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("It is not integer number! Enter again"); 
                                goto ReID;
                            }
                        }
                        else if (remCategory == "2")
                        {
                            ReID:
                            motoController.ShowVehicles();
                            Console.Write("Which car do you want to remove, give me product id: ");
                            var remID = Console.ReadLine();
                            int a;
                            bool checkID = int.TryParse(remID, out a);
                            int id;
                            if (checkID)
                            {
                                id = Convert.ToInt32(remID);
                                if (id <= motoController.Motos.Count && id>0)
                                {
                                    motoController.RemoveVehicle(id);
                                    goto ReChoose;
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("This product doesn't exist! Enter again");
                                    goto ReID;
                                }
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("It is not integer number! Enter again"); 
                                goto ReID;
                            }
                        }
                        else if (remCategory == "3")
                        {
                            ReID:
                            truckController.ShowVehicles();
                            Console.Write("Which car do you want to remove, give me product id: ");
                            var remID = Console.ReadLine();
                            int a;
                            bool checkID = int.TryParse(remID, out a);
                            int id;
                            if (checkID)
                            {
                                id = Convert.ToInt32(remID);
                                if (id <= truckController.Trucks.Count && id>0)
                                {
                                    truckController.RemoveVehicle(id);
                                    goto ReChoose;
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("This product doesn't exist! Enter again");
                                    goto ReID;
                                }
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("It is not integer number! Enter again"); 
                                goto ReID;
                            }
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("There is not this variant! Enter again");
                            goto ReRemove;
                        }
                    }
                    else if (choice == "4")
                    {
                        ReSeeCat:
                        Console.Write("What do you want to see:\n" +
                                          "1. All vehicles\n" +
                                          "2. Only cars\n" +
                                          "3. Only motos\n" +
                                          "4. Only trucks\n" +
                                          "Enter your choice: ");
                        string seeCategory = Console.ReadLine();
                        if (seeCategory == "1")
                        {
                            Console.WriteLine("========= CARS =========");
                            carController.ShowVehicles();
                            Console.WriteLine("========= MOTOS =========");
                            motoController.ShowVehicles();
                            Console.WriteLine("========= TRUCKS =========");
                            truckController.ShowVehicles();
                            goto ReChoose;
                        }
                        else if (seeCategory == "2")
                        {
                            Console.WriteLine("========= CARS =========");
                            carController.ShowVehicles();
                            goto ReChoose;
                        }
                        else if (seeCategory == "3")
                        {
                            Console.WriteLine("========= MOTOS =========");
                            motoController.ShowVehicles();
                            goto ReChoose;
                        }
                        else if (seeCategory == "4")
                        {
                            Console.WriteLine("========= TRUCKS =========");
                            truckController.ShowVehicles(); 
                            goto ReChoose;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("There is not this variant! Enter again");
                            goto ReSeeCat;
                        }
                    }
                    else if (choice == "5")
                    {
                        ReFilter:
                    Console.Write("Choose filter:\n" +
                                      "1. Search by brand\n" +
                                      "2. Search by model\n" +
                                      "3. Search by price \n" +
                                      "4. Search by mileage\n" +
                                      "Enter variant: ");
                    string filterChoice = Console.ReadLine();
                    if (filterChoice == "1")
                    {
                        Console.Write("Enter brand name: ");
                        string brand = Console.ReadLine();
                        Filter.SearchByBrand(carController.Cars, brand);
                        Filter.SearchByBrand(motoController.Motos, brand);
                        Filter.SearchByBrand(truckController.Trucks, brand);
                        goto ReFilter;
                    }
                    else if (filterChoice == "2")
                    {
                        Console.Write("Enter model name: ");
                        string model = Console.ReadLine();
                        Filter.SearchByModel(carController.Cars, model);
                        Filter.SearchByModel(motoController.Motos, model);
                        Filter.SearchByModel(truckController.Trucks, model);
                        goto ReFilter;
                    }
                    else if (filterChoice == "3")
                    {
                        RePrice:
                        Console.Write("Enter minimum price: ");
                        var minCon = Console.ReadLine();
                        decimal a;
                        bool checkMin = decimal.TryParse(minCon, out a);
                        decimal minPrice;

                        Console.Write("Enter maximum price: ");
                        var maxCon = Console.ReadLine();
                        bool checkMax = decimal.TryParse(maxCon, out a);
                        decimal maxPrice;

                        if (checkMax && checkMin)
                        {
                            minPrice = Convert.ToDecimal(minCon);
                            maxPrice = Convert.ToDecimal(maxCon);
                            if (minPrice > 0 && maxPrice > 0 && minPrice < maxPrice)
                            {
                                Filter.SearchByPrice(carController.Cars, minPrice, maxPrice);
                                Filter.SearchByPrice(motoController.Motos, minPrice, maxPrice);
                                Filter.SearchByPrice(truckController.Trucks, minPrice, maxPrice);
                                goto ReFilter;
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Wrong price type! Enter again");
                                goto RePrice;
                            }
                            
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("It is not number! Enter again");
                            goto RePrice;
                        }
                    }
                    else if (filterChoice == "4")
                    {
                        ReMileage:
                        Console.Write("Enter minimum mileage: ");
                        var minCon = Console.ReadLine();
                        decimal a;
                        bool checkMin = decimal.TryParse(minCon, out a);
                        decimal minMileage;

                        Console.Write("Enter maximum mileage: ");
                        var maxCon = Console.ReadLine();
                        bool checkMax = decimal.TryParse(maxCon, out a);
                        decimal maxMileage;

                        if (checkMax && checkMin)
                        {
                            minMileage = Convert.ToDecimal(minCon);
                            maxMileage = Convert.ToDecimal(maxCon);
                            if (minMileage > 0 && maxMileage > 0 && minMileage < maxMileage)
                            {
                                Filter.SearchByPrice(carController.Cars, minMileage, maxMileage);
                                Filter.SearchByPrice(motoController.Motos, minMileage, maxMileage);
                                Filter.SearchByPrice(truckController.Trucks, minMileage, maxMileage);
                                goto ReFilter;
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Wrong mileage type! Enter again");
                                goto ReMileage;
                            }
                            
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("It is not number! Enter again");
                            goto ReMileage;
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("There is not this variant! Enter again");
                        goto ReFilter;
                    }
                    }
                    else if (choice == "6")
                    {
                        Console.Clear();
                        Console.WriteLine("Process finished...");
                    }
                    else
                    {
                        Console.WriteLine("There is not this variant! Enter again");
                        goto ReChoose;
                    }
                }
                else
                {
                    Console.WriteLine("Wrong password or email! Enter again");
                    goto ReSignIn;
                }
                
            }
            else if (role == "g" || role == "G")
            {
                ReSignUp:
                Console.Write("Do you want to sign up?(y/n): ");
                string guestanswer = Console.ReadLine();
                if (guestanswer == "y" || guestanswer == "Y")
                {
                    Console.Write("Enter your name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter your surname: ");
                    string surname = Console.ReadLine();
                    if (Regex.IsMatch(name, regex) && Regex.IsMatch(surname, regex))
                    {
                        Console.Write("Enter your email: ");
                        string email = Console.ReadLine();
                        RePass:
                        Console.Write("Enter your password: ");
                        string password = Console.ReadLine();
                        Console.Write("Confirm password: ");
                        string confirmPass = Console.ReadLine();

                        if (password == confirmPass)
                        {
                            User user = new User(name, surname, email, password);
                            userController.SignUp(user);
                            goto ReStart;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Passwords don't match! Enter again");
                            goto RePass;
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Name and surname must contains only letters! Enter again");
                        goto ReSignUp;
                    }
                }
                else if (guestanswer == "n" || guestanswer == "N")
                {
                    goto ReGuestChoice;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Wrong choice! Enter again");
                    goto ReSignUp;
                }
                ReGuestChoice:
                Console.WriteLine("What do you want to do:\n" +
                                  "1. See all vehicles\n" +
                                  "2. Use filters");
                string guestChoice = Console.ReadLine();
                if (guestChoice == "1")
                {
                    Console.WriteLine("============== CARS ==============");
                    carController.ShowVehicles();
                    Console.WriteLine("============== MOTOS ==============");
                    motoController.ShowVehicles();
                    Console.WriteLine("============== TRUCKS ==============");
                    truckController.ShowVehicles();
                    goto ReGuestChoice;
                }
                else if (guestChoice == "2")
                {
                    ReFilter:
                    Console.Write("Choose filter:\n" +
                                      "1. Search by brand\n" +
                                      "2. Search by model\n" +
                                      "3. Search by price \n" +
                                      "4. Search by mileage\n" +
                                      "Enter variant: ");
                    string filterChoice = Console.ReadLine();
                    if (filterChoice == "1")
                    {
                        Console.Write("Enter brand name: ");
                        string brand = Console.ReadLine();
                        Filter.SearchByBrand(carController.Cars, brand);
                        Filter.SearchByBrand(motoController.Motos, brand);
                        Filter.SearchByBrand(truckController.Trucks, brand);
                        goto ReGuestChoice;
                    }
                    else if (filterChoice == "2")
                    {
                        Console.Write("Enter model name: ");
                        string model = Console.ReadLine();
                        Filter.SearchByModel(carController.Cars, model);
                        Filter.SearchByModel(motoController.Motos, model);
                        Filter.SearchByModel(truckController.Trucks, model);
                        goto ReGuestChoice;
                    }
                    else if (filterChoice == "3")
                    {
                        RePrice:
                        Console.Write("Enter minimum price: ");
                        var minCon = Console.ReadLine();
                        decimal a;
                        bool checkMin = decimal.TryParse(minCon, out a);
                        decimal minPrice;

                        Console.Write("Enter maximum price: ");
                        var maxCon = Console.ReadLine();
                        bool checkMax = decimal.TryParse(maxCon, out a);
                        decimal maxPrice;

                        if (checkMax && checkMin)
                        {
                            minPrice = Convert.ToDecimal(minCon);
                            maxPrice = Convert.ToDecimal(maxCon);
                            if (minPrice > 0 && maxPrice > 0 && minPrice < maxPrice)
                            {
                                Filter.SearchByPrice(carController.Cars, minPrice, maxPrice);
                                Filter.SearchByPrice(motoController.Motos, minPrice, maxPrice);
                                Filter.SearchByPrice(truckController.Trucks, minPrice, maxPrice);
                                goto ReGuestChoice;
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Wrong price type! Enter again");
                                goto RePrice;
                            }
                            
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("It is not number! Enter again");
                            goto RePrice;
                        }
                    }
                    else if (filterChoice == "4")
                    {
                        ReMileage:
                        Console.Write("Enter minimum mileage: ");
                        var minCon = Console.ReadLine();
                        decimal a;
                        bool checkMin = decimal.TryParse(minCon, out a);
                        decimal minMileage;

                        Console.Write("Enter maximum mileage: ");
                        var maxCon = Console.ReadLine();
                        bool checkMax = decimal.TryParse(maxCon, out a);
                        decimal maxMileage;

                        if (checkMax && checkMin)
                        {
                            minMileage = Convert.ToDecimal(minCon);
                            maxMileage = Convert.ToDecimal(maxCon);
                            if (minMileage > 0 && maxMileage > 0 && minMileage < maxMileage)
                            {
                                Filter.SearchByPrice(carController.Cars, minMileage, maxMileage);
                                Filter.SearchByPrice(motoController.Motos, minMileage, maxMileage);
                                Filter.SearchByPrice(truckController.Trucks, minMileage, maxMileage);
                                goto ReGuestChoice;
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Wrong mileage type! Enter again");
                                goto ReMileage;
                            }
                            
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("It is not number! Enter again");
                            goto ReMileage;
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("There is not this variant! Enter again");
                        goto ReFilter;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("There is not this variant! Enter again");
                    goto ReGuestChoice;
                }
            }
            else
            {
                Console.WriteLine("Wrong choice! Enter again");
                goto ReStart;
            }
        }
    }
}