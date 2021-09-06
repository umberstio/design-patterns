using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    internal class User : Colleague
    {
        public User(IMediator mediator) : base(mediator)
        {
        
        }
        public override void Receive(string message)
        {
            Console.WriteLine($"U Usuario Recibe {message}");
        }
    }
}
