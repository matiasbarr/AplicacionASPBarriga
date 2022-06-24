using AppModel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppModel.DAL
{
    public interface ILecturaDAL
    {
        List<Lectura> ObtenerLecturas();
        List<Lectura> FiltrarLecturas(string medidoresLectura);
        void AgregarLectura(Lectura lectura);

        void Eliminar(string medidoresLectura);

        
    }
}
