using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridCommon
{
    public class JobExecutor
    {
        /// <summary>
        /// Выполняет работу
        /// </summary>
        /// <param name="job"></param>
        /// <returns></returns>
        public JobResult Execute(Job job)
        {
            Dictionary<Bounds, int> dic = new Dictionary<Bounds, int>();
            foreach(var b in job.MatricesToSum)
            {
                var sum = job.Matrix.Sum();
                dic.Add(b, sum);
                Console.WriteLine("Sum: "+sum);
            }
            return new JobResult() { 
                Result = dic
            };
        }
    }
}
