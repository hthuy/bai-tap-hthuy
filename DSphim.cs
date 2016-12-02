using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ve_xem_phim
{
    class DSphim
    {
        string tenphim;

        public string TenPhim
        {
            get { return tenphim; }
            set
            {
                if (value != "")
                    tenphim = value;
                else
                    tenphim = "";
            }
        }
    }
}
