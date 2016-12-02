using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ve_xem_phim
{
    class Ve
    {
        public double Giave { get; set; }
        public string Mave { get; set; }
        public int Daban { get; set; }
        public Ve(double giave, string mave, int daban)
        {
            Giave = giave;
            Mave = mave;
            Daban = daban;
        }
    }
}
