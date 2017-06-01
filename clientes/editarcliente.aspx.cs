using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using crm.dao;

public partial class clientes_editarcliente : System.Web.UI.Page
{
    string action = "";
    string id_cliente = "";

   
    protected void Page_Load(object sender, EventArgs e)
    {
        //try
        //{
            action = Request["action"];
            id_cliente = Request["id_cliente"];

            //Seleciona os registros de um cliente
            if (id_cliente != null)
            {

                if (!Page.IsPostBack)
                {
                    cliente objCliente = DAO.selecionaCliente(id_cliente);

                    lblCodigo.Text = objCliente.Id_cliente;
                    dropTipo.SelectedValue = objCliente.Tipo;
                    txtCPF.Text = objCliente.CPF;
                    txtContato.Text = objCliente.Nome_contato;
                    txtDadaNascimento.Text = objCliente.Data_nascimento;
                    txtEmail.Text = objCliente.Email;
                    txtTelefone.Text = objCliente.Telefone;
                    txtCelular.Text = objCliente.Celular;
                    txtRua.Text = objCliente.Rua;
                    txtComplemento.Text = objCliente.Complemento;
                    txtNumero.Text = objCliente.Numero;
                    txtBairro.Text = objCliente.Bairro;
                    txtCEP.Text = objCliente.CEP;
                    txtUF.Text = objCliente.UF;
                    txtMunicipio.Text = objCliente.Municipio;
                    txtPais.Text = objCliente.Pais;
                    txtConjuge.Text = objCliente.Conjuge;

                    if (objCliente.Receber_email == "1")
                    {
                        CheckBoxReceberEmail.Checked = true;
                    }
                    else
                    {
                        CheckBoxReceberEmail.Checked = false;
                    }
                }
                
            }

        if (action == "1")
        {
            idBtnExcluir.Visible = false;
        }


            //}
            //catch (Exception)
            //{
            //    Response.Redirect("~/login.aspx");
            //}

        }
    protected void btnAcao_Click(object sender, EventArgs e)
    {
        string receberEmail = "0";
        if (CheckBoxReceberEmail.Checked) {
            receberEmail = "1";
        }
        
        
        if (action == "1")
        {
            if (DAO.existeCliente(txtContato.Text, txtEmail.Text, txtCPF.Text))
            {
                Response.Redirect("~/clientes/feedback.aspx");
            }
            else
            {

                DAO.insereCliente(dropTipo.SelectedValue, txtCPF.Text, txtContato.Text, txtDadaNascimento.Text,
                    txtEmail.Text, txtTelefone.Text, txtCelular.Text, txtRua.Text, txtComplemento.Text, txtNumero.Text,
                    txtBairro.Text, txtCEP.Text, txtUF.Text, txtMunicipio.Text, txtPais.Text, txtConjuge.Text, receberEmail);
            }


        }
        if (id_cliente != null)
        {
                
            DAO.editaCliente(id_cliente, dropTipo.SelectedValue, txtCPF.Text, txtContato.Text, txtDadaNascimento.Text,
                txtEmail.Text, txtTelefone.Text, txtCelular.Text, txtRua.Text, txtComplemento.Text, txtNumero.Text,
                txtBairro.Text, txtCEP.Text, txtUF.Text, txtMunicipio.Text, txtPais.Text, txtConjuge.Text, receberEmail);

            Response.Redirect("~/clientes/clientes.aspx");
        }
        
        
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        
    }

    protected void idBtnExcluir_Click(object sender, EventArgs e)
    {
        DAO.excluirCliente(id_cliente);
        Response.Redirect("~/clientes/clientes.aspx");
    }
}