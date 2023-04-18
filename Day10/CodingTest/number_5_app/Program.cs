using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number_5_app
{
    interface IAnimal
    {
        string Name { get; set; }
        int Age { get; set; }
        void Eat();
        void Sleep();
        void Sound();
    }
    
    class Dog : IAnimal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Eat()
        {
            Console.WriteLine($"강아지 {this.Name}가 먹고 있습니다.");
        }

        public void Sleep()
        {
            Console.WriteLine($"강아지 {this.Name}가 자고 있습니다.");
        }

        public void Sound()
        {
            Console.WriteLine($"강아지 {this.Name}가 멍멍 소리를 냅니다.");
        }
    }

    class Cat : IAnimal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Eat()
        {
            Console.WriteLine($"고양이 {this.Name}가 먹고 있습니다.");
        }

        public void Sleep()
        {
            Console.WriteLine($"고양이 {this.Name}가 자고 있습니다.");
        }

        public void Sound()
        {
            Console.WriteLine($"고양이 {this.Name}가 냐옹 소리를 냅니다.");
        }
    }

    class Horse : IAnimal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Eat()
        {
            Console.WriteLine($"말 {this.Name}가 먹고 있습니다.");
        }

        public void Sleep()
        {
            Console.WriteLine($"말 {this.Name}가 자고 있습니다.");
        }

        public void Sound()
        {
            Console.WriteLine($"말 {this.Name}가 히이잉 소리를 냅니다.");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Dog bori = new Dog();
            bori.Name = "보리";
            bori.Eat();
            bori.Sleep();
            bori.Sound();

            Cat kitty = new Cat();
            kitty.Name = "키티";
            kitty.Eat();
            kitty.Sleep();
            kitty.Sound();

            Horse mari = new Horse();
            mari.Name = "마리";
            mari.Eat();
            mari.Sleep();
            mari.Sound();
        }
    }
}
