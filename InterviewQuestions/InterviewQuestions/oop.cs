using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions
{
    public class oop
    {
    }

    //A is abstract
    public abstract class A {

        protected string Name;
        public abstract void PrintNameClassA();

    }

    //B is inherited from A
    public class B: A
    {
        private void PrintNameClassB(string message) {
            Console.WriteLine($"{message} : {Name}");
        
        }
        //override peirnt method of class A
        public override void PrintNameClassA() {
            PrintNameClassB("B Says");
        }

        public B(string name)
        {
            this.Name= name;
        }
        
    }

    // C is inheited from B
    public class C : B
    {
        public new void PrintNameClassB(string message) {
            Console.WriteLine($"{message} from C: {this.Name}");
        }

        public C(string name) : base(name)
        {
        }
    }

    //D is inheited from A
    public class D : A
    {
        //override the print method of inherited class A
        public override void PrintNameClassA()
        {
            Console.WriteLine($"D name is : {this.Name}");
        }

        public D(string name)
        {
            this.Name = name;
        }

    }
}
