using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs13_class
{
    class Cat  // private이라도 같은 cs13_class 안에 있기 때문에 접근 가능
    {
        #region < 생성자 >

        /// <summary>
        /// 기본 생성자
        /// </summary>
        public Cat()
        {
            Name = string.Empty;
            Color = string.Empty;
            Age = 0;
        }

        /// <summary>
        /// 사용자 지정생성자
        /// </summary>
        /// <param name="name"></param>
        /// <param name="color"></param>
        /// <param name="age"></param>
        public Cat(string name, string color = "흰색", sbyte age = 1)
        {
            Name = name;
            Color = color;
            Age = age;
        }

        #endregion

        #region < 멤버변수 - 속성 >
        public string Name;  // 고양이 이름
        public string Color; // 색상
        public sbyte Age;  // 나이 0~255
        #endregion

        #region < 멤버 메서드 - 기능 >
        public void Meow()
        {
            Console.WriteLine("{0} - 야옹~!!", Name);
        }

        public void Run()  // private이면 hellokitty. 찍으면 안나옴
        {
            Console.WriteLine("{0} 달린다.", Name);
        }
        #endregion
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat hellokitty = new Cat();  // hellokitty라는 이름의 객체 생성
            hellokitty.Name = "헬로키티";
            hellokitty.Color = "흰색";
            hellokitty.Age = 50;
            hellokitty.Meow();
            hellokitty.Run();

            // 객체 생성하면서 속성 초기화
            Cat nero = new Cat() 
            { 
                Name = "검은고양이 네로",  // ctrl + space 하면 Name, Color, Age 나옴
                Color = "검은색",
                Age = 27,
            };
            nero.Meow();
            nero.Run();

            Console.WriteLine("{0}의 색상은 {1}, 나이는 {2}세 입니다.",
                                hellokitty.Name, hellokitty.Color, hellokitty.Age);
            Console.WriteLine("{0}의 색상은 {1}, 나이는 {2}세 입니다.",
                                nero.Name, nero.Color, nero.Age);
            // 기본 생성자
            Cat yaongi = new Cat();
            Console.WriteLine("{0}의 색상은 {1}, 나이는 {2}세 입니다.",
                                yaongi.Name, yaongi.Color, yaongi.Age);
            Cat norangi = new Cat("노랑이", "노란색");
            Console.WriteLine("{0}의 색상은 {1}, 나이는 {2}세 입니다.",
                                norangi.Name, norangi.Color, norangi.Age);
        }
    }
}
