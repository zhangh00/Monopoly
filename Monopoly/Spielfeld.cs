using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Monopoly
{
    class Spielfeld : Ereignis
    {
        public List<Rectangle> feld = new List<Rectangle>();
        public List<int> feldstatus = new List<int>();
        public Spielfeld()
        {
            for (int i = 0; i < feld.Count; i++)
            {
                feldstatus.Add(0);
            }
        }
    }
}
