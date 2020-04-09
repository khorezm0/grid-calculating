using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

using GridCommon;

namespace GridServer
{
    class Server
    {
        static void Main(string[] args)
        {
            TcpServerChannel channel = new TcpServerChannel(3000);
            ChannelServices.RegisterChannel(channel, false);
            
            RemotingConfiguration.RegisterWellKnownServiceType(
             typeof(GridJobController), "Grid", WellKnownObjectMode.Singleton);

            JobsFactory.SetJobsRaw(new int[5][] {
                new int[]{ 1,2,3 },
                new int[]{156778, 100, 10 },
                new int[]{ 4,-100, 100000},
                new int[]{ 10, 0, 2000 },
                new int[]{ 200, 423134, 345 }
            });

            System.Console.WriteLine("hit to exit");
            System.Console.ReadLine();
        }
    }
}
