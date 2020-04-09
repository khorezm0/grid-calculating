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
            int res = 1;
            foreach(var n in job.N)
            {
                res *= n;
            }
            return new JobResult() { 
                Result = res
            };
        }
    }
}
