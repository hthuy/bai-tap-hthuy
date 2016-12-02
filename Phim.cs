using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ve_xem_phim
{
    class Phim
    {
        string diachi;
        string rapchieu;
        string tenphim;

        public string DiaChi
        {
            get { return diachi; }
            set
            {
                if (value != "")
                    diachi = value;
                else
                    diachi = "";
            }
        }
        public string RapChieu
        {
            get { return rapchieu; }
            set
            {
                if (value != "")
                    rapchieu = value;
                else
                    rapchieu = "";
            }
        }
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
