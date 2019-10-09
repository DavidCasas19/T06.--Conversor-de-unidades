using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convertidor_de_unidades
{
    public class Operaciones
    {
        //Cm-M= cm/100
        //M-Pulg=M*39.37
        //L-ML=L*1000
    
        //Hacemos las operaciones con sobreca
        public double Convertir(double Cm)
        {
            double res = Cm / 100;
            return res;
        }
        public double Convertir(double M, double pulg)
        {
            double res = M * pulg;
            return res;
        }
        public double Convertir(double L, double B, double ML)
        {
            double res = L * B * ML;
            return res;
        }
    }
}
