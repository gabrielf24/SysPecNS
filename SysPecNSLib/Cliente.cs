using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Data;


namespace SysPecNSLib
{
    public class Cliente
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Cpf { get; set; }
        public string? Telefone { get; set; }
        public string? Email { get; set; }
        public DateOnly? Data_Nasc { get; set; }
        public DateOnly? Data_Cad { get; set; }
        public bool Ativo { get; set; }


        public Cliente()
        {

        }

        public Cliente(string? nome, string? cpf, string? telefone, string? email, DateOnly? data_nasc, DateOnly? data_cad)
        {
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Email = email;
            Data_Nasc = data_nasc;
            Data_Cad = data_cad;
        }

        public Cliente(int id , string? nome, string? cpf, string? telefone, string? email, DateOnly? data_nasc, DateOnly? data_cad, bool ativo)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Email = email;
            Data_Nasc = data_nasc;
            Data_Cad = data_cad;
            Ativo = ativo;
        }

        public void Inserir()
        {
           var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_cliente_insert";
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spcpf", Cpf);
            cmd.Parameters.AddWithValue("sptelefone", Telefone);
            cmd.Parameters.AddWithValue("spemail", Email);
            cmd.Parameters.AddWithValue("spdata_nasc", Data_Nasc);
            cmd.Parameters.AddWithValue("spdata_cad", Data_Cad);
            var dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                Id = dr.GetInt32(0);
            }
        }

        /// <summary>
        /// Método Obter por Id 
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public static Cliente ObterPorId(int Id)
        {

            Cliente usuario = new();

        }




    }
}
