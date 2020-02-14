using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExampleProject {
    class HelloInFrench : ISpeakable {
        public void SayHello() {
            Console.WriteLine("Bonjour");
        }
        public void SayGoodbye() {
            Console.WriteLine("Au Revoir");
        }
    }
}
