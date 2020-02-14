using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExampleProject {
    class HelloInPirate : ISpeakable {

        public void SayHello() {
            Console.WriteLine("Arg! Hello Matey");

        }
        public void SayGoodbye() {
            Console.WriteLine("Arg! Goodbye Matey");
        }
    }
}
