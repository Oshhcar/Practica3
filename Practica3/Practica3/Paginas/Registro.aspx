<%@ Page Title="" Language="C#" MasterPageFile="~/principal.Master" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="P3.Paginas.Registro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
    <section class="resume-section p-3 p-lg-5 d-flex d-column" id="about">
        <div class="my-auto">
          <h1 class="mb-0">Registro</h1>
          <div class="subheading mb-5">Creación de nueva cuenta</div>
          
          <p class="mb-5">Ingrese la información que se le solicita para crear una nueva cuenta:</p>
              <table style="width:100%;">
              <tr>
                  <td class="auto-style2">Nombre Completo</td>
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
                  <td class="auto-style2">Correo</td>
                  <td class="auto-style1">
                      <asp:TextBox ID="TextBox3" runat="server" Width="187px"></asp:TextBox>
                      </td>
                  
              </tr>

                  <tr>
                  <td class="auto-style2">Contraseña</td>
                  <td class="auto-style1">
                      <asp:TextBox ID="TextBox4" runat="server" Width="187px"></asp:TextBox>
                      </td>
                  
              </tr>
              <tr>
                  <td class="auto-style2">&nbsp;</td>
                  <td class="auto-style1">
                      <asp:Label ID="Label1" runat="server" Enabled="False" ForeColor="Red" Visible="False"></asp:Label>
                      <br />
                      <br />
                      <asp:Button ID="Button1" runat="server" CssClass="btn-success" Text="Ingresar" Width="132px" OnClick="Button1_Click" />
                      <br />
                      <br />
                      <asp:Button ID="Button2" runat="server" CssClass="btn-success" OnClick="Button2_Click" Text="Continuar" Width="132px" />
                      <br />
                      </td>
                  
              </tr>
              </table>
  
          
        </div>
      </section>

    </form>    
</asp:Content>
