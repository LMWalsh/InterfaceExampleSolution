using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExampleProject {
    class HelloInEnglish : ISpeakable {
        
        public void SayHello() {
            Console.WriteLine("Hello");
        }
        public void SayGoodbye() {
            Console.WriteLine("Goodbye");
        }
            
        }
    }


