using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sec_02_4 {
    class Person {

        public string Name;
        public string Birthday;
        public string Gender;

        public void Eat() {
            Console.WriteLine(Name + " 밥을 먹습니다.");
        }
        public void Walk() {
            Console.WriteLine(Name + " 걷습니다");
        }
        public void  Run() {
            Console.WriteLine(Name + " 뜁니다");
        }


    }
}
