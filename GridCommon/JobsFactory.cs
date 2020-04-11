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
    public static class JobsFactory
    {
        static SquareMatrix matrix;
        static long currI = 0;
        static long currMatrSize = 2;

        static long maxMatrSize;
        static long maxMatrCells;

        static long maxJobs = 1;
        const long jobMaxCells = 10000;

        public static bool HasJob { get; private set; }
        public static long LastValidId { get; private set; }

        public static SquareMatrix CurrentMatrix => matrix;

        public static void SetJobsRaw(SquareMatrix jobs)
        {
            if(jobs == null)
            {
                throw new ArgumentNullException();
            }

            matrix = jobs;
            HasJob = true;
            currI = 0;
            currMatrSize = 2;
            maxMatrSize = matrix.Size;
            maxMatrCells = matrix.Size * matrix.Size;
        }

        public static Job GetJob()
        {
            if(HasJob)
            {
                var j = new Job()
                {
                    Matrix = matrix,
                    CalcSizes = currMatrSize,
                    StartIndex = currI,
                    EndIndex = Math.Min(Math.Max(jobMaxCells, currMatrSize), maxMatrCells)
                };
                LastValidId = currI;

                currI += Math.Max(jobMaxCells, currMatrSize) + 1;

                if (currI >= maxMatrCells)
                {
                    currI = 0;
                    currMatrSize++;
                    if(currMatrSize > maxMatrSize)
                    {
                        HasJob = false;
                    }
                }
                return j;
            }

            return null;
        }
    }
}
