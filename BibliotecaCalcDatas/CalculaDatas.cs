using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaCalcDatas
{
    public static class CalculaDatas
    {
        public static void Menu()
        {
            Console.WriteLine(" ----------------------------------------------------------------------------");
            Console.WriteLine("| -> 1 Calcular soma dos dias                                                |");
            Console.WriteLine("| -> 2 Calcular diferença das datas (dias)                                   |");
            Console.WriteLine("| -> 3 Calcular diferença das datas (meses)                                  |");
            Console.WriteLine("| -> 4 Calcular diferença das datas (anos)                                   |");
            Console.WriteLine("| -> 5 Calcular diferença das datas (dias, horas, minutos)                   |");
            Console.WriteLine("| -> 6 Calcular diferença das datas (meses, dias, horas minutos)             |");
            Console.WriteLine("| -> 7 Calcular diferença das datas (anos, meses, dias, horas , minutos)     |");
            Console.WriteLine("| -> 8 Calcular valor da diária de um local                                  |");
            Console.WriteLine("| -> 9 Calcular valor da diária de um local levando em consideração o horario |");
            Console.WriteLine("| -> 10 Sair do programa                                                     |");
            Console.WriteLine(" ----------------------------------------------------------------------------");
        }
        public static DateTime CalcularSomaDias(string data, int quantDias)
        {
            var dataTransformada = Convert.ToDateTime(data);
            var dataFinal = dataTransformada.AddDays(quantDias);

            return dataFinal;
        }
       public static int CalcularDiferencaDatas(string dataInicial, string dataFinal)
        {
            var dataInicial2 = Convert.ToDateTime(dataInicial);
            var dataFinal2 = Convert.ToDateTime(dataFinal);
            TimeSpan diferenca = dataFinal2.Subtract(dataInicial2);
            int dias = Convert.ToInt32(diferenca.Days);
            return dias;
        }
        public static int CalcularDiferencaDataMes(string dataInicial, string dataFinal)
        {
            var dataInicial2 = Convert.ToDateTime(dataInicial);
            var dataFinal2 = Convert.ToDateTime(dataFinal);
            TimeSpan diferenca = dataFinal2.Subtract(dataInicial2);
            int mes = Convert.ToInt32(diferenca.TotalDays/30.44);
            return mes;
        }
        public static int CalcularDiferencaDataAno(string dataInicial, string dataFinal)
        {
            var dataInicial2 = Convert.ToDateTime(dataInicial);
            var dataFinal2 = Convert.ToDateTime(dataFinal);
            TimeSpan diferenca = dataFinal2.Subtract(dataInicial2);
            int anosCompletos = Convert.ToInt32(diferenca.Days/365.25);
            return anosCompletos;
        }
        public static TimeSpan CalcularDiferencaDataHoras(string dataInicial, string dataFinal)
        {
           var dataInicial2 = Convert.ToDateTime(dataInicial);
            var dataFinal2 = Convert.ToDateTime(dataFinal);
            TimeSpan diferenca = dataFinal2.Subtract(dataInicial2);
            return diferenca;
        }
        public static double CalcularValorDaDiaria(string dataInicial, string dataFinal, double diaria)
        {
            var dataInicial2 = Convert.ToDateTime(dataInicial);
            var dataFinal2 = Convert.ToDateTime(dataFinal);
            TimeSpan diferenca = dataFinal2.Subtract(dataInicial2);
            double diferenca1 = Convert.ToDouble(diferenca.Days);
            return diaria * diferenca1;
        }
        public static double CalcularValorDaDiariaComDias(string dataInicial, string dataFinal, double valor, char parametroTempo)
        {
            var dataInicial2 = Convert.ToDateTime(dataInicial);
            var dataFinal2 = Convert.ToDateTime(dataFinal);
            TimeSpan diferenca = dataFinal2.Subtract(dataInicial2);
            double diferenca1 = Convert.ToDouble(diferenca.Days);
            
            double resultado = 0;

            if(parametroTempo == 'D' || parametroTempo == 'd')
            {
                resultado = valor * diferenca1;
              
            }
            return resultado;
        }
        public static double CalcularValorDaDiariaComHoras(string dataInicial, string dataFinal, double valor, char parametroTempo)
        {
            var dataInicial2 = Convert.ToDateTime(dataInicial);
            var dataFinal2 = Convert.ToDateTime(dataFinal);
            TimeSpan diferenca = dataFinal2.Subtract(dataInicial2);
            double diferenca2 = diferenca.TotalHours;
            

            double resultado = 0;

            if (parametroTempo == 'H' || parametroTempo == 'h')
            {
                resultado = valor * diferenca2;

            }
            return resultado;
        }
        public static double CalcularValorDaDiariaComMins(string dataInicial, string dataFinal, double valor, char parametroTempo)
        {
            var dataInicial2 = Convert.ToDateTime(dataInicial);
            var dataFinal2 = Convert.ToDateTime(dataFinal);
            TimeSpan diferenca = dataFinal2.Subtract(dataInicial2);
            double diferenca3 = diferenca.TotalMinutes;


            double resultado = 0;

            if (parametroTempo == 'M' || parametroTempo == 'm')
            {
                resultado = valor * diferenca3;

            }
            return resultado;
        }

    }
}
