using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap_01 {
    internal class Program {
        static void Main(string[] args) {

            //Console.Write("write");
            Console.WriteLine(53);
            Console.WriteLine(53 + 250);
            Console.WriteLine(5 + 3 * 2);
            Console.WriteLine(10 % 5);
            Console.WriteLine(7 % 3);

            Console.WriteLine(1 + 2);
            Console.WriteLine(1 - 2);
            Console.WriteLine(1 * 2);
            Console.WriteLine(1 / 2);
            Console.WriteLine(1 % 2);

            // 5.0 - (2.2*2)
            Console.WriteLine(5.0 % 2.2);

            Console.WriteLine("한빛\t아카데미");
            Console.WriteLine("한빛\n아카데미");

            Console.WriteLine("가" + "nadaramabq");

            Console.WriteLine("안녕하세요"[0]);
            Console.WriteLine("안녕하세요"[3]);
        }
    }
}
