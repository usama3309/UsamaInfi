using InterviewQuestions;
using System;
class Program
{


    

    static void Main()
    {
        //Loopiteration loopit = new Loopiteration();
        //loopit.StartIteration();


        B B_Class= new B("this is B class");
        B_Class.PrintNameClassA();

        C C_Class = new C("This is C");
       C_Class.PrintNameClassA();
        C_Class.PrintNameClassB("this is b print menthod");

        D D_class = new D("this is D");
        D_class.PrintNameClassA();

    }
}