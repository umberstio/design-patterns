using System;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            Mediator mediator = new Mediator();
            Colleague oPepe = new User(mediator);
            Colleague oAdmin = new UserAdmin(mediator);

            mediator.Add(oPepe);
            mediator.Add(oAdmin);

            oPepe.Comunicate("Hey Admin I have a problem...");

            Console.ReadKey();

        }
    }
}
