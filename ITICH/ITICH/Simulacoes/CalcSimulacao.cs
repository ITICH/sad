using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITICH.Simulacoes
{
    class CalcSimulacao
    {
        //calcula os valores de cada matriz/tabela e retorna um array com os resultados
		public static double[] CalcCriteriosAhp(double[,] imp, int n)
        {
            double mult=1;
            double[] res = new double[n];
            double[,] tabCriterios = imp;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    mult *= tabCriterios[i, j];
                }
                res[i] = mult / n;
                mult = 1;
            }

            double soma = 0;
            foreach (double val in res)
            {
                soma += val;
            }

            double[] resFinal = new double[n];
            for (int i = 0; i < n; i++)
            {
                resFinal[i] = res[i] / soma;
            }

            return resFinal;
        }

        public static double[] PreencheMatriz(int[] idParques, int[] parquesMaisImp, double imp)
        {
            double[,] matriz = new double[idParques.Length, idParques.Length];
            for (int i = 0; i < idParques.Length; i++)
            {
                for (int j = 0; j < idParques.Length; j++)
                {
                    if (j<parquesMaisImp.Length && idParques[i] == parquesMaisImp[j])
                    {
                        //matriz[j,i] = imp;
                        //matriz[i,j] = 1 / imp;
                        matriz[i, j] = imp;
                        matriz[j,i] = 1 / imp;
                    }
                    else if (i==j)
                    {
                        matriz[i,j] = 1;
                    }
                    else
                    {
                        //matriz[j,i] = 1;
                        //matriz[i,j] = 1 / 1;
                        matriz[i, j] = 1;
                        matriz[j, i] = 1 / 1;
                    }
                }
            }

            for (int i = 0; i < idParques.Length; i++)
            {
                Console.Write("\n");
                for (int j = 0; j < idParques.Length; j++)
                    Console.Write("{0}\t", matriz[i, j]);
                //Console.Write("{0}\t", i);
            }

            double[] resCaclAhpMatriz = new double[idParques.Length];
            resCaclAhpMatriz = CalcCriteriosAhp(matriz, idParques.Length);
            /*Console.Write("\n");
            Console.Write("[{0}]", string.Join(";", resCaclAhpMatriz));*/
            return resCaclAhpMatriz;
        }

        public static SortedList<int, double> CalcSimulacaoAhp(double[] resCaclCriterios, double[] resCaclMatrizLocal, double[] resCaclMatrizFase,
            double[] resCaclMatrizArea, double[] resCaclMatrizVolNeg, double[] resCaclMatrizCartInst, double[] resCaclMatrizInc, 
            double[] resCaclMatrizTipoInst, int numParques)
        {
            SortedList<int, double> resSimulacao = new SortedList<int, double>();
            //double[] resSimulacao = new double[numParques];
            int id = 1;
            for (int i = 0; i < numParques; i++)
            {
                resSimulacao.Add(id, (resCaclCriterios[0]*resCaclMatrizLocal[i]) + (resCaclCriterios[1]*resCaclMatrizFase[i]) + 
                    (resCaclCriterios[2] * resCaclMatrizArea[i]) + (resCaclCriterios[3] * resCaclMatrizVolNeg[i]) +
                    (resCaclCriterios[4] * resCaclMatrizCartInst[i]) + (resCaclCriterios[5] * resCaclMatrizInc[i]) + 
                    (resCaclCriterios[6] * resCaclMatrizTipoInst[i]));
                id++;
            }
            foreach (KeyValuePair<int, double> kvp in resSimulacao)
                Console.WriteLine("key: {0}, value: {1}", kvp.Key, kvp.Value);

            return resSimulacao;
        }

    }
}
