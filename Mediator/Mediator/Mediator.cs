using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    public class Mediator : IMediator
    {
        private readonly List<Colleague> _colleagues;

        public Mediator()
        {
            _colleagues = new List<Colleague>();
        }

        public void Add (Colleague colleague)
        {
            this._colleagues.Add(colleague);
        }

        public void Send(string message, Colleague colleague)
        {
            foreach (var c in _colleagues)
            {
                if (c != colleague)
                    c.Receive( message); 
            }
        }
    }
}
