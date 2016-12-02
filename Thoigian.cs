using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ve_xem_phim
{
    class Thoigian
    {
        List<Phim> b = new List<Phim>();
        private int gio;
        public int Gio
        {
            get { return gio; }
            set
            {
                if (value > 0 || value < 23)
                    gio = value;
                else
                    gio = 0;
            }
        }
        private int phut;
        public int Phut
        {
            get { return phut; }
            set
            {
                if (value > 0 || value < 59)
                    phut = value;
                else
                    phut = 0;
            }
        }
        private int ngay;
        public int Ngay
        {
            get { return ngay; }
            set
            {
                if (value > 0 && value <= 30)
                    ngay = value;
                else
                    ngay = 1;
            }
        }
        private int thang;
        public int Thang
        {
            get { return thang; }
            set
            {
                if (value > 0 && value <= 12)
                    thang = value;
                else
                    thang = 1;
            }

        }
        private int nam;
        public int Nam { get; set; }
        public Thoigian(int gio, int phut, int ngay, int thang, int nam)
        {
            Gio = gio;
            Phut = phut;
            Thang = thang;
            Ngay = ngay;
            Nam = nam;

        }
    }
}
