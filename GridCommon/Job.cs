using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridCommon
{
    [System.Serializable]
    /// <summary>
    /// Модель описания работы
    /// </summary>
    public class Job
    {
        public SquareMatrix Matrix { get; set; }
        public long CalcSizes { get; set; }
        public long StartIndex { get; set; }
        public long EndIndex { get; set; }
    }

}
