using AppModel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppModel.DAL
{
    public interface IMedidorDAL
    {
        List<Medidor> ObtenerMedidores();
        List<Medidor> FiltrarMedidores(int tipoConsumo);
        void Agregar (Medidor Medidor);
        void Eliminar(int numero);
    }
}
