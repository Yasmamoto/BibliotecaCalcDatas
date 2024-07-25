using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaCalcDatas
{
    public static class CalcDatas
    {
        public static DateTime CalcularSomaData(string data, int quantDias)
        {
            DateTime dataTransformada = Convert.ToDateTime(data);
            DateTime dataFinal = dataTransformada.AddDays(quantDias);

            return dataFinal;
        }
    }
}
