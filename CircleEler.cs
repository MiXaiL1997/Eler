using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Eler
{
    class CircleEler
    {
        private CircleEler parent;
        public CircleEler Parent => parent;
        public List<CircleEler> Childrens = new List<CircleEler>();
        public CircleEler (CircleEler parent)
        {
            this.parent = parent;
            parent.Childrens.Add(this);
        }

        //public void Reshape()
        //{
        //    Graphics g = Graphics.FromHwnd(HWND);
        //    g.FillEllipse(Brushes.Red, xY.X, xY.Y, xY.W, xY.H);
        //    g.Dispose();
        //}

    }
}
