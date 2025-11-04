using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsPEC
{
    internal class DaoCidades : DAO<Cidades>
    {
        public override string Salvar(object obj)
        {
            Cidades aCidade = (Cidades)obj;
            string mSql = "", mOk = "";
            if (aCidade.Codigo == 0)
            {
                mSql = "insert into cidades (Cidade, DDD, datCad, ultAlt, id_estado) values (@cidade, @ddd, @datcad, @ultalt, @idEstado)";

            }
            else
            {
                mSql = "update cidades set cidade=@cidade, ddd=@ddd, datcad=@datcad, ultalt=@ultalt, id_estado=@idEstado where id = @id";
            }
            using (SqlCommand cmd = new SqlCommand(mSql, cnn))
            {
                cmd.Parameters.AddWithValue("@cidade", aCidade.Cidade);
                cmd.Parameters.AddWithValue("@ddd", aCidade.Ddd);
                cmd.Parameters.AddWithValue("@datcad", aCidade.Datcad);
                cmd.Parameters.AddWithValue("@ultalt", aCidade.Ultalt);
                cmd.Parameters.AddWithValue("@id", aCidade.Codigo);
                cmd.Parameters.AddWithValue("@idEstado", aCidade.OEstado.Codigo);
                cmd.ExecuteNonQuery();
                cmd.CommandText = "SELECT @@IDENTITY";
                mOk = "ID SALVO: " + cmd.ExecuteScalar().ToString();
            }
            return mOk;
        }
        public override string Excluir(object obj)
        {
            Cidades aCidade = (Cidades)obj;
            try
            {
                string mSql = "delete from cidades where id = @id";
                using (SqlCommand cmd = new SqlCommand(mSql, cnn))
                {
                    cmd.Parameters.AddWithValue("@id", aCidade.Codigo);
                    cmd.ExecuteNonQuery();
                }
                return "ID: " + aCidade.Codigo + " Excluído!";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public override List<Cidades> Listar()
        {
            List<Cidades> listaCidades = new List<Cidades>();
            string mSql = @"select c.id, c.cidade, c.ddd, e.id, e.estado from cidades c inner join estados e on c.id_estado = e.id order by c.id_estado";
            using (SqlCommand cmd = new SqlCommand(mSql, cnn))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        Estados oEstado = new Estados
                        {
                            Codigo = Convert.ToInt32(reader["id"]),
                            Estado = Convert.ToString(reader["estado"])
                        };
                        Cidades aCidade = new Cidades
                        {
                            Codigo = Convert.ToInt32(reader["id"]),
                            Cidade = Convert.ToString(reader["cidade"]),
                            Ddd = Convert.ToString(reader["ddd"]),
                            OEstado = oEstado
                        };
                        listaCidades.Add(aCidade);
                    }
                }
            }
            return listaCidades;
        }
        public override Object CarregaObj(int chave)
        {
            //return null;
            string mSql = "select * from cidades as c inner join estados as e on e.id = c.id_estado inner join paises as p on p.id = e.id_pais where c.id = @chave";
            Paises oPais = null;
            Estados oEstado = null;
            Cidades aCidade = null;
            try
            {
                using (SqlCommand cmd = new SqlCommand(mSql, cnn))
                {
                    cmd.Parameters.AddWithValue("@chave", chave);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        oPais = new Paises(
                            Convert.ToInt32(reader["id_pais"]),
                            Convert.ToDateTime(reader["datcad"]),
                            Convert.ToDateTime(reader["ultalt"]),
                            Convert.ToString(reader["pais"]),
                            Convert.ToString(reader["sigla"]),
                            Convert.ToString(reader["ddi"]),
                            Convert.ToString(reader["moeda"])
                        );
                        oEstado = new Estados(
                            Convert.ToInt32(reader["id_estado"]),
                            Convert.ToDateTime(reader["datcad"]),
                            Convert.ToDateTime(reader["ultalt"]),
                            Convert.ToString(reader["estado"]),
                            Convert.ToString(reader["uf"]),
                            oPais
                        );
                        aCidade = new Cidades(
                            Convert.ToInt32(reader["id"]),
                            Convert.ToDateTime(reader["datcad"]),
                            Convert.ToDateTime(reader["ultalt"]),
                            Convert.ToString(reader["cidade"]),
                            Convert.ToString(reader["ddd"]),
                            oEstado
                        );
                    }
                    reader.Close();
                }
                return aCidade;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
