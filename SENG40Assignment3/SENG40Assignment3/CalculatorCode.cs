using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SENG40Assignment3
{
   public class CalculatorCode
    {

        private double fno;

        private double sno;

        public CalculatorCode()
        {

            fno = 1;
            sno = 1;

        }

        public CalculatorCode(double fno, double sno)
        {

            this.fno = fno;
            this.sno = sno;
        }

        public double PrintFno()
        {

            return fno;

        }
        public double PrintSno()
        {

            return sno;

        }
        public double SetFno(double fno)
        {

            this.fno = fno;
            return this.fno;

        }

        public double SetSno(double sno)
        {
            this.sno = sno;
            return this.sno;
        }

        public double DoAddition()
        {

            return Math.Round((fno + sno), 2);

        }

        public double DoSubtraction()
        {

            return Math.Round((fno - sno), 2);

        }
        public double DoMultiplication()
        {

            return Math.Round((fno * sno), 2);

        }

        public double DoDivision()
        {
            try {

                return Math.Round((fno / sno), 2);

            }
            catch (DivideByZeroException) {

                return (0);

            }

        }
    }
}
