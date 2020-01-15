using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eler
{
    class XY
    {
        private float x;
        private float y;
        private float w;
        private float h;
        public float X => x;
        public float Y => y;
        public float W => w;
        public float H => h;
        public XY(float x, float y, float w, float h)
        {
            this.x = x;
            this.y = y;
            this.w = w;
            this.h = h;
        }
    }
}
