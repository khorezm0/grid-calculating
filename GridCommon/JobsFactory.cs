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
        static SquareMatrix jobs;
        static int currI;

        public static void SetJobsRaw(SquareMatrix jobs)
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
            if(currI < 1)
            {
                var j = new Job() { 
                    Matrix = jobs, 
                    MatricesToSum = new Bounds[]
                    { new Bounds(0, 0, jobs.Size - 1, jobs.Size -1) } };
                currI++;
                return j;
            }

            return null;
        }
    }
}
