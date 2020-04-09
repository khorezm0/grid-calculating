using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridCommon
{
   
    
    public class GridJobController : MarshalByRefObject
    {

        static System.Random Random = new Random();

        /// <summary>
        /// Полчуить задание об умножении двух чисел
        /// </summary>
        /// <returns></returns>
        public Job GetJob()
        {
            var j = JobsFactory.GetJob();
            if (j != null)
                Console.WriteLine($"Клиенту дана работа! "+String.Join(", 0", j.N));
            return j;
        }

        public void SetResult(Job job, JobResult result)
        {
            Console.WriteLine($"Клиент посчитал: {result.Result}");
        }
    }
}
