using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysPecNSLib
{
    public class Fornecedor
    {
        public int Id { get; set; }
        public string? Razaosoc { get; set; }
        public string? Fantasia { get; set; }
        public string? Cnpj { get; set; }
        public string? Contato { get; set; }
        public string? Telefone { get; set; }
        public string? Email { get; set; }

        public Fornecedor()
        {
            
        }
        public Fornecedor(string? razaosoc, string? fantasia, string? cnpj, string? contato, string? telefone, string? email)
        {
            Razaosoc = razaosoc;
            Fantasia = fantasia;
            Cnpj = cnpj;
            Contato = contato;
            Telefone = telefone;
            Email = email;
        }
        public Fornecedor(int id, string? razaosoc, string? fantasia, string? cnpj, string? contato, string? telefone, string? email)
        {
            Id = id;
            Razaosoc = razaosoc;
            Fantasia = fantasia;
            Cnpj = cnpj;
            Contato = contato;
            Telefone = telefone;
            Email = email;
        }

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_fornecedores_insert";
            cmd.Parameters.AddWithValue("spsprazao_social", Razaosoc);
            cmd.Parameters.AddWithValue("spfantasia", Fantasia);
            cmd.Parameters.AddWithValue("spcnpj", Cnpj);
            cmd.Parameters.AddWithValue("spcontato", Contato);
            cmd.Parameters.AddWithValue("sptelefone", Telefone);
            cmd.Parameters.AddWithValue("spemail", Email);
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Id = dr.GetInt32(0);
            }
        }

        public static Fornecedor ObterPorId(int Id)
        {
            Fornecedor fornecedor = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from fornecedores wher id = {Id}";
            var dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                fornecedor = new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetString(4),
                    dr.GetString(5),
                    dr.GetString(6)
                    );
            }
            return fornecedor;

        }

        public static List<Fornecedor> ObterLista(string? nome = "")
        {
            List<Fornecedor> lista = new();
            var comandosSQL = Banco.Abrir();
            comandosSQL.CommandType = CommandType.Text;
            if(nome=="")
            {
                comandosSQL.CommandText = " select * from fornecedores order by nome";
            }
            else
            {
                comandosSQL.CommandText = "select * from fornecedores where nome" + $"Like '%{nome}%' order by nome";
            }
        }

    }


    
}
