using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamApp
{
    class DeluxeSubscription: Subscription
    {
        public override Stream Subscribe(string subscribeName)
        {
            Stream getSubcribed = null;

            if (subscribeName == "Movies")
                getSubcribed = new Stream(new Movies());
            if (subscribeName == "Sports")
                getSubcribed = new Stream(new Sports());
            if (subscribeName == "Videos")
                getSubcribed = new Stream(new Videos());    

            return getSubcribed;
        }
    }
}
