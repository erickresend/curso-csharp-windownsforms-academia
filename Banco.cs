using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Security.Policy;

namespace Academia
{
    internal class Banco
    {
        private static SQLiteConnection conexao;

        //FUNCOES GENERICAS
        private static SQLiteConnection ConexaoBanco()
        {
            conexao = new SQLiteConnection("Data Source ="+ Globais.caminhoBanco + Globais.nomeBanco);
            conexao.Open();
            return conexao;
        }

        public static DataTable dql(string sql) //Data query language
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = sql;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void dml(string q, string msgOK=null, string msgERRO=null) //Data manipulation language (insert, update, delete)
        {
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = q;
                cmd.ExecuteNonQuery();
                vcon.Close();
                if(msgOK != null)
                {
                    MessageBox.Show(msgOK);
                }
            }
            catch (Exception ex)
            {
                if(msgERRO != null)
                {
                    MessageBox.Show(msgERRO + " " + ex.Message);
                }
                throw ex;
            }
        }

        public static DataTable ObterTodosUsuario()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                //Criando uma conexao propria do metodo
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT * FROM tb_usuarios";
                //O comando dataAdapter precisa do comando SQL e da conexao do banco
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                //Fechando a conexao
                vcon.Close();
                return dt;
            } catch(Exception ex)
            {
                throw ex;
            }
        }

        // INICIO Funcoes do FORM F_GestaoUsuarios
        public static DataTable ObterUsuariosIdNome()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                //Criando uma conexao propria do metodo
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT N_IDUSUARIO as 'ID Usuário', T_NOMEUSUARIO as 'Nome usuário' FROM tb_usuarios";
                //O comando dataAdapter precisa do comando SQL e da conexao do banco
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                //Fechando a conexao
                vcon.Close();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable ObterDadosUsuario(string id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                //Criando uma conexao propria do metodo
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT * FROM tb_usuarios WHERE N_IDUSUARIO=" + id;
                //O comando dataAdapter precisa do comando SQL e da conexao do banco
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                //Fechando a conexao
                vcon.Close();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void AlterarDadosUsuario(Usuario usuario)
        {
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "UPDATE tb_usuarios SET T_NOMEUSUARIO=@nome, T_USERNAME=@username, T_SENHAUSUARIO=@senha, T_STATUSUSUARIO=@status, N_NIVELUSUARIO=@nivel WHERE N_IDUSUARIO=@id";
                cmd.Parameters.AddWithValue("@nome", usuario.nome);
                cmd.Parameters.AddWithValue("@username", usuario.username);
                cmd.Parameters.AddWithValue("@senha", usuario.senha);
                cmd.Parameters.AddWithValue("@status", usuario.status);
                cmd.Parameters.AddWithValue("@nivel", usuario.nivel);
                cmd.Parameters.AddWithValue("@id", usuario.Id);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Usuário alterado com sucesso");
                vcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.Message);
            }
        }

        public static void DeletarUsuario(string id)
        {
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "DELETE FROM tb_usuarios WHERE N_IDUSUARIO=" + id;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Usuário excluido com sucesso");
                vcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.Message);
            }
        }

        // FIM Funcoes do FORM F_GestaoUsuarios

        // INICIO Funcoes do FORM F_NovoUsuario
        public static void NovoUsuario(Usuario u)
        {
            if(ExisteUdername(u) == false)
            {
                try
                {
                    var vcon = ConexaoBanco();
                    var cmd = vcon.CreateCommand();
                    cmd.CommandText = "INSERT INTO tb_usuarios (T_NOMEUSUARIO, T_USERNAME, T_SENHAUSUARIO, T_STATUSUSUARIO, N_NIVELUSUARIO) VALUES (@nome, @username, @senha, @status, @nivelusuario)";
                    cmd.Parameters.AddWithValue("@nome", u.nome);
                    cmd.Parameters.AddWithValue("@username", u.username);
                    cmd.Parameters.AddWithValue("@senha", u.senha);
                    cmd.Parameters.AddWithValue("@status", u.status);
                    cmd.Parameters.AddWithValue("@nivelusuario", u.nivel);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Novo usuário inserido com sucesso");
                    vcon.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("ERROR: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Username já existe");
            }
        }

        // FIM Funcoes do FORM F_NovoUsuario

        // Rotinas gerais

        public static bool ExisteUdername(Usuario u)
        {
            bool res;

            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            var vcon = ConexaoBanco();
            var cmd = vcon.CreateCommand();
            cmd.CommandText = "SELECT T_USERNAME FROM tb_usuarios WHERE T_USERNAME='" + u.username + "'";
            da = new SQLiteDataAdapter(cmd.CommandText, vcon);
            da.Fill(dt);
            //Se o numero de linhas for maior que 0
            if (dt.Rows.Count > 0)
            {
                res = true;
            }
            else
            {
                res = false;
            }

            return res;
        }
    }
}
