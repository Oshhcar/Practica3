using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using P3.Clases;

namespace P3.Paginas
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "";
            Label1.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String codigo = Convert.ToString(TextBox1.Text);
            String usuario = Convert.ToString(TextBox2.Text);
            String contraseña = Convert.ToString(TextBox3.Text);
            int bandera;

            Usuario user = new Usuario();
            bandera = user.Login(codigo, usuario, contraseña);

            switch(bandera){
                //1 = correcta
                //0 = incorrecta
                //2 = no existe nombre de usuario o cuenta. 
                case 1:
                    System.Diagnostics.Debug.Write("Credenciales válidas");
                    Session["Codigo"] = codigo;
                    Session["Usuario"] = usuario;
                    Response.Write("<script>window.alert('Credenciales válidas');</script>");
                    Response.Redirect("/Paginas/ConsultaSaldo.aspx", true);
                    break;
                case 0:
                    System.Diagnostics.Debug.Write("Credenciales incorrectas");
                    Response.Write("<script>window.alert('Credenciales incorrectas');</script>");
                    Label1.Text ="Credenciales incorrectas";
                    Label1.Visible = true;
                    break;
                case 2:
                    System.Diagnostics.Debug.Write("No existe número de cuenta");
                    Response.Write("<script>window.alert('No existe número de cuenta');</script>");
                    Label1.Text = "No existe número de cuenta";
                    Label1.Visible = true;
                    break;
            } 
           



        }
    }
}