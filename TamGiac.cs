using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi3
{
    class TamGiac
    {
        private int canhMA;
        private int canhMB;
        private int canhMC;
        private double ChuVi;
        private double DienTich;

        public TamGiac()
        {
            canhMA = 0;
            canhMB = 0;
            canhMC = 0;
        }
        public TamGiac(int canhMA, int canhMB, int canhMC)
        {
            this.canhMA = canhMA;
            this.canhMB = canhMB;
            this.canhMC = canhMC;
        }
        public double ChuVi()
        {
            return canhMC + canhMA + canhMB;
        }
        public double nuaChuVi()
        {
            return (canhMA + canhMB + canhMC) / 2;
        }
        public double DienTich()
        {
            return Math.Sqrt(nuaChuVi * (nuaChuVi - canhMA) * (nuaChuVi - canhMB) * (nuaChuVi - canhMC));
        }
    }
}
