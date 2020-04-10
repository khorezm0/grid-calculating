using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridCommon
{
    [System.Serializable]
    public class Bounds
    {
        public long StartLeft { get; set; }
        public long StartTop { get; set; }
        public long EndLeft { get; set; }
        public long EndTop { get; set; }

        public Bounds()
        {

        }

        public Bounds(long startLeft, long startTop, long endLeft, long endTop)
        {
            StartLeft = startLeft;
            StartTop = startTop;
            EndLeft = endLeft;
            EndTop = endTop;
        }
    }
}
