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
    public partial class IngresarLectura : System.Web.UI.Page
    {
        private ILecturaDAL lecturasDAL = new LecturaDALObjetos();
        private IMedidorDAL medidoresDAL = new MedidorDALObjetos();
        private List<Medidor> medidoresL = new List<Medidor>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Medidor> medidores = medidoresDAL.ObtenerMedidores();
                this.medidorDdl.DataSource = medidores;
                this.medidorDdl.DataTextField = "numero";
                this.medidorDdl.DataValueField = "tipoTxt";
                this.medidorDdl.DataBind();
                this.medidoresL = medidores;
            }
        }
        protected void agregarLecturaBtn_Click(object sender, EventArgs e)
        {
            //FECHA ACTUAL
            DateTime fechaActual = DateTime.Now;
            //string convertirFecha = String.Format("{0:yyy-MM-dd-HH-mm-ss}", fechaActual);
            string convertirFecha = String.Format("{0:yyyy-MM-dd}", fechaActual);

            //capturamos el objeto medidor
            string medidorLectura = this.medidorDdl.SelectedValue.ToString();
            //capturamos la fecha seleccionada
            var fechaLectura = Convert.ToDateTime(this.fechaCalendar.SelectedDate.ToString());
            //capturamos la hora
            int horaLectura = Convert.ToInt32(this.horaTxt.Text.Trim());
            //capturamos los minutos
            int minutosLectura = Convert.ToInt32(this.minutosTxt.Text.Trim());
            //capturamos el consumo
            int consumoLectura = Convert.ToInt32(this.consumoTxt.Text.Trim());

            
            string lecturaValor = this.medidorDdl.SelectedValue;
            int lecturaTexto = Convert.ToInt32(this.medidorDdl.SelectedItem.Text);

            List<Lectura> lecturas = lecturasDAL.ObtenerLecturas();
            Medidor medidor = this.medidoresL.Find(b => b.Numero == lecturaTexto);

            List<Medidor> medidores = this.medidoresL;

            Lectura lectura = new Lectura()
            {
                MedidoresLectura = medidorLectura,
                FechaLectura = fechaLectura,
                HoraLectura = horaLectura,
                MinutoLectura = minutosLectura,
                ConsumoLectura = consumoLectura
            };
            lecturasDAL.AgregarLectura(lectura);
            this.mensajeLbl1.Text = "La Lectura se registro satisfactoriamente";
            Response.Redirect("VerLecturas.aspx");
        }

        protected void fechaCalendar_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}