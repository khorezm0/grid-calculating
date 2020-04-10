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

        public static void AddJobResult(JobResult result)
        {
            //сравниваем и мб созраняем рузельтат
            if (!JobsFactory.HasJob)
            {
                callback?.Invoke("Норм");
            }
        }

        public static void SetJobDoneCallback(Action<string> callback)
        {
            JobsComparer.callback = callback;
        }
    }
}
