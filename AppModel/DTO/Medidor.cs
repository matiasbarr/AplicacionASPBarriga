using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppModel.DTO
{
    public class Medidor
    {
        private int numero;
        private int valorConsumo;
        private int tipoConsumo;
        public string TipoTxt
        {
            get
            {
                string tipoTxt = "";
                switch (TipoConsumo)
                {
                    case 1:
                        tipoTxt = "Analogo";
                        break;
                    case 2:
                        tipoTxt = "Digital";
                        break ;
                }
                return tipoTxt;
            }
        }

        public int Numero { get => numero; set => numero = value; }
        public int ValorConsumo { get => valorConsumo; set => valorConsumo = value; }
        public int TipoConsumo { get => tipoConsumo; set => tipoConsumo = value; }
    }
}
