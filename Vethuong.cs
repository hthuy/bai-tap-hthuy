using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ve_xem_phim
{
    class Vethuong : Ve 
    {
        private double giavethuong;
        public double Giavethuong { get; set; }
        public Vethuong(double giavethuong, double giave, int daban, string mave)
            : base(giave, mave, daban)
        {
            Giavethuong = giavethuong;
        }
    }
}
