using AppModel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppModel.DAL
{
    public class MedidorDALObjetos : IMedidorDAL
    {
        private static List<Medidor> medidores = new List<Medidor>();

        public void Agregar(Medidor medidor)
        {
            medidores.Add(medidor);
        }

        public void Eliminar(int numero)
        {
            Medidor eliminado = medidores.Find(c => c.Numero == numero);
            medidores.Remove(eliminado);
        }

        public List<Medidor> FiltrarMedidores(int tipoConsumo)
        {
            return medidores.FindAll(c => c.TipoConsumo == tipoConsumo);

        }

        public List<Medidor> ObtenerMedidores()
        {
            return medidores;
        }
    }
}
