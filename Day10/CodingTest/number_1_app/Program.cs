using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 1, 2번 같이
namespace number_1_app
{
    class Boiler
    {
        private int temperature;
        private byte voltage;

        public string Brand
        {
            get;
            set;
        }
        public int Temperature
        {
            get { return this.temperature; }
            set
            {
                // 물온도는 5도 이하면 5도로, 70도 이상이면 70도로 제한
                if (value <= 5)
                {
                    this.temperature = 5;
                }
                else if (value >= 70)
                {
                    this.temperature = 70;
                }
                else
                {
                    this.temperature = value;
                }
            }
        }

        public byte Voltage
        {
            get { return this.voltage; }
            set
            {
                // 110v과 220v만 저장할 수 있도록 처리
                if (value == 110 || value == 220)
                {
                    this.voltage = value;
                }
                else
                {
                    Console.WriteLine("110V과 220V만 저장할 수 있습니다.");
                }
                
            }
        }

        public void PrintAll()
        {
            Console.WriteLine($"Brand = {Brand}, Volatge = {Voltage}, Temperature = {Temperature}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Boiler kitturami = new Boiler { Brand = "귀뚜라미", Voltage = 220, Temperature = 45 };
            kitturami.PrintAll();
        }
    }
}
