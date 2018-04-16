<%@ Page Title="" Language="C#" MasterPageFile="~/principal.Master" AutoEventWireup="true" CodeBehind="Debito.aspx.cs" Inherits="P3.Paginas.Debito" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
    <section class="resume-section p-3 p-lg-5 d-flex d-column" id="about">
        <div class="my-auto">
          <h1 class="mb-0">Débito</h1>
          <div class="subheading mb-5">Debitar a la cuenta cierta suma de dinero<br />
            </div>
          
         <%-- <p class="mb-5">verall value proposition.          </p>--%>
              <table style="width:100%;">
              <tr>
                  <td class="auto-style2">No. Cuenta del usuario a debitar</td>
                  <td class="auto-style1">
                      <asp:TextBox ID="TextBox1" runat="server" Width="187px"></asp:TextBox>
                      </td>
                  
              </tr>
              <tr>
                  <td class="auto-style2">Monto a debitar</td>
                  <td class="auto-style1">
                      <asp:TextBox ID="TextBox2" runat="server" Width="187px"></asp:TextBox>
                    </td>
                  
              </tr>
              <tr>
                  <td class="auto-style2">Descripción del débito</td>
                  <td class="auto-style1">
                      <asp:TextBox ID="TextBox3" runat="server" Width="187px"></asp:TextBox>
                      </td>
                  
              </tr>
              <tr>
                  <td class="auto-style2">&nbsp;</td>
                  <td class="auto-style1">
                      <br />
                      <asp:Label ID="Label1" runat="server" ForeColor="Red" Visible="False"></asp:Label>
                      <br />
                      <asp:Button ID="Button1" runat="server" CssClass="btn-success" Text="Debitar" Width="132px" OnClick="Button1_Click" />
                      </td>
                  
              </tr>
              </table>
  
          
        </div>
      </section>

    </form>
</asp:Content>
