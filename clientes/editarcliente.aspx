<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="editarcliente.aspx.cs" Inherits="clientes_editarcliente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        textarea {
        }
    .auto-style2 {
        text-align: left;
    }
    .auto-style3 {
        text-align: right;
    }
    .auto-style4 {
        text-align: center;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table align="center" bgcolor="#CCCCCC" cellpadding="0" cellspacing="1" style="font-family: Arial" border="0">
    <tr>
        <td class="auto-style4" colspan="5">
                &nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style4" colspan="5">
                <strong>Cadastro de cliente</strong></td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style3">
                <asp:Label ID="Label1" runat="server" Text="Código"></asp:Label>
            </td>
        <td class="auto-style2">
                <asp:Label ID="lblCodigo" runat="server"></asp:Label>
            </td>
        <td class="auto-style2">&nbsp;</td>
        <td class="auto-style3">
                <asp:Label ID="Label2" runat="server" Text="Tipo"></asp:Label>
            </td>
        <td class="auto-style2">
                <asp:DropDownList ID="dropTipo" runat="server" Width="122px">
                    <asp:ListItem Selected="True" Value="1">Cliente</asp:ListItem>
                    <asp:ListItem Value="2">Prospect</asp:ListItem>
                    <asp:ListItem Value="3">Lead</asp:ListItem>
                </asp:DropDownList>
            </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style3">
                <asp:Label ID="Label4" runat="server" Text="Contato"></asp:Label>
            </td>
        <td class="auto-style2">
                <asp:TextBox ID="txtContato" runat="server" Width="231px"></asp:TextBox>
            </td>
        <td class="auto-style2">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtContato" ErrorMessage="Preencha o campo Contato">*</asp:RequiredFieldValidator>
        </td>
        <td class="auto-style3">
                <asp:Label ID="Label3" runat="server" Text="CPF"></asp:Label>
            </td>
        <td class="auto-style2">
                <asp:TextBox ID="txtCPF" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtCPF" ErrorMessage="Preencha o campo CPF">*</asp:RequiredFieldValidator>
            </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style3">
                <asp:Label ID="Label6" runat="server" Text="Email"></asp:Label>
            </td>
        <td class="auto-style2">
                <asp:TextBox ID="txtEmail" runat="server" Width="231px"></asp:TextBox>
            </td>
        <td class="auto-style2">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtEmail" ErrorMessage="Preencha o campo Email">*</asp:RequiredFieldValidator>
        </td>
        <td class="auto-style3">
                <asp:Label ID="Label5" runat="server" Text="Data de nascimento"></asp:Label>
            </td>
        <td class="auto-style2">
                <asp:TextBox ID="txtDadaNascimento" runat="server"></asp:TextBox>
            </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style3">
                <asp:Label ID="Label8" runat="server" Text="Celular"></asp:Label>
            </td>
        <td class="auto-style2">
                <asp:TextBox ID="txtCelular" runat="server"></asp:TextBox>
            </td>
        <td class="auto-style2">&nbsp;</td>
        <td class="auto-style3">
                <asp:Label ID="Label7" runat="server" Text="Telefone"></asp:Label>
            </td>
        <td class="auto-style2">
                <asp:TextBox ID="txtTelefone" runat="server"></asp:TextBox>
            </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style3">
                <asp:Label ID="Label10" runat="server" Text="Complemento"></asp:Label>
            </td>
        <td class="auto-style2">
                <asp:TextBox ID="txtComplemento" runat="server" Width="231px"></asp:TextBox>
            </td>
        <td class="auto-style2">&nbsp;</td>
        <td class="auto-style3">
                <asp:Label ID="Label9" runat="server" Text="Rua"></asp:Label>
            </td>
        <td class="auto-style2">
                <asp:TextBox ID="txtRua" runat="server" Width="231px"></asp:TextBox>
            </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style3">
                <asp:Label ID="Label12" runat="server" Text="Bairro"></asp:Label>
            </td>
        <td class="auto-style2">
                <asp:TextBox ID="txtBairro" runat="server" Width="231px"></asp:TextBox>
            </td>
        <td class="auto-style2">&nbsp;</td>
        <td class="auto-style3">
                <asp:Label ID="Label11" runat="server" Text="Numero"></asp:Label>
            </td>
        <td class="auto-style2">
                <asp:TextBox ID="txtNumero" runat="server"></asp:TextBox>
            </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style3">
                <asp:Label ID="Label13" runat="server" Text="CEP"></asp:Label>
            </td>
        <td class="auto-style2">
                <asp:TextBox ID="txtCEP" runat="server"></asp:TextBox>
            </td>
        <td class="auto-style2">&nbsp;</td>
        <td class="auto-style3">
                <asp:Label ID="Label14" runat="server" Text="UF"></asp:Label>
            </td>
        <td class="auto-style2">
                <asp:TextBox ID="txtUF" runat="server"></asp:TextBox>
            </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style3">
                <asp:Label ID="Label16" runat="server" Text="Pais"></asp:Label>
            </td>
        <td class="auto-style2">
                <asp:TextBox ID="txtPais" runat="server"></asp:TextBox>
            </td>
        <td class="auto-style2">&nbsp;</td>
        <td class="auto-style3">
                <asp:Label ID="Label15" runat="server" Text="Municipio"></asp:Label>
            </td>
        <td class="auto-style2">
                <asp:TextBox ID="txtMunicipio" runat="server" Width="231px"></asp:TextBox>
            </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style3">
                <asp:Label ID="Label18" runat="server" Text="Pode receber email?"></asp:Label>
            </td>
        <td class="auto-style2">
                <asp:CheckBox ID="CheckBoxReceberEmail" runat="server" />
            </td>
        <td class="auto-style2">&nbsp;</td>
        <td class="auto-style3">
                <asp:Label ID="Label17" runat="server" Text="Conjuge"></asp:Label>
            </td>
        <td class="auto-style2">
                <asp:TextBox ID="txtConjuge" runat="server" Width="231px"></asp:TextBox>
            </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style4" colspan="5">
                <asp:Button ID="btnAcao" runat="server" Text="Salvar" OnClick="btnAcao_Click" Width="77px" Font-Bold="True" />
            <asp:Button ID="btnCancel" runat="server" CausesValidation="False" OnClick="btnCancel_Click" PostBackUrl="~/clientes/clientes.aspx" Text="Cancelar" Font-Bold="True" />
                <asp:Button ID="idBtnExcluir" runat="server" Font-Bold="True" ForeColor="Red" OnClick="idBtnExcluir_Click" Text="Excluir" Width="77px" />
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style3">&nbsp;</td>
        <td class="auto-style2">
                &nbsp;</td>
        <td class="auto-style2">&nbsp;</td>
        <td class="auto-style3">&nbsp;</td>
        <td class="auto-style2">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
</table>
<p>
    </p>
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowMessageBox="True" ShowSummary="False" />
</asp:Content>

