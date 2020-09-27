using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_1
{
    class Task14
    {
        public string BiggestBuildings(Building[] buildings)
        {
            string adresses = "";
            Node<Building> currentObj = new Node<Building>(buildings[0]);
            Node <Building> maxBuildingsNode = currentObj;
            int maxCount = 0;
            foreach (var building in buildings)
            {
                int LargeCounter = 0;
                foreach (var apartment in building.Apartments)
                {
                    if (apartment.GetCategory() == "large")
                    {
                        LargeCounter++;
                    }
                }
                if (LargeCounter >= maxCount)
                {
                    if (LargeCounter == maxCount)
                    {
                        currentObj.SetNext(new Node<Building>(building));
                        currentObj = currentObj.GetNext();

                    }
                    else
                    {
                        currentObj = new Node<Building>(building);
                        maxBuildingsNode = currentObj;
                    }
                    maxCount = LargeCounter;
                }
            }
            adresses += $"Addresses:\n";
            while (maxBuildingsNode != null)
            {
                adresses += $"address: {maxBuildingsNode.GetValue().Address},  Owners: ";
                foreach (var apartment in maxBuildingsNode.GetValue().Apartments)
                {
                    if (apartment.GetCategory() == "large")
                    {
                        adresses += $"{apartment.Owner},";
                    }
                }
                maxBuildingsNode = maxBuildingsNode.GetNext();
                adresses += "\n";
            }

            return adresses;
        }

        public class Address
        {
            public string Street { get; set; }
            public string City { get; set; }
            public int Number { get; set; }

            public Address(string street, string city, int number)
            {
                Street = street;
                City = city;
                Number = number;
            }

            public override string ToString()
            {
                return $"City: {City}, Street: {Street}, Number: {Number}";
            }
        }

        public class Building
        {
            public Apartment[] Apartments { get; set; }

            public Address Address { get; set; }

            public Building(Apartment[] apartments, Address address)
            {
                Apartments = apartments;
                Address = address;
            }

            public override string ToString()
            {
                int count = 1;
                string finalString = $"Address: {Address} Apartments:\n";
                foreach (var apartment in Apartments)
                {
                    finalString += $"{count}: {apartment.ToString()}\n";
                }
                return finalString;
            }
        }

        public class Apartment
        {
            public string Owner { get; set; }
            public Room[] Rooms { get; set; }

            public Apartment(string owner, Room[] rooms)
            {
                Owner = owner;
                Rooms = rooms;
            }

            public double GetErea()
            {
                double sum = 0;
                foreach (var room in Rooms)
                {
                    sum += room.GetErea();
                }

                return sum;
            }


            public string GetCategory()
            {
                switch (this.GetErea())
                {
                    case double erea when (erea <= 70):
                        return "small";
                    case double erea when (erea <= 110):
                        return "medium";
                    case double erea when (erea > 110):
                        return "large";
                    default:
                        return null;
                }
            }

            public override string ToString()
            {
                int count = 1;
                string finalString = $"Owner: {Owner} Rooms:\n";
                foreach (var room in Rooms)
                {
                    finalString += $"{count}: {room.ToString()}\n";
                }
                return finalString;
            }
        }

        public class Room
        {
            public string Type { get; set; }
            public double Width { get; set; }
            public double Depth { get; set; }

            public Room(string type, double width, double depth)
            {
                Type = type;
                Width = width;
                Depth = depth;
            }

            public Room(Room room)
            {
                Type = room.Type;
                Width = room.Width;
                Depth = room.Depth;
            }

            public double GetErea()
            {
                return Width * Depth;
            }

            public override string ToString()
            {
                return $"Type: {Type}, Width: {Width}, Depth {Depth}";
            }


        }

    }
}
