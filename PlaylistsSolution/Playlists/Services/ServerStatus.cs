using Playlists.Models.Status;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Playlists.Services
{
    public class ServerStatus : IProvideServerStatus
    {


        private ServerStatus()
        {
           // Thread.Sleep(10000); // simulate a long startup - maybe it has to query another service or something
        }

        public static ServerStatus CreateWithDelay(int seconds)
        {
            Thread.Sleep(seconds);
            return new ServerStatus();

        }
        public GetStatusResponse GetServerStatus()
        {

           
            // do whatever to get the status.. we'll fake it.
            return new GetStatusResponse
            {

                Message = "Everything is operating normally",
                LastChecked = DateTime.Now.AddMinutes(-4),
                VerifiedBy = "Bill"
            };
        }
    }
}
