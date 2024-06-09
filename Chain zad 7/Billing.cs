using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tickets
{
    internal class Billing : Handler
    {
        public override string Handle(Ticket request)
        {
            if (request.Type == "billing")
            {
                return $"Billing Support: Handling billing issue - {request.Description}";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}
