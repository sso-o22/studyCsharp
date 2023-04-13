using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs29_filehandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Directory == Folder
            // "C:\\Dev" / @"C:\Dev" 리터럴은 여러줄 문자열도 가능
            string curDirectory = @"C:\Temp";  // C:\Dev - 절대경로 / .은 현재 디렉토리(상대 경로) / ..은 부모디렉토리

            Console.WriteLine("현재 디렉토리 정보");

            var dirs = Directory.GetDirectories(curDirectory); // var -> local 영역에서만 사용 가능 (밖에서는 X)
            foreach (var dir in dirs)
            {
                var dirInfo = new DirectoryInfo(dir);

                Console.Write(dirInfo.Name);
                Console.WriteLine(" [{0}]", dirInfo.Attributes);
            }

            Console.WriteLine("현재 디렉토리 정보");
            
            var files = Directory.GetFiles(curDirectory);
            foreach(var file in files)
            {
                var fileInfo = new FileInfo(file);

                Console.Write(fileInfo.Name);
                Console.WriteLine(" [{0}]", fileInfo.Attributes);
            }

            // 특정 경로에 하위 폴더 / 하위 파일 조회

            string path = @"C:\Temp\Csharp_Bank";  // 만들고자 하는 폴더
            string sfile = "Test2.log";  // 생성할 파일
            
            if (Directory.Exists(path))  // 이런 디렉토리가 있으면
            {
                Console.WriteLine("경로가 존재하여 파일을 생성합니다.");
                File.Create(path + @"\" + sfile);  // C:\Temp\Csharp_Bank\Test.log
            }
            else  // 이런 경로 없으면
            {
                //Console.WriteLine("해당 경로가 없습니다. {0}", path);
                Console.WriteLine($"해당 경로가 없습니다. {path}");
                Directory.CreateDirectory(path);  // 디렉토리(경로)를 생성

                Console.WriteLine("경로를 생성하여 파일을 생성합니다.");
                File.Create(path + @"\" + sfile);  // "/" 도 가능

            }
        }
    }
}
