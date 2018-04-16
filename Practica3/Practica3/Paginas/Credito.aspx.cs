using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using P3.Clases;

namespace P3.Paginas
{
    public partial class Credito : System.Web.UI.Page
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
            consulta.Acreditar(cuenta, descripcion, "Credito", monto);
            Label1.Text = "Se ha acreditado a la cuenta exitosamente";
            Label1.Visible = true;
            

        }
    }
}

