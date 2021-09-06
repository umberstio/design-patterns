using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    public abstract class Colleague
    {
        private readonly IMediator _mediator;
        public IMediator Mediator { get { return _mediator;  } }

        public Colleague(IMediator mediator)
        {
            _mediator = mediator;
        }


        public void Comunicate(string message)
        {
            this._mediator.Send(message, this);
        }

        public abstract void Receive(string message);
    }
}
