using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AppModel.DAL;
using AppModel.DTO;

namespace AplicacionASPBarriga
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private IMedidorDAL medidoresDAL = new MedidorDALObjetos();
            
            
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void agregarBtn_Click(object sender, EventArgs e)
        {
            //Obtenemos los datos del formulario
            int numero = Convert.ToInt32(this.numMedidorTxt.Text.Trim());
            int tipoConsumo = Convert.ToInt32(this.radioB1.SelectedItem.Value);

            Medidor medidor = new Medidor()
            {
                Numero = numero,
                TipoConsumo = tipoConsumo
            };

            //Llamamos al dal

            medidoresDAL.Agregar(medidor);
            //Mostramos 
            this.mensajeLbl.Text = "Medidor Ingresado";
            Response.Redirect("VerMedidores.aspx");

            //Construimos el objeto
            //List<Medidor> medidores = medidoresDAL.ObtenerMedidores();


            



            //DAL
            
            
        }
    }
}