<%@ Page Title="" Language="C#" MasterPageFile="~/principal.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="P3.Paginas.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 202px;
        }
        .auto-style2 {
            width: 111px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
    <section class="resume-section p-3 p-lg-5 d-flex d-column" id="about">
        <div class="my-auto">
          <h1 class="mb-0">Login</h1>
          <div class="subheading mb-5">Ingrese sus credenciales</div>
          
         <%-- <p class="mb-5">verall value proposition.          </p>--%>
              <table style="width:100%;">
              <tr>
                  <td class="auto-style2">Código</td>
                  <td class="auto-style1">
                      <asp:TextBox ID="TextBox1" runat="server" Width="187px"></asp:TextBox>
                      </td>
                  
              </tr>
              <tr>
                  <td class="auto-style2">Usuario</td>
                  <td class="auto-style1">
                      <asp:TextBox ID="TextBox2" runat="server" Width="187px"></asp:TextBox>
                    </td>
                  
              </tr>
              <tr>
                  <td class="auto-style2">Contraseña</td>
                  <td class="auto-style1">
                      <asp:TextBox ID="TextBox3" runat="server" Width="187px"></asp:TextBox>
                      </td>
                  
              </tr>
              <tr>
                  <td class="auto-style2">&nbsp;</td>
                  <td class="auto-style1">
                      <asp:Label ID="Label1" runat="server" Enabled="False" ForeColor="Red" Text="Mensaje" Visible="False"></asp:Label>
                      <br />
                      <asp:Button ID="Button1" runat="server" CssClass="btn-success" Text="Ingresar" Width="132px" OnClick="Button1_Click" />
                      </td>
                  
              </tr>
              </table>
  
          
        </div>
      </section>

    </form>

</asp:Content>
