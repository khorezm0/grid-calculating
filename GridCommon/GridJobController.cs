using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridCommon
{
   
    
    public class GridJobController : MarshalByRefObject
    {

        /// <summary>
        /// Полчуить задание об умножении двух чисел
        /// </summary>
        /// <returns></returns>
        public Job GetJob()
        {
            var j = JobsFactory.GetJob();
            if (j != null) Console.WriteLine("Клиент взял работу: "+j.CalcSizes);
            return j;
        }

        public void SetResult(JobResult result)
        {
            JobsComparer.AddJobResult(result);
            Console.WriteLine($"Клиент посчитал: {result.Sum}");
        }
    }
}
