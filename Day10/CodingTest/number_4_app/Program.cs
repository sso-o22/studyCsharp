using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number_4_app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dicRainbow = new Dictionary<string, string>();
            dicRainbow["빨간색"] = "Red";
            dicRainbow["주황색"] = "Orange";
            dicRainbow["노란색"] = "Yellow";
            dicRainbow["초록색"] = "Green";
            dicRainbow["파란색"] = "Blue";
            dicRainbow["남색"] = "Navy";
            dicRainbow["보라색"] = "Purple";

            void ColorCheck()
            {
                Console.Write("무지개 색은 ");
                foreach (string i in dicRainbow.Keys)
                {
                    Console.Write(i + ", ");
                }
                Console.WriteLine("입니다.");
                Console.WriteLine("");
            }

            void KeyValueCheck(string rainbow)
            {
                Console.WriteLine("Key와 Value 확인");
                Console.WriteLine($"{dicRainbow[rainbow]}은 {rainbow} 입니다.");
            }

            ColorCheck();
            KeyValueCheck("보라색");
        }
    }
}
