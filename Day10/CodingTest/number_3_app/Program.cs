﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number_3_app
{
    class Car
    {
        public string Name;
        public string Maker;
        public string Color;
        public int YearModel;
        public int MaxSpeed;
        public string UniqueNumber;

        public void Start()
        {
            Console.WriteLine($"{Name}의 시동을 겁니다");
        }

        public void Accelerate()
        {
            Console.WriteLine($"최대시속 {MaxSpeed}km/h로 가속합니다");
        }

        public void TurnRight()
        {
            Console.WriteLine($"{Name}을 우회전합니다");
        }

        public void Brake()
        {
            Console.WriteLine($"{Name}의 브레이크를 밟습니다");
        }
    }

    class ElectricCar : Car
    {
        public void Recharge()
        {
            Console.WriteLine("달리면서 배터리를 충전합니다");
        }
    }

    class HybridCar : ElectricCar
    {
        public new void Recharge()
        {
            Console.WriteLine("달리면서 배터리를 충전합니다");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            HybridCar ioniq = new HybridCar();
            ioniq.Name = "아이오닉";
            ioniq.Maker = "현대자동차";
            ioniq.Color = "White";
            ioniq.YearModel = 2018;
            ioniq.MaxSpeed = 220;
            ioniq.UniqueNumber = "54라 3346";

            ioniq.Start();  // 시동
            ioniq.Accelerate();  // 가속
            ioniq.Recharge();  // 배터리 충전
            ioniq.TurnRight();  // 우회전
            ioniq.Brake();  // 브레이크      
        }
    }
}

