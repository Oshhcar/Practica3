using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using P3.Clases;

namespace P3.Paginas
{
    public partial class Transferencia : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string usuarioactual = (string)(Session["Usuario"]);
            string cuentaActual = (string)(Session["Codigo"]);
            Label2.Text = cuentaActual;
            Label2.Visible = true;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Variables de sesión
            string usuarioactual = (string)(Session["Usuario"]);
            string cuentaActual = (string)(Session["Codigo"]);
            Label2.Text = cuentaActual;
            Label2.Visible = true;
            
            String cuenta = Convert.ToString(TextBox1.Text);
            String monto = Convert.ToString(TextBox2.Text);

            SQL consulta = new SQL();
            String saldoActual = consulta.consultaSaldo(cuentaActual);

            //Comparar si el saldoActual >= monto. Si se hace la transacción.
            int actual = Int32.Parse(saldoActual);
            int transferencia = Int32.Parse(monto);

            if (actual >= transferencia)
            {                
                consulta.Transferencia(cuentaActual, cuenta, monto);
                Label1.Text = "Transferencia realizada exitosamente";
                Label1.Visible = true;
            }
            else
            {
                Label1.Text = "No hay suficientes fondos para hacer transferewncia";
                Label1.Visible = true;
            }
        }
    }
}