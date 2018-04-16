<%@ Page Title="" Language="C#" MasterPageFile="~/principal.Master" AutoEventWireup="true" CodeBehind="Transferencia.aspx.cs" Inherits="P3.Paginas.Transferencia" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style1 {
        width: 357px;
    }
    .auto-style2 {
        width: 170px;
    }
</style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
    <section class="resume-section p-3 p-lg-5 d-flex d-column" id="about">
        <div class="my-auto">
          <h1 class="mb-0">Transferencia Electrónica</h1>
          <div class="subheading mb-5">Ingrese los datos correspondientes para transferir fondos de una cuenta a otra<br />
              .</div>
          
         <%-- <p class="mb-5">verall value proposition.          </p>--%>
              <table style="width:100%;">
              <tr>
                  <td class="auto-style2">No. Cuenta Destino:</td>
                  <td class="auto-style1">
                      <asp:TextBox ID="TextBox1" runat="server" Width="185px"></asp:TextBox>
                      </td>
                  
              </tr>
              <tr>
                  <td class="auto-style2">Monto a Transferir (Q.)</td>
                  <td class="auto-style1">
                      <asp:TextBox ID="TextBox2" runat="server" Width="186px"></asp:TextBox>
                    </td>
                  
              </tr>
              <tr>
                  <td class="auto-style2">&nbsp;</td>
                  <td class="auto-style1">
                      <br />
                      <asp:Label ID="Label1" runat="server" ForeColor="Red" Visible="False"></asp:Label>
                      <br />
                      <asp:Button ID="Button1" runat="server" CssClass="btn-success" Text="Transferir" Width="132px" OnClick="Button1_Click" />
                      <br />
                      <asp:Label ID="Label2" runat="server"></asp:Label>
                      </td>
                  
              </tr>
              </table>
  
          
        </div>
      </section>

    </form>
</asp:Content>
