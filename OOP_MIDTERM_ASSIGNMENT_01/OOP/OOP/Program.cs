using System.Data;

namespace User
{
    public enum Kind { Dog, Cat, Lizard, Bird }

    // Enum for Gender
    public enum Gender { Male, Female }

    // Interface for shared behavior
    public interface IAnimal
    {
        string MakeSound();
    }

    // Abstract Base Class Pet
    public abstract class Pet : IAnimal
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public string Owner { get; set; }

        public Pet(string name, Gender gender, string owner)
        {
            Name = name;
            Gender = gender;
            Owner = owner;
        }

        public abstract string MakeSound();

        public abstract override string ToString();
    }

    // Dog Class
    public class Dog : Pet
    {
        public string Breed { get; set; }

        public Dog(string name, Gender gender, string owner, string breed)
            : base(name, gender, owner)
        {
            Breed = breed;
        }

        public override string MakeSound()
        {
            return "Woof! Woof! Woof!";
        }

        public override string ToString()
        {
            return $"Dog - {Name} ({Gender})\t | \tOwner: {Owner}\t | \tBreed: {Breed}";
        }
    }

    // Cat Class
    public class Cat : Pet
    {
        public bool IsLonghaired { get; set; }

        public Cat(string name, Gender gender, string owner, bool isLonghaired)
            : base(name, gender, owner)
        {
            IsLonghaired = isLonghaired;
        }

        public override string MakeSound()
        {
            return "Meow! Meow! Meow!";
        }

        public override string ToString()
        {
            return $"Cat - {Name} ({Gender})\t | \tOwner: {Owner}\t | \tHair Type: {(IsLonghaired ? "Longhaired" : "Shorthaired")}";
        }
    }

    // Lizard Class
    public class Lizard : Pet
    {
        public bool CanRegenerateTail { get; set; }

        public Lizard(string name, Gender gender, string owner, bool canRegenerateTail)
            : base(name, gender, owner)
        {
            CanRegenerateTail = canRegenerateTail;
        }

        public override string MakeSound()
        {
            return "Hiss! Hiss! Hiss!";
        }

        public override string ToString()
        {
            return $"Lizard - {Name} ({Gender})\t | \tOwner: {Owner}\t | \t Can Regenerate Tail: {(CanRegenerateTail ? "Yes" : "No")}";
        }
    }

    // Bird Class
    public class Bird : Pet
    {
        public bool CanFly { get; set; }

        public Bird(string name, Gender gender, string owner, bool canFly)
            : base(name, gender, owner)
        {
            CanFly = canFly;
        }

        public override string MakeSound()
        {
            return "Chirp! Chirp! Chirp!";
        }

        public override string ToString()
        {
            return $"Bird - {Name} ({Gender})\t | \tOwner: {Owner}\t | \tCan Fly: {(CanFly ? "Yes" : "No")}";
        }
    }

    // Main Application
    public class Program
    {
        static List<Pet> pets = new List<Pet>();

        public static void Main(string[] args)
        {
            Console.WriteLine("-------- Welcome to the Pet Inventory!! --------");

            while (true)
            {
                AddPet();
                Console.Write("\r\nAdd another pet? (y/n): ");
                if (Console.ReadLine().ToLower() != "y") break;
            }

            ListPets();
        }

        static void AddPet()
        {

            Console.WriteLine($"\r\nPet #{pets.Count + 1}:");

            Console.Write("Kind (Dog, Cat, Lizard, Bird): ");
            Kind kind = (Kind)Enum.Parse(typeof(Kind), Console.ReadLine(), true);

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Gender (M/F): ");
            Gender gender = Console.ReadLine().ToLower() == "m" ? Gender.Male : Gender.Female;

            Console.Write("Owner: ");
            string owner = Console.ReadLine();

           
            switch (kind)
            {
                case Kind.Dog:
                    Console.Write("\r\nBreed: ");
                    string breed = Console.ReadLine();
                    pets.Add(new Dog(name, gender, owner, breed));
                    break;

                case Kind.Cat:
                    Console.Write("\r\nIs Longhaired? (y/n): ");
                    bool isLonghaired = Console.ReadLine().ToLower() == "y";
                    pets.Add(new Cat(name, gender, owner, isLonghaired));
                    break;

                case Kind.Lizard:
                    Console.Write("\r\nCan Regenerate Tail? (y/n): ");
                    bool canRegenerateTail = Console.ReadLine().ToLower() == "y";
                    pets.Add(new Lizard(name, gender, owner, canRegenerateTail));
                    break;

                case Kind.Bird:
                    Console.Write("\r\nCan Fly? (y/n): ");
                    bool canFly = Console.ReadLine().ToLower() == "y";
                    pets.Add(new Bird(name, gender, owner, canFly));
                    break;
            }
        }

        static void ListPets()
        {
            Console.Write("\r\nWhich type of animal would you like to list? (Dog, Cat, Lizard, Bird, or 'All'): ");
            string filter = Console.ReadLine();
            Kind kindFilter;

            List<Pet> filteredPets;
            if (Enum.TryParse(filter, true, out kindFilter))
            {
                filteredPets = pets.Where(p => p.GetType().Name == kindFilter.ToString()).ToList();
            }
            else
            {
                filteredPets = pets;
            }

            Console.WriteLine("\n---------------------- All pets in the inventory: ----------------------");
            foreach (var pet in filteredPets)
            {
                Console.WriteLine("* " + pet.ToString() + "\r\n ");
            }
        }
    }
}