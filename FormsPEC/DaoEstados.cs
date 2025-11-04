using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsPEC
{
    internal class DaoEstados : DAO<Estados>
    {
        public override string Salvar(object obj)
        {
            Estados oEstado = (Estados)obj;
            string mSql = "", mOk = "";
            if (oEstado.Codigo == 0)
                mSql = "insert into estados (Estado, Uf, datCad, ultAlt, id_pais) values (@estado, @uf, @datcad, @ultalt, @idPais)";
            else
                mSql = "update estados set estado=@estado, uf=@uf, datcad=@datcad, ultalt=@ultalt, id_pais=@idPais where id=@id";

            using (SqlCommand cmd = new SqlCommand(mSql, cnn))
            {
                cmd.Parameters.AddWithValue("@estado", oEstado.Estado);
                cmd.Parameters.AddWithValue("@uf", oEstado.Uf);
                cmd.Parameters.AddWithValue("@datcad", oEstado.Datcad);
                cmd.Parameters.AddWithValue("@ultalt", oEstado.Ultalt);
                cmd.Parameters.AddWithValue("@idPais", oEstado.OPais.Codigo);
                cmd.Parameters.AddWithValue("@id", oEstado.Codigo);
                cmd.ExecuteNonQuery();
                cmd.CommandText = "select @@identity";
                mOk = "ID SALVO: " + cmd.ExecuteScalar().ToString();
            }
            return mOk;
        }
        public override List<Estados> Listar()
        {
            string mSql = "select * from estados as e inner join paises as p on p.id = e.id_pais order by e.id";
            using (SqlCommand cmd = new SqlCommand(mSql, cnn))
            {
                SqlDataReader reader = cmd.ExecuteReader();
                List<Estados> lista = new List<Estados>();
                while (reader.Read())
                {
                    Paises oPais = new Paises (
                        Convert.ToInt32(reader["id_pais"]),
                        Convert.ToDateTime(reader["datcad"]),
                        Convert.ToDateTime(reader["ultalt"]),
                        reader["pais"].ToString(),
                        reader["sigla"].ToString(),
                        reader["ddi"].ToString(),
                        reader["moeda"].ToString()
                    );
                    Estados oEstado = new Estados(
                        Convert.ToInt32(reader["id"]),
                        Convert.ToDateTime(reader["datcad"]),
                        Convert.ToDateTime(reader["ultalt"]),
                        reader["estado"].ToString(),
                        reader["uf"].ToString(),
                        oPais
                    );
                    lista.Add(oEstado);
                }
                reader.Close();
                return lista;
            }
        }
        public override string Excluir(object obj)
        {
            Estados oEstado = (Estados)obj;
            try
            {
                string mSql = "delete from estados where id = @id";
                using (SqlCommand cmd = new SqlCommand(mSql, cnn))
                {
                    cmd.Parameters.AddWithValue("@id", oEstado.Codigo);
                    cmd.ExecuteNonQuery();
                }
                return "ID: " + oEstado.Codigo + " Excluído!";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public override Object CarregaObj(int chave)
        {
            //return null;
            string mSql = "select * from estados as e inner join paises as p on p.id = e.id_pais where e.id = @chave";
            Paises oPais = null;
            Estados oEstado = null;
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
                            Convert.ToDateTime(reader["datCad"]),
                            Convert.ToDateTime(reader["ultAlt"]),
                            reader["Pais"].ToString(),
                            reader["Sigla"].ToString(),
                            reader["DDI"].ToString(),
                            reader["Moeda"].ToString()
                        );
                        oEstado = new Estados(
                            Convert.ToInt32(reader["id"]),
                            Convert.ToDateTime(reader["datCad"]),
                            Convert.ToDateTime(reader["ultAlt"]),
                            reader["Estado"].ToString(),
                            reader["Uf"].ToString(),
                            oPais
                        );
                    }
                    reader.Close();
                }
                return oEstado;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public override List<Estados> Pesquisar(string chave)
        {
            return null;
        }
    }
}
