<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="login.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>CRM - Login de acesso </title>
    <style type="text/css">
        .style1
        {
            width: 91%;
            background-color: #F6F7F9;
        }
        .style3
        {
            width: 41px;
        }
        .style5
        {
            font-family: Arial;
        }
        .style7
        {
            background-color: #F6F7F9;
        }
        .style8
        {
        }
        .style9
        {
            background-color: #FFFFFF;
        }
        .style10
        {
            width: 341px;
        }
        .style11
        {
            font-family: Arial;
            font-size: small;
            color: #999999;
        }
    </style>
</head>
<body>
    <p style="text-align: center">
        &nbsp;<p style="text-align: center">
        <span style="color: rgb(34, 34, 34); font-family: arial, sans-serif; font-size: 16px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: normal; letter-spacing: normal; orphans: 2; text-align: left; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">
             <form id="form1" runat="server">
    <div style="text-align: center">
             <table align="center" cellpadding="0" border="0" 
                 style="border-style: none; width: 734px; height: 0px;">
                 <tr>
                     <td class="style8" colspan="2">
        <span style="color: rgb(34, 34, 34); font-family: arial, sans-serif; font-size: 16px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: normal; letter-spacing: normal; orphans: 2; text-align: left; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">
        <span style="color: rgb(34, 34, 34); font-size: 16px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: normal; letter-spacing: normal; orphans: 2; text-align: left; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(246, 247, 249); text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;" 
                             class="style5">
                         <strong><span class="style9">Gestão de Relacionamento com o Cliente</span></strong></span></span></td>
                 </tr>
                 <tr>
                     <td class="style8" colspan="2">
                         &nbsp;</td>
                 </tr>
                 <tr>
                     <td class="style10" bgcolor="#F6F7F9" colspan="0" rowspan="0">
                         <asp:Image ID="Image1" runat="server" Height="218px" 
                             ImageUrl="~/Images/CRM.jpg" Width="321px" />
                         <span style="color: rgb(34, 34, 34); font-family: arial, sans-serif; font-size: 16px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: normal; letter-spacing: normal; orphans: 2; text-align: left; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(246, 247, 249); text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">
                         <br />
                         </span>
                     </td>
                     <td bgcolor="#F6F7F9" colspan="0" rowspan="0">
                         <table class="style1" >
                             <tr>
                                 <td style="text-align: right">
                                     <asp:Label ID="lblUser" runat="server" style="font-family: Arial" Text="Email"></asp:Label>
                                 </td>
                                 <td class="style3" style="text-align: left">
                                     <asp:TextBox ID="txtUser" runat="server" 
                                         style="text-align: left; font-family: Arial" Width="150px"></asp:TextBox>
                                 </td>
                                 <td style="text-align: left" class="style7">
                                     <span style="color: rgb(34, 34, 34); font-family: arial, sans-serif; font-size: 16px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: normal; letter-spacing: normal; orphans: 2; text-align: left; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px;  text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">
                                     <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                         ControlToValidate="txtUser" ErrorMessage="Informe o seu email">*</asp:RequiredFieldValidator>
                                     <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                                         ControlToValidate="txtUser" ErrorMessage="Formato de email inválido" 
                                         ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                                         BackColor="#F6F7F9">*</asp:RegularExpressionValidator>
             </span>
                                 </td>
                             </tr>
                             <tr>
                                 <td style="text-align: right">
                                     <asp:Label ID="lblPassword" runat="server" style="font-family: Arial" 
                                         Text="Senha"></asp:Label>
                                 </td>
                                 <td class="style3" style="text-align: left">
                                     <asp:TextBox ID="txtPassword" runat="server" style="font-family: Arial" 
                                         TextMode="Password" Width="150px"></asp:TextBox>
                                 </td>
                                 <td style="text-align: left" class="style7">
                                     <span style="color: rgb(34, 34, 34); font-family: arial, sans-serif; font-size: 16px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: normal; letter-spacing: normal; orphans: 2; text-align: left; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">
                                     <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                         ControlToValidate="txtPassword" ErrorMessage="Informe a sua senha">*</asp:RequiredFieldValidator>
             </span>
                                 </td>
                             </tr>
                             <tr>
                                 <td>
                                     &nbsp;</td>
                                 <td class="style3" style="text-align: left">
                                     <asp:Button ID="btnLogin" runat="server" onclick="btnLogin_Click" 
                                         Text="Login" />
                                 </td>
                                 <td class="style7">
                                     &nbsp;</td>
                             </tr>
                             <tr>
                                 <td colspan="3">
        <span style="color: rgb(34, 34, 34); font-family: arial, sans-serif; font-size: 16px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: normal; letter-spacing: normal; orphans: 2; text-align: left; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">
                                     <asp:Label ID="lblError" runat="server" 
                                         style="font-size: small; text-align: center; color: #FF0000" 
                                         Text="Email ou senha incorreta" Visible="False"></asp:Label>
             </span>
                                 </td>
                             </tr>
                         </table>
                     </td>
                 </tr>
                 </table>
    </div>
             </span>
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
        ShowMessageBox="True" ShowSummary="False" 
        style="text-align: center; font-family: Arial" />
    <p style="text-align: center">
        <span class="style11"><strong>Desenvolvido por Julio Duarte e Luis Mello 
        </strong></span><strong>
        <br class="style11" />
        </strong><span class="style11"><strong>Graduação de Sistemas de Informação - 
        UNISINOS</strong></span></p>
             <p style="text-align: center">
                 &nbsp;</p>
    </form>
    </body>
</html>
