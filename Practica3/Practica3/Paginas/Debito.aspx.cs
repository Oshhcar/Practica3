using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using P3.Clases;

namespace P3.Paginas
{
    public partial class Debito : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String cuenta = Convert.ToString(TextBox1.Text);
            String monto = Convert.ToString(TextBox2.Text);
            String descripcion = Convert.ToString(TextBox3.Text);

            SQL consulta = new SQL();
            String saldoActual = consulta.consultaSaldo(cuenta);

            //Comparar si el saldoActual >= monto. Si se hace la transacción.
            int actual = Int32.Parse(saldoActual);
            int retiro = Int32.Parse(monto);

            if(actual>=retiro)
            {
                consulta.Debitar(cuenta, descripcion, "Debito", monto);
                Label1.Text = "Se ha debitado a la cuenta exitosamente";
                Label1.Visible = true;
            }
            else
            {                
                Label1.Text = "No hay suficientes fondos para debitar dicha cantidad";
                Label1.Visible = true;
            }


        }
    }
}