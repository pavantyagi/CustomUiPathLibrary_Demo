using System;
using System.Activities;
using System.ComponentModel;

namespace UiPath.Lukas.Activities
{
    public class HelloWorld : CodeActivity
    {
        [Category("Output")]
        public OutArgument<string> Hello { get; set; }

        public string GetHello() { return "Hello from GetHello()"; }

        protected override void Execute(CodeActivityContext context)
        {
            Hello.Set(context, "Hello from Property!");
        }
    }
}
