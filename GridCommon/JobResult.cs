using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridCommon
{
    [System.Serializable]
    /// <summary>
    /// Модель описания результата работы
    /// </summary>
    public class JobResult
    {
        public Dictionary<Bounds, int> Result { get; set; }
    }

}
