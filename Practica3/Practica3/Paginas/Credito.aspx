<%@ Page Title="" Language="C#" MasterPageFile="~/principal.Master" AutoEventWireup="true" CodeBehind="Credito.aspx.cs" Inherits="P3.Paginas.Credito" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style1 {
        width: 390px;
    }
    .auto-style2 {
        width: 258px;
    }
</style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
    <section class="resume-section p-3 p-lg-5 d-flex d-column" id="about">
        <div class="my-auto">
          <h1 class="mb-0">Credito</h1>
          <div class="subheading mb-5">Acreditar a la cuenta cierta suma de dinero<br />
            </div>
          
         <%-- <p class="mb-5">verall value proposition.          </p>--%>
              <table style="width:100%;">
              <tr>
                  <td class="auto-style2">No. Cuenta del usuario a acreditar</td>
                  <td class="auto-style1">
                      <asp:TextBox ID="TextBox1" runat="server" Width="187px"></asp:TextBox>
                      </td>
                  
              </tr>
              <tr>
                  <td class="auto-style2">Monto a acreditar</td>
                  <td class="auto-style1">
                      <asp:TextBox ID="TextBox2" runat="server" Width="187px"></asp:TextBox>
                    </td>
                  
              </tr>
              <tr>
                  <td class="auto-style2">Descripción del crédito</td>
                  <td class="auto-style1">
                      <asp:TextBox ID="TextBox3" runat="server" Width="382px"></asp:TextBox>
                      </td>
                  
              </tr>
              <tr>
                  <td class="auto-style2">&nbsp;</td>
                  <td class="auto-style1">
                      <br />
                      <br />
                      <asp:Label ID="Label1" runat="server" ForeColor="Red" Text="Label" Visible="False"></asp:Label>
                      <br />
                      <asp:Button ID="Button1" runat="server" CssClass="btn-success" Text="Acreditar" Width="132px" OnClick="Button1_Click" />
                      </td>
                  
              </tr>
              </table>
  
          
        </div>
      </section>

    </form>
</asp:Content>
