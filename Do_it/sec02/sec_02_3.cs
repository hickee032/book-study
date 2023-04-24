using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sec_02_2 {
    internal class Program {
        public static void Main(string[] args) {


                for (int i = 0; i < 11; i++) {
                    Console.WriteLine(i);
                }

                for (int i = 10; i >= 0; i--) {
                    Console.WriteLine(i);
                }

            int i = 1;
            while (i<110) {
                Console.WriteLine(i);
                i++;
                if (i == 100) {
                    Console.WriteLine("100  돌파");
                }
            }
        }
    }
}
