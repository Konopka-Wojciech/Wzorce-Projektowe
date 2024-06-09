using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tickets
{
    internal class Technical : Handler
    {
        public override string Handle(Ticket request)
        {
            if (request.Type == "technical")
            {
                return $"Technical Support: Handling technical issue - {request.Description}";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}
