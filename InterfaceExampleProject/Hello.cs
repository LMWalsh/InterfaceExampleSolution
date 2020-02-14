using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExampleProject {
    class Hello {

        ISpeakable Language;

        public void Speak() {
            Language.SayHello();
            Language.SayGoodbye();
        }
        public void Speak2() {
            Language.SayGoodbye();
        }

        public Hello(ISpeakable language) {
            Language = language;
        }
       
        
        public Hello() {
        }

    }
}
