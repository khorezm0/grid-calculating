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

            Random r = new Random();
            int size = 1000;
            int[,] matrix = new int[size,size];
            for (int i = 0; i > size; i++)
                for (int j = 0; j < size; j++)
                    matrix[i, j] = r.Next(-1, 1000);

            JobsFactory.SetJobsRaw(new SquareMatrix(matrix));

            System.Console.WriteLine("hit to exit");
            System.Console.ReadLine();
        }
    }
}
