using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs04_enums
{
    internal class Program
    {
        enum HomeTown
        {
            SEOUL = 1,
            DAEJEON = 2,
            DAEGU,  
            BUSAN,  // 지정안한 부분은 자동으로 다음 숫자로 됨
            JEJU = 9  // 열거형 장점 : 숫자로 지정할 수 있음
        };

        // string[] home = new { "Seoul", "Daejun" };

        static void Main(string[] args)
        {
            HomeTown myHomeTown;
            myHomeTown = HomeTown.BUSAN;

            if (myHomeTown == HomeTown.SEOUL)
            {
                Console.WriteLine("서울 출신이시군요!");
            }
            else if (myHomeTown == HomeTown.DAEJEON)
            {
                Console.WriteLine("충청도예유~");
            }
            else if (myHomeTown == HomeTown.DAEGU)
            {
                Console.WriteLine("대구여~");
            }
            else if (myHomeTown == HomeTown.BUSAN)
            {
                Console.WriteLine("부산이라예~");
            }
        }
    }
}
