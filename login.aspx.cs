using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using crm.dao;

public partial class _Default : System.Web.UI.Page 
{
    
    
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {

        //Verifica autenticação do usuário
        if (DAO.isUser(txtUser.Text, txtPassword.Text))
        {
            Session["user"] = txtUser.Text;
            Response.Redirect("~/Default.aspx");
        }
        else {
            lblError.Visible = true;
            Session.Abandon();
        }
        
    }
}