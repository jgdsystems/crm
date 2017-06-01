using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using MySql.Data.MySqlClient;

namespace crm.dao
{
    /// <summary>
    /// Descrição resumida de DAO
    /// </summary>
    public static class DAO
    {

       
        /// <summary>
        /// Get Connection
        /// </summary>
        public static MySqlConnection Connection()
        {
           
            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString;

            //Ambiente de desenvolvimento
            myConnectionString = "server=localhost;uid=sa;pwd=ursopeludo;database=CRM";

           

            conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = myConnectionString;
            return conn;
          

        }

        /// <summary>
        /// User verify
        /// </summary>
        /// <param name="user"></param>
        /// <param name="password"></param>
        /// <returns>boolean value</returns>
        public static Boolean isUser(String user, String password)
        {
            Boolean response = false;
            //abre a conexao
            MySqlConnection mConn = Connection();
            mConn.Open();
            try
            {
                //verificva se a conexão esta aberta
                if (mConn.State == ConnectionState.Open)
                {
                    MySqlCommand cmd = new MySqlCommand();
                    string sql = @"select count(*) total from users where email = ?user and password = ?password";
                    cmd.CommandText = sql;
                    
                    //Definição de parâmetros
                    MySqlParameter prUser = createParamMySQLTypeString("user", user, cmd);
                    cmd.Parameters.Add(prUser);

                    MySqlParameter prPassword = createParamMySQLTypeString("password", password, cmd);
                    cmd.Parameters.Add(prPassword);

                    cmd.Connection = mConn;

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int total = reader.GetInt32(0);
                            if (total > 0)
                            {
                                response = true;
                            }
                            
                        }
                        reader.Close();
                    }
                }

