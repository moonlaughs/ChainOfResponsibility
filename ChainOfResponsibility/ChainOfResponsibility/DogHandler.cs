using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    public class DogHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
            if(request.ToString() == "MeatBall")
            {
                return "Dog is eating a " + request.ToString();
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}
