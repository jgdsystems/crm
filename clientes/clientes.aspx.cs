﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using crm.dao;

public partial class clientes_clientes : System.Web.UI.Page
{

    public List<cliente> listaClientes;
    public string corfundo;

    protected void Page_Load(object sender, EventArgs e)
    {

        listaClientes = DAO.pesquisaCliente(txtSearch.Text);
        
    }
}