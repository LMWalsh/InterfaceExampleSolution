using System;
using System.Collections.Generic;

namespace InterfaceExampleProject {
    class Program {
        private static ISpeakable spanish;

        static void Main(string[] args) {

            var english = new HelloInEnglish();
            var spanish = new HelloInSpanish();

            var hello = new Hello(english);
            hello.Speak();
            var hello2 = new Hello(spanish);
            hello2.Speak();

            var hellofr = new Hello(new HelloInFrench());
            hellofr.Speak();

            var hellopr = new Hello(new HelloInPirate());
            hellopr.Speak();

            var Hello = new Hello();

        }
        static void TestInterfaceWidgets() { 

            var w1 = new Widget();
            var aw = new AdvWidget();
            var sw = new SuperWidget();

            var widgets = new List<IPrintable>();
            widgets.Add(w1);
            widgets.Add(aw);
            widgets.Add(sw);

            foreach (var widget in widgets) {
                widget.Print();
            }

        }

    }
}