                return response;
            }
            catch (Exception)
            {
                mConn.Close();
                return response;
            }
        }


        /// <summary>
        /// Inserir cliente
        /// </summary>
        /// <param name="tipo"></param>
        /// <param name="cpf"></param>
        /// <param name="nome_contato"></param>
        /// <param name="data_nascimento"></param>
        /// <param name="email"></param>
        /// <param name="telefone"></param>
        /// <param name="celular"></param>
        /// <param name="rua"></param>
        /// <param name="complemento"></param>
        /// <param name="numero"></param>
        /// <param name="bairro"></param>
        /// <param name="CEP"></param>
        /// <param name="UF"></param>
        /// <param name="municipio"></param>
        /// <param name="pais"></param>
        /// <param name="Conjuge"></param>
        /// <param name="receber_email"></param>
        public static void insereCliente(
            
            string tipo, 
            string cpf,
            string nome_contato,
            string data_nascimento,
            string email,
            string telefone,
            string celular,
            string rua,
            string complemento,
            string numero,
            string bairro,
            string CEP,
            string UF,
            string municipio,
            string pais,
            string Conjuge,
            string receber_email
            
            ) {
            //abre a conexao
            MySqlConnection mConn = Connection();
            mConn.Open();
            //try
            //{
                //verificva se a conexão esta aberta
                if (mConn.State == ConnectionState.Open)
                {
                    MySqlCommand cmd = new MySqlCommand();

                   

                    String sql = @"insert into clientes 
                                    (
                                        tipo,
                                        CPF,
                                        nome_contato,
                                        data_nascimento,
                                        email,
                                        telefone,
                                        celular,
                                        rua,
                                        complemento,
                                        numero,
                                        bairro,
                                        CEP,
                                        UF,
                                        municipio,
                                        pais,
                                        Conjuge,
                                        receber_email
                                    ) 
                                    values 
                                    (
                                        ?tipo,
                                        ?CPF,
                                        ?nome_contato,
                                        ?data_nascimento,
                                        ?email,
                                        ?telefone,
                                        ?celular,
                                        ?rua,
                                        ?complemento,
                                        ?numero,
                                        ?bairro,
                                        ?CEP,
                                        ?UF,
                                        ?municipio,
                                        ?pais,
                                        ?Conjuge,
                                        ?receber_email
                                    )";
                    cmd.CommandText = sql;

                    //Definição de parâmetros
                    MySqlParameter prTipo = createParamMySQLTypeString("tipo", tipo,  cmd);
                    cmd.Parameters.Add(prTipo);

                    MySqlParameter prCPF = createParamMySQLTypeString("CPF", cpf,  cmd);
                    cmd.Parameters.Add(prCPF);

                    MySqlParameter prNomeContato = createParamMySQLTypeString("nome_contato", nome_contato,  cmd);
                    cmd.Parameters.Add(prNomeContato);

                    MySqlParameter prDataNascimento = createParamMySQLTypeString("data_nascimento", data_nascimento,  cmd);
                    cmd.Parameters.Add(prDataNascimento);

                    MySqlParameter prEmail = createParamMySQLTypeString("email", email,  cmd);
                    cmd.Parameters.Add(prEmail);

                    MySqlParameter prTelefone = createParamMySQLTypeString("telefone", telefone,  cmd);
                    cmd.Parameters.Add(prTelefone);

                    MySqlParameter prCelular = createParamMySQLTypeString("celular", celular,  cmd);
                    cmd.Parameters.Add(prCelular);

                    MySqlParameter prRua = createParamMySQLTypeString("rua", rua,  cmd);
                    cmd.Parameters.Add(prRua);

                    MySqlParameter prComplemento = createParamMySQLTypeString("complemento", complemento,  cmd);
                    cmd.Parameters.Add(prComplemento);

                    if (numero == "")
                    {
                        numero = "0";
                    }
                    MySqlParameter prNumero = createParamMySQLTypeNumber("numero", Int32.Parse(numero), cmd);
                    cmd.Parameters.Add(prNumero);

                    MySqlParameter prBairro = createParamMySQLTypeString("bairro", bairro,  cmd);
                    cmd.Parameters.Add(prBairro);

                    MySqlParameter prCEP = createParamMySQLTypeString("CEP", CEP, cmd);
                    cmd.Parameters.Add(prCEP);

                    MySqlParameter prUF = createParamMySQLTypeString("UF", UF, cmd);
                    cmd.Parameters.Add(prUF);

                    MySqlParameter prMunicipio = createParamMySQLTypeString("municipio", municipio, cmd);
                    cmd.Parameters.Add(prMunicipio);

                    MySqlParameter prPais = createParamMySQLTypeString("pais", pais, cmd);
                    cmd.Parameters.Add(prPais);

                    MySqlParameter prConjuge = createParamMySQLTypeString("conjuge", Conjuge, cmd);
                    cmd.Parameters.Add(prConjuge);

                    MySqlParameter prReceberEmail = createParamMySQLTypeString("receber_email", receber_email, cmd);
                    cmd.Parameters.Add(prReceberEmail);



                    cmd.Connection = mConn;
                    cmd.ExecuteNonQuery();
                    mConn.Close();

                }

            //}
            //catch (Exception)
            //{
            //    mConn.Close();
            //}
            //finally{
            //    mConn.Close();
            //}
        }

       

        /// <summary>
        /// Verifica se um cadastro de cliente já existe
        /// </summary>
        /// <param name="contato"></param>
        /// <param name="email"></param>
        /// <param name="cpf"></param>
        /// <returns>Boolean</returns>
        public static Boolean existeCliente(String contato, String email, String cpf)
        {
            Boolean response = false;
            //abre a conexao
            MySqlConnection mConn = Connection();
            mConn.Open();
            try
            {
                //verificva se a conexão esta aberta
                if (mConn.State == ConnectionState.Open)
                {
                    MySqlCommand cmd = new MySqlCommand();
                    string sql = @"select count(*) total from clientes where nome_contato = ?contato and email = ?email and cpf = ?cpf";
                    cmd.CommandText = sql;

                    //Definição de parâmetros
                    MySqlParameter prContato = createParamMySQLTypeString("contato", contato, cmd);
                    cmd.Parameters.Add(prContato);

                    MySqlParameter prEmail = createParamMySQLTypeString("email", email, cmd);
                    cmd.Parameters.Add(prEmail);

                    MySqlParameter prCPF = createParamMySQLTypeString("cpf", cpf, cmd);
                    cmd.Parameters.Add(prCPF);

                    cmd.Connection = mConn;

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int total = reader.GetInt32(0);
                            if (total > 0)
                            {
                                response = true;
                            }

                        }
                        reader.Close();
                    }
                }

                return response;
            }
            catch (Exception)
            {
                mConn.Close();
                return response;
            }
        }

        /// <summary>
        /// Realiza a atualização de um registro de cliente
        /// </summary>
        /// <param name="id_cliente"></param>
        /// <param name="tipo"></param>
        /// <param name="cpf"></param>
        /// <param name="nome_contato"></param>
        /// <param name="data_nascimento"></param>
        /// <param name="email"></param>
        /// <param name="telefone"></param>
        /// <param name="celular"></param>
        /// <param name="rua"></param>
        /// <param name="complemento"></param>
        /// <param name="numero"></param>
        /// <param name="bairro"></param>
        /// <param name="CEP"></param>
        /// <param name="UF"></param>
        /// <param name="municipio"></param>
        /// <param name="pais"></param>
        /// <param name="Conjuge"></param>
        /// <param name="receber_email"></param>
        public static void editaCliente(

            string id_cliente,
            string tipo,
            string cpf,
            string nome_contato,
            string data_nascimento,
            string email,
            string telefone,
            string celular,
            string rua,
            string complemento,
            string numero,
            string bairro,
            string CEP,
            string UF,
            string municipio,
            string pais,
            string Conjuge,
            string receber_email

            )
        {
            //abre a conexao
            MySqlConnection mConn = Connection();
            mConn.Open();
            //try
            //{
                //verificva se a conexão esta aberta
                if (mConn.State == ConnectionState.Open)
                {
                    MySqlCommand cmd = new MySqlCommand();



                    String sql = @"
                                    UPDATE clientes
                                    SET
                                        tipo = ?tipo,
                                        CPF = ?CPF,
                                        nome_contato = ?nome_contato,
                                        data_nascimento = ?data_nascimento,
                                        email = ?email,
                                        telefone = ?telefone,
                                        celular = ?celular,
                                        rua = ?rua,
                                        complemento = ?complemento,
                                        numero = ?numero,
                                        bairro = ?bairro,
                                        CEP = ?CEP,
                                        UF = ?UF,
                                        municipio = ?municipio,
                                        pais = ?pais,
                                        Conjuge = ?Conjuge,
                                        receber_email = ?receber_email
                                    WHERE id_cliente = ?id_cliente
                                    ";
                    cmd.CommandText = sql;

                    //Definição de parâmetros
                    MySqlParameter prIdCliente = createParamMySQLTypeString("id_cliente", id_cliente, cmd);
                    cmd.Parameters.Add(prIdCliente);

                    MySqlParameter prTipo = createParamMySQLTypeString("tipo", tipo, cmd);
                    cmd.Parameters.Add(prTipo);

                    MySqlParameter prCPF = createParamMySQLTypeString("CPF", cpf, cmd);
                    cmd.Parameters.Add(prCPF);

                    MySqlParameter prNomeContato = createParamMySQLTypeString("nome_contato", nome_contato, cmd);
                    cmd.Parameters.Add(prNomeContato);

                    MySqlParameter prDataNascimento = createParamMySQLTypeString("data_nascimento", data_nascimento, cmd);
                    cmd.Parameters.Add(prDataNascimento);

                    MySqlParameter prEmail = createParamMySQLTypeString("email", email, cmd);
                    cmd.Parameters.Add(prEmail);

                    MySqlParameter prTelefone = createParamMySQLTypeString("telefone", telefone, cmd);
                    cmd.Parameters.Add(prTelefone);

                    MySqlParameter prCelular = createParamMySQLTypeString("celular", celular, cmd);
                    cmd.Parameters.Add(prCelular);

                    MySqlParameter prRua = createParamMySQLTypeString("rua", rua, cmd);
                    cmd.Parameters.Add(prRua);

                    MySqlParameter prComplemento = createParamMySQLTypeString("complemento", complemento, cmd);
                    cmd.Parameters.Add(prComplemento);

                    if(numero == "")
                    {
                        numero = "0";
                    }
                    MySqlParameter prNumero = createParamMySQLTypeNumber("numero", Int32.Parse(numero), cmd);
                    cmd.Parameters.Add(prNumero);

                    MySqlParameter prBairro = createParamMySQLTypeString("bairro", bairro, cmd);
                    cmd.Parameters.Add(prBairro);

                    MySqlParameter prCEP = createParamMySQLTypeString("CEP", CEP, cmd);
                    cmd.Parameters.Add(prCEP);

                    MySqlParameter prUF = createParamMySQLTypeString("UF", UF, cmd);
                    cmd.Parameters.Add(prUF);

                    MySqlParameter prMunicipio = createParamMySQLTypeString("municipio", municipio, cmd);
                    cmd.Parameters.Add(prMunicipio);

                    MySqlParameter prPais = createParamMySQLTypeString("pais", pais, cmd);
                    cmd.Parameters.Add(prPais);

                    MySqlParameter prConjuge = createParamMySQLTypeString("conjuge", Conjuge, cmd);
                    cmd.Parameters.Add(prConjuge);

                    MySqlParameter prReceberEmail = createParamMySQLTypeString("receber_email", receber_email, cmd);
                    cmd.Parameters.Add(prReceberEmail);
                    
                    cmd.Connection = mConn;
                    cmd.ExecuteNonQuery();
                    mConn.Close();

            }

            //}
            //catch (Exception)
            //{
            //    mConn.Close();
            //}
            //finally
            //{
            //    mConn.Close();
            //}
        }

        /// <summary>
        /// Seleciona registros de um cliente
        /// </summary>
        /// <param name="id_cliente"></param>
        /// <returns>Objeto instanciado com a classe cliente</returns>
        public static cliente selecionaCliente(string id_cliente)
        {
            //Definição do objeto cliente
            cliente objCliente = new cliente();
            objCliente.Id_cliente = id_cliente;

            //abre a conexao
            MySqlConnection mConn = Connection();
            mConn.Open();
            try
            {
                //verificva se a conexão esta aberta
                if (mConn.State == ConnectionState.Open)
                {
                    MySqlCommand cmd = new MySqlCommand();
                    string sql = @"select * from clientes where id_cliente = ?id_cliente";
                    cmd.CommandText = sql;
                    MySqlParameter prIdCliente = createParamMySQLTypeString("id_cliente", id_cliente.ToString(), cmd);
                    cmd.Parameters.Add(prIdCliente);
                    cmd.Connection = mConn;

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (!reader.IsDBNull(1))
                            {
                                objCliente.Tipo = reader.GetString("tipo");
                            }

                            if (!reader.IsDBNull(2))
                            {
                                objCliente.CPF = reader.GetString("CPF");
                            }

                            if (!reader.IsDBNull(3))
                            {
                                objCliente.Nome_contato = reader.GetString("nome_contato");
                            }

                            if (!reader.IsDBNull(4))
                            {
                                objCliente.Data_nascimento = reader.GetString("data_nascimento");
                            }
                            if (!reader.IsDBNull(5))
                            {
                                objCliente.Email = reader.GetString("email");
                            }

                            if (!reader.IsDBNull(6))
                            {
                                objCliente.Telefone = reader.GetString("telefone");
                            }

                            if (!reader.IsDBNull(7))
                            {
                                objCliente.Celular = reader.GetString("celular");
                            }

                            if (!reader.IsDBNull(8))
                            {
                                objCliente.Rua = reader.GetString("rua");
                            }

                            if (!reader.IsDBNull(9))
                            {
                                objCliente.Complemento = reader.GetString("complemento");
                            }

                            if (!reader.IsDBNull(10))
                            {
                                objCliente.Numero = reader.GetString("numero");
                            }

                            if (!reader.IsDBNull(11))
                            {
                                objCliente.Bairro = reader.GetString("bairro");
                            }

                            if (!reader.IsDBNull(12))
                            {
                                objCliente.CEP = reader.GetString("CEP");
                            }

                            if (!reader.IsDBNull(13))
                            {
                                objCliente.UF = reader.GetString("UF");
                            }

                            if (!reader.IsDBNull(14))
                            {
                                objCliente.Municipio = reader.GetString("municipio");
                            }

                            if (!reader.IsDBNull(15))
                            {
                                objCliente.Pais = reader.GetString("pais");
                            }

                            if (!reader.IsDBNull(16))
                            {
                                objCliente.Conjuge = reader.GetString("Conjuge");
                            }

                            if (!reader.IsDBNull(17))
                            {
                                objCliente.Receber_email = reader.GetString("receber_email");
                            }
                        }
                        reader.Close();
                    }
                }

                return objCliente;
             
            }
            catch (Exception)
            {
                mConn.Close();
                return objCliente;
            }
        }


        /// <summary>
        /// Realiza pesquisa de clientes
        /// </summary>
        /// <param name="pesquisa"></param>
        /// <returns> List<cliente> </returns>
        public static List<cliente> pesquisaCliente(string pesquisa)
        {
           
            //Definição de lista de clientes
            List<cliente> listaCliente = new List<cliente>();

            //objCliente.Id_cliente = id_cliente;

            //abre a conexao
            MySqlConnection mConn = Connection();
            mConn.Open();
            //try
            //{
                //verificva se a conexão esta aberta
                if (mConn.State == ConnectionState.Open)
                {
                    MySqlCommand cmd = new MySqlCommand();
                    
                    string sql = @"select * from clientes";
                    if (pesquisa != "" && pesquisa != null) {
                        sql += " where nome_contato like '%" + pesquisa + "%' OR email like '%" + pesquisa + "%' OR telefone like '%" + pesquisa + "%'"; 
                    }

                    cmd.CommandText = sql;
                    //MySqlParameter prIdCliente = createParamMySQLTypeString("id_cliente", id_cliente.ToString(), cmd);
                    //cmd.Parameters.Add(prIdCliente);
                    cmd.Connection = mConn;

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //Definição do objeto cliente
                            cliente objCliente = new cliente();

                            if (!reader.IsDBNull(0))
                            {
                                objCliente.Id_cliente = reader.GetInt32("id_cliente").ToString();
                            }

                            if (!reader.IsDBNull(1))
                            {
                                objCliente.Tipo = reader.GetString("tipo");
                            }

                            if (!reader.IsDBNull(2))
                            {
                                objCliente.CPF = reader.GetString("CPF");
                            }

                            if (!reader.IsDBNull(3))
                            {
                                objCliente.Nome_contato = reader.GetString("nome_contato");
                            }
                            if (!reader.IsDBNull(4))
                            {
                                objCliente.Data_nascimento = reader.GetString("data_nascimento");
                            }

                            if (!reader.IsDBNull(5))
                            {
                                objCliente.Email = reader.GetString("email");
                            }

                            if (!reader.IsDBNull(6))
                            {
                                objCliente.Telefone = reader.GetString("telefone");
                            }

                            if (!reader.IsDBNull(7))
                            {
                                objCliente.Celular = reader.GetString("celular");
                            }

                            if (!reader.IsDBNull(8))
                            {
                                objCliente.Rua = reader.GetString("rua");
                            }

                            if (!reader.IsDBNull(9))
                            {
                                objCliente.Complemento = reader.GetString("complemento");
                            }

                            if (!reader.IsDBNull(10))
                            {
                                objCliente.Numero = reader.GetString("numero");
                            }

                            if (!reader.IsDBNull(11))
                            {
                                objCliente.Bairro = reader.GetString("bairro");
                            }
                            if (!reader.IsDBNull(12))
                            {
                                objCliente.CEP = reader.GetString("CEP");
                            }

                            if (!reader.IsDBNull(13))
                            {
                                objCliente.UF = reader.GetString("UF");
                            }

                            if (!reader.IsDBNull(14))
                            {
                                objCliente.Municipio = reader.GetString("municipio");
                            }

                            if (!reader.IsDBNull(15))
                            {
                                objCliente.Pais = reader.GetString("pais");
                            }

                            if (!reader.IsDBNull(16))
                            {
                                objCliente.Conjuge = reader.GetString("Conjuge");
                            }

                            if (!reader.IsDBNull(17))
                            {
                                objCliente.Receber_email = reader.GetString("receber_email");
                            }
                            
                            listaCliente.Add(objCliente);
                        }
                        reader.Close();
                    }
                }

                return listaCliente;

            //}
            //catch (Exception)
            //{
            //    mConn.Close();
            //    return listaCliente;
            //}
        }


        /// <summary>
        /// Exclui um registro de cliente
        /// </summary>
        /// <param name="id_cliente"></param>
        public static void excluirCliente(string id_cliente)
        {
            //abre a conexao
            MySqlConnection mConn = Connection();
            mConn.Open();
            //try
            //{
            //verificva se a conexão esta aberta
            if (mConn.State == ConnectionState.Open)
            {
                MySqlCommand cmd = new MySqlCommand();
                
                String sql = @"DELETE FROM clientes WHERE id_cliente = ?id_cliente ";
                cmd.CommandText = sql;

                //Definição de parâmetros
                MySqlParameter prIdCliente = createParamMySQLTypeString("id_cliente", id_cliente, cmd);
                cmd.Parameters.Add(prIdCliente);
                
                cmd.Connection = mConn;
                cmd.ExecuteNonQuery();
                mConn.Close();

            }
        }



        /// <summary>
        /// Cria um parâmetro mySQL
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <param name="command"></param>
        /// <returns>MySqlParameter</returns>
        private static MySqlParameter createParamMySQLTypeString(string name, string value, MySqlCommand command)
        {
            MySqlParameter pr = command.CreateParameter();
            pr.MySqlDbType = MySqlDbType.String;
            pr.Value = value;
            pr.ParameterName = name;
            return pr;
        }

        /// <summary>
        /// Cria um parâmetro mySQL
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <param name="command"></param>
        /// <returns>MySqlParameter</returns>
        private static MySqlParameter createParamMySQLTypeNumber(string name, Int32 value, MySqlCommand command)
        {
            MySqlParameter pr = command.CreateParameter();
            pr.MySqlDbType = MySqlDbType.Int32;
            pr.Value = value;
            pr.ParameterName = name;
            return pr;
        }

    }
}