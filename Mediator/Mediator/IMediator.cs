using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    public interface IMediator
    {
        void Send(string message, Colleague colega);
    }
}
