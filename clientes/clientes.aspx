<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="clientes.aspx.cs" Inherits="clientes_clientes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .TextoPaginas {
            font-family: Arial;
            color: #808080;
        }
        .auto-style2 {
            font-weight: bold;
        }
        .auto-style3 {
            width: 0%;
        }
        .auto-style4 {
            text-align: left;
        }
        .auto-style5 {
            width: 77%;
        }
        .auto-style6 {
            text-align: left;
            width: 245px;
        }
        .auto-style8 {
            text-align: left;
            width: 311px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <span class="TextoPaginas"><strong>Cadastro de clientes</strong></span></p>
    <p>
        <table class="auto-style3" align="center">
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Font-Names="Arial" Text="Pesquisar por contato, email ou telefone: " Width="300px"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtSearch" runat="server" Width="183px" BackColor="#FFFFCC"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="btnSearch" runat="server" style="font-weight: 700" 
                        Text="Pesquisar" Width="110px" />
                </td>
                <td>
        <strong>
        <asp:Button ID="btnNew" runat="server" CssClass="auto-style2" PostBackUrl="~/clientes/editarcliente.aspx?action=1" Text="Novo cadastro" Width="110px" />
        </strong>
                </td>
            </tr>
        </table>
    </p>
    <table align="center" border="1" class="auto-style5" style="font-family: Arial">
        <tr>
            <td class="auto-style8">
                <strong>Contato</strong></td>
            <td class="auto-style6">
                <strong>Email</strong></td>
            <td class="auto-style4">
                <strong>Telefone</strong></td>
        </tr>
        <% for (int i = 0; i < listaClientes.Count; i++)
            {
        %>
        <% corfundo = "#EAEAEA"; %>
        <tr bgcolor="<%=corfundo%>" onclick="window.open('editarcliente.aspx?id_cliente=<%=listaClientes[i].Id_cliente%>','_blank')" onmouseover="this.bgColor='#CCCCCC'" onmouseout="this.bgColor='<%=corfundo%>'">
            <td class="auto-style8"><%=listaClientes[i].Nome_contato%></td>
            <td class="auto-style6"><%=listaClientes[i].Email%></td>
            <td class="auto-style4"><%=listaClientes[i].Telefone%></td>
        </tr>
        <% 
             if(corfundo == "#FFFFFF"){
                 corfundo = "#EAEAEA";
             }else{
                 corfundo = "#FFFFFF";
             }   
            
          } %>
    </table>
    <p>
        &nbsp;</p>
</asp:Content>

