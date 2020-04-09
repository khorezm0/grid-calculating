using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridCommon
{

    /// <summary>
    /// Класс раздающий задания
    /// </summary>
    public class JobsFactory
    {
        static int[][] jobs;
        static int currI;

        public static void SetJobsRaw(int[][] jobs)
        {
            if(jobs == null)
            {
                throw new ArgumentNullException();
            }
            currI = 0;
            JobsFactory.jobs = jobs;
        }

        public static Job GetJob()
        {
            if(currI < jobs.Length)
            {
                var j = new Job() { N = jobs[currI] };
                currI++;
                return j;
            }

            return null;
        }
    }
}
