using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    public abstract class AbstractHandler : IHandler
    {
        private IHandler _nextHadler;
        public virtual object Handle(object request)
        {
            if(_nextHadler != null)
            {
                return _nextHadler.Handle(request);
            }
            else
            {
                return null;
            }
        }

        public IHandler SetNext(IHandler handler)
        {
            _nextHadler = handler;
            return handler;
        }
    }
}
