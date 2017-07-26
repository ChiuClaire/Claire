using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example02
{
    class Program
    {
        static void Main(string[] args)
        {
            Student aStudent = new Student()
            {
                name = "Claire",
                phone = "123",
                address = "台大"
            };
            Console.WriteLine(
                "學生姓名:{0}, 電話:{1}, 住址:{2}"
                , aStudent.name
                , aStudent.phone
                , aStudent.address
             );
        }
    }
}
