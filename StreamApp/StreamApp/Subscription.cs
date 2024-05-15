using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamApp
{
    abstract class Subscription
    {
        public Stream AddSubscription(string subscribeName) 
        {
            Stream Return = Subscribe(subscribeName);

            if(Return != null) 
            {
              
                Return.watch();
            }

            return Return;
        }

        public abstract Stream Subscribe(string subscribeName);
    }
}
