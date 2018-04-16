<%@ Page Title="" Language="C#" MasterPageFile="~/principal.Master" AutoEventWireup="true" CodeBehind="ConsultaSaldo.aspx.cs" Inherits="P3.Paginas.ConsultaSaldo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
    <section class="resume-section p-3 p-lg-5 d-flex d-column" id="about">
        <div class="my-auto">
          <h1 class="mb-0">Consulta de Saldo</h1>          
          
         <%-- <p class="mb-5">verall value proposition.          </p>--%>
              <table style="width:100%;">
              <tr>
                  <td class="auto-style2">
                      <br />
                      Cuenta</td>
                  <td class="auto-style1">
                      <br />
                      <asp:TextBox ID="TextBox1" runat="server" ReadOnly="True" Width="187px"></asp:TextBox>
                      </td>
                  
              </tr>
              <tr>
                  <td class="auto-style2">Usuario</td>
                  <td class="auto-style1">
                      <asp:TextBox ID="TextBox2" runat="server" ReadOnly="True" Width="187px"></asp:TextBox>
                    </td>
                  
              </tr>
              <tr>
                  <td class="auto-style2">Monto</td>
                  <td class="auto-style1">
                      <asp:TextBox ID="TextBox3" runat="server" ReadOnly="True" Width="187px"></asp:TextBox>
                      </td>
                  
              </tr>
              
              </table>
  
          
        </div>
      </section>

    </form>
</asp:Content>
