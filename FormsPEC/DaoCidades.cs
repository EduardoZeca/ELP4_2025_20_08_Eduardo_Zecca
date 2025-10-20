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
            return null;
        }
        public override List<Cidades> Listar()
        {
            List<Cidades> listaCidades = new List<Cidades>();
            string mSql = "select c.id, c.cidade, c.ddd, e.id, e.estado from cidades c inner join estados e on c.id_estado = e.id order by c.id_estado";
            using (SqlCommand cmd = new SqlCommand(mSql, cnn))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    
                    while (reader.Read())
                    {
                        Estados oEstado = new Estados
                        {
                            Codigo = Convert.ToInt32(reader["estadoId"]),
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

            //string mSql = "select e.id, e.estado, e.uf, e.id_pais, p.pais from estados e inner join paises p on e.id_pais = p.id order by e.id";
            //using (SqlCommand cmd = new SqlCommand(mSql, cnn))
            //{
            //    SqlDataReader reader = cmd.ExecuteReader();
            //    List<Estados> lista = new List<Estados>();
            //    while (reader.Read())
            //    {
            //        Paises oPais = new Paises(
            //            Convert.ToInt32(reader["id_pais"]),
            //            reader["pais"].ToString()
            //        );
            //        Estados oEstado = new Estados(
            //            Convert.ToInt32(reader["e.id"]),
            //            Convert.ToDateTime(reader["e.datcad"]),
            //            Convert.ToDateTime(reader["e.ultalt"]),
            //            reader["e.estado"].ToString(),
            //            reader["e.uf"].ToString(),
            //            oPais
            //        );
            //        lista.Add(oEstado);
            //    }
            //    reader.Close();
            //    return lista;
            }


    }
}
