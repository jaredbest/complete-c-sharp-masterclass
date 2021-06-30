using System;

namespace UsingMultipleConstructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Human jared = new Human("Jared", "Best", "green", 29);
            jared.IntroduceMyself();

            Human amalia = new Human("Amalia", "Panjuta", "blue");
            amalia.IntroduceMyself();

            Human basicHuman = new Human();
            basicHuman.IntroduceMyself();

            Human natalie = new Human("Natalie");
            natalie.IntroduceMyself();

            Human michael = new Human("Michael", "Miller");
            michael.IntroduceMyself();

            Human frank = new Human("Frank", "Walter", 25);
            frank.IntroduceMyself();

            Console.ReadKey();
        }
    }
}
