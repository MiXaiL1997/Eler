using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Eler
{
    class DiagrammEler: List<CircleEler>
    {
        private float defaultW = 100;
        private float defaultH = 100;
        private float defaultX = 100;
        private float defaultY = 100;
        private Graphics g;
        
        public DiagrammEler(PictureBox box)
        {
            g = Graphics.FromHwnd(box.Handle);
        }

        ~DiagrammEler()
        {
            g.Dispose();
        }

        public new void Add(CircleEler item)
        {
            base.Add(item);
            Reshape();
        }

        private void Reshape()
        {
            foreach(var Item in this)
            {
                if (Item.Parent == null && Item.Childrens.Count == 0)
                {
                    XY xy = new XY()
                    g.DrawEllipse(new Pen(Color.Red, 5), )
                }
                
            }
        }
    }
}
