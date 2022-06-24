using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppModel.DTO
{
    public class Lectura
    {
        private string medidoresLectura;
        private DateTime fechaLectura;
        private int horaLectura;
        private int minutoLectura;
        private int consumoLectura;

        public string MedidoresLectura { get => medidoresLectura; set => medidoresLectura = value; }
        public DateTime FechaLectura { get => fechaLectura; set => fechaLectura = value; }
        public int HoraLectura { get => horaLectura; set => horaLectura = value; }
        public int MinutoLectura { get => minutoLectura; set => minutoLectura = value; }
        public int ConsumoLectura { get => consumoLectura; set => consumoLectura = value; }
    }
}
