using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

using GridCommon;

namespace GridServerConsole
{
    class Server
    {
        static void Main(string[] args)
        {
            TcpServerChannel channel = new TcpServerChannel(3000);
            ChannelServices.RegisterChannel(channel, false);
            
            RemotingConfiguration.RegisterWellKnownServiceType(
             typeof(GridJobController), "Grid", WellKnownObjectMode.Singleton);

            Console.Write("Введите размер матрицы: ");

            bool q = false;
            while (!q)
            {
                var text = Console.ReadLine();
                long size = 0;
                if (text == "q") 
                {
                    q = true;
                }
                else if(long.TryParse(text,out size))
                {
                    Random r = new Random();
                    int[][] matrix = new int[size][];
                    for (int i = 0; i < size; i++)
                    {
                        matrix[i] = new int[size];
                        for (int j = 0; j < size; j++)
                            matrix[i][j] = r.Next(-1000, 1000);
                    }

                    JobsFactory.SetJobsRaw(new SquareMatrix(matrix));
                    Console.WriteLine("Для новой работы введите новый размер матрицы(или q для выхода): ");
                }
                else 
                {
                    Console.WriteLine("Введите нормальные данные!");
                }
            }

            System.Console.WriteLine("hit to exit");
            System.Console.ReadLine();
        }
    }
}
