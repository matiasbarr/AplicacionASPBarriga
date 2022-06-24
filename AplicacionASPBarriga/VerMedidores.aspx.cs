using AppModel.DTO;
using AppModel.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AplicacionASPBarriga
{
    public partial class VerMedidores : System.Web.UI.Page
    {
        private IMedidorDAL medidoresDAL = new MedidorDALObjetos();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargaGrilla();
            }
        }

        private void cargaGrilla()
        {
            List<Medidor> medidores = medidoresDAL.ObtenerMedidores();
            this.grillaMedidores.DataSource = medidores;
            this.grillaMedidores.DataBind();
            
        }

        private void cargaGrilla(List<Medidor> filtrada)
        {
            this.grillaMedidores.DataSource = filtrada; 
            this.grillaMedidores.DataBind();
        }

        protected void filtrarMedidorDdl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.filtrarMedidorDdl.SelectedItem != null)
            {
                int tipo = Convert.ToInt32(this.filtrarMedidorDdl.SelectedItem.Value);
                List<Medidor> filtrada = medidoresDAL.FiltrarMedidores(tipo);
                cargaGrilla(filtrada);
            }
        }


        protected void grillaMedidores_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "eliminar")
            {
                int numero = Convert.ToInt32(e.CommandArgument);
                medidoresDAL.Eliminar(numero);
                cargaGrilla();
            }
        }
    }
}