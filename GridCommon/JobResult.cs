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
        public long JobStartIndex { get; set; }
        public long Index { get; set; }
        public long Size { get; set; }
        public long Sum { get; set; }
    }

}
