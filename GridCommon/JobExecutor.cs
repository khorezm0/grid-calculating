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
            long maxSum = 0;
            long maxI = 0;
            bool isHasMax = false;

            for (long I = job.StartIndex; I < job.EndIndex; I++)
            {
                var j = I % job.Matrix.Size;
                var i = (I - j) / job.Matrix.Size;

                var endI = i + job.CalcSizes - 1;
                var endJ = j + job.CalcSizes - 1;


                //Console.WriteLine($"Calc: {job.CalcSizes} ({j};{i} - {endJ};{endI}) ");

                if (endI >= job.Matrix.Size || endJ >= job.Matrix.Size ||
                    i >= job.Matrix.Size || j >= job.Matrix.Size
                    )
                {
                    //Console.WriteLine($"Cancel!");
                    continue;
                }

                var sum = job.Matrix.Sum(new Bounds(j, i, endJ, endI));

                //Console.WriteLine($"Sum: {sum}");
                if (maxSum < sum || !isHasMax)
                {
                    isHasMax = true;
                    maxSum = sum;
                    maxI = I;
                }
            }

            return new JobResult() {
                JobStartIndex = job.StartIndex,
                Index = maxI,
                Size = job.CalcSizes,
                Sum = maxSum
            };
        }
    }
}
