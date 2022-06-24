using AppModel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppModel.DAL
{
    public class LecturaDALObjetos : ILecturaDAL
    {
        private static List<Lectura> lecturas = new List<Lectura>();
        public void AgregarLectura(Lectura lectura)
        {
            Medidor medidor = new Medidor();
            lecturas.Add(lectura);
        }

        public void Eliminar(string medidoresLectura)
        {
            Lectura eliminado = lecturas.Find(c => c.MedidoresLectura == medidoresLectura);
            lecturas.Remove(eliminado);
        }

        public List<Lectura> FiltrarLecturas(string medidoresLectura)
        {
            return lecturas.FindAll(c => c.MedidoresLectura == medidoresLectura);
        }

        public List<Lectura> ObtenerLecturas()
        {
            return lecturas;
        }
    }
}
