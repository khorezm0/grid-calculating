using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridCommon
{
    public class JobsComparer
    {
        static Action<string> callback;
        static JobResult MaxResult;

        public static void AddJobResult(JobResult result)
        {
            if (MaxResult == null 
                || result.Sum > MaxResult.Sum)
                MaxResult = result;

            //сравниваем и мб созраняем рузельтат
            if (!JobsFactory.HasJob && result.JobStartIndex == JobsFactory.LastValidId)
            {
                var j = MaxResult.Index % JobsFactory.CurrentMatrix.Size;
                var i = (MaxResult.Index - j) / JobsFactory.CurrentMatrix.Size;

                var str = $"Макс Сумма: {MaxResult.Sum} \nСтрока: {i+1} \nСтолбец: {j+1} \nРазмер: {MaxResult.Size}";
                callback?.Invoke(str);
            }
        }

        public static void SetJobDoneCallback(Action<string> callback)
        {
            JobsComparer.callback = callback;
        }
    }
}
