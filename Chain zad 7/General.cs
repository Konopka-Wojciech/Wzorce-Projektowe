using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tickets
{
    internal class General : Handler
    {
        public override string Handle(Ticket request)
        {
            if (request.Type == "general")
            {
                return $"General Support: Handling general inquiry - {request.Description}";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}
