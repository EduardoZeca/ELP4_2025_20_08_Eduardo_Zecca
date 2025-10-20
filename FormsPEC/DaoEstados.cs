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
                mSql = "insert into estados(Estado, Uf, datCad, ultAlt, id_pais) values (@estado, @uf, @datcad, @ultalt, @idPais)";
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
            string mSql = "select e.id, e.estado, e.uf, e.id_pais, p.pais from estados e inner join paises p on e.id_pais = p.id order by e.id";
            using (SqlCommand cmd = new SqlCommand(mSql, cnn))
            {
                SqlDataReader reader = cmd.ExecuteReader();
                List<Estados> lista = new List<Estados>();
                while (reader.Read())
                {
                    Paises oPais = new Paises (
                        Convert.ToInt32(reader["id_pais"]),
                        reader["pais"].ToString()
                    );
                    Estados oEstado = new Estados(
                        Convert.ToInt32(reader["e.id"]),
                        Convert.ToDateTime(reader["e.datcad"]),
                        Convert.ToDateTime(reader["e.ultalt"]),
                        reader["e.estado"].ToString(),
                        reader["e.uf"].ToString(),
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
            return null;
        }
        public override Object CarregaObj(int chave)
        {
            return null;
        }
        public override List<Estados> Pesquisar(string chave)
        {
            return null;
        }
    }
}
