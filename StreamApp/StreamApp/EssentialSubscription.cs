using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamApp
{
    class EssentialSubscription: Subscription
    {
        public override Stream Subscribe(string subscribeName)
        {
            Stream getSubscribe = null;
            if (subscribeName == "Podcast")
                getSubscribe = new Stream(new Podcast());
            if (subscribeName == "News")
                getSubscribe = new Stream(new News());
            if (subscribeName == "Videos")
                getSubscribe = new Stream(new Videos());

            return getSubscribe;
        }
    }
}
