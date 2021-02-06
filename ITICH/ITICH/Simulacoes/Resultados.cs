using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITICH
{
    public class Resultados
    {
        //classe que guarda os resultados
        public Resultados()
        {
        }

        public Resultados(int id_parques, string nome_parque, string email, double resl)
        {
            this.id_parques = id_parques;
            this.nome_parque = nome_parque;
            this.email = email;
            this.resl = resl;
        }

        public int id_parques { set; get; }
        public string nome_parque { set; get; }
        public string email { set; get; }
        public double resl { set; get; }
    }
}
