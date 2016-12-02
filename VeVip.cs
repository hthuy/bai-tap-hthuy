using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ve_xem_phim
{
    class VeVip : Ve
    {
        private double giavevip;
        public double GiaVeVip { get; set; }
        public VeVip(double giavevip, double giave, int daban, string mave)
            : base(giave, mave, daban)
        {
            GiaVeVip = giavevip;
        }
    }
}
