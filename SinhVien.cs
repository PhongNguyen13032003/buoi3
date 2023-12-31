﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi3
{
    class SinhVien
    {
        private int maSV;
        private string hoTen;
        private double diemLT;

        public double DiemLT
        {
            get { return diemLT; }
            set { if(diemLT > 0 && diemLT < 10)
                    diemLT=value;
                  else diemLT= 0;}
        }
        private double diemTH;
        public double DiemTH
        {
            get { return diemTH; }
            set { if(diemTH > 0 && diemTH < 10)
                    diemTH = value;
                else diemTH = 0;
            }
        }
        private double diemTB;
        public double DiemTB
        {
            get { return DiemTB; }
            set{ if(DiemTB > 0 && DiemTB < 10)
                   DiemTB = value;
                else DiemTB = 0;
            }
        }

        public SinhVien()
        {
            maSV = 011;
            hoTen = "Nguyen Van A";
            diemLT = 4.5;
            diemTH = 7.5;
        }
        public SinhVien(int maSV, string hoTen, double diemLT, double diemTH)
        {
            this.maSV = maSV;
            this.hoTen = hoTen;
            this.diemLT = diemLT;
            this.diemTH = diemTH;
        }
        public double diemTB()
        {
            return (diemLT + diemTH) / 2;
        }
        public override string ToString()
        {
            return string.Format("{0,-10}{1,-20}{2,-10}{3,-10}{4,-10}", maSV, hoTen, diemLT.ToString("F2"), diemTH.ToString("F2"), DiemTB.ToString("F2"));
        }
    }
}
