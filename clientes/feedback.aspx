<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="feedback.aspx.cs" Inherits="clientes_feedback" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style2 {
            font-weight: bold;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p style="font-family: Arial; color: #FF0000">
        Cadastro de contato, email ou CPF já existente!</p>
    <p style="font-family: Arial; color: #FF0000">
        <strong>
        <asp:Button ID="Button1" runat="server" CssClass="auto-style2" PostBackUrl="~/clientes/editarcliente.aspx?action=1" Text="OK" Width="92px" />
        </strong>
    </p>
    <p style="font-family: Arial; color: #FF0000">
        &nbsp;</p>
</asp:Content>

