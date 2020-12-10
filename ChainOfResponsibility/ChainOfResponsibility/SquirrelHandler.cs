using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    public class SquirrelHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
           if(request.ToString() == "Nut")
            {
                return "Squirrel is eating a " + request.ToString();
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}
