using Google.Protobuf;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
/*
namespace SysPecNSLib
{
    public class Endereco
    {
        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public string? Cep { get; set; } 
        public string? Logradouro { get; set; }
        public string? Numero { get; set; }
        public string? Complemento { get; set; }
        public string? Bairro { get; set; }
        public string? Cidade { get; set; }
        public string? Uf { get; set; }
        public string? Tipo_endereco { get; set; }

        public Endereco()
        {
            Cliente = new();
        }

        public Endereco(Cliente cliente, string? cep, string? logradouro, string? numero, string? complemento, string? bairro, string? cidade, string? uf, string? tipo_endereco)
        {
            Cliente = cliente;
            Cep = cep;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = Cidade;
            Uf = uf;
            Tipo_endereco = tipo_endereco;
        }

        public Endereco(int id,Cliente cliente, string? cep, string? logradouro, string? numero, string? complemento, string? bairro, string? cidade, string? uf, string? tipo_endereco)
        {
            Id = id;
            Cliente = cliente;
            Cep = cep;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = Cidade;
            Uf = uf;
            Tipo_endereco = tipo_endereco;
        }

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_endereco_insert";
            cmd.Parameters.AddWithValue("spcliente", Cliente.Id);
            cmd.Parameters.AddWithValue("spcep", Cep);
            cmd.Parameters.AddWithValue("splogradouro", Logradouro);
            cmd.Parameters.AddWithValue("spnumero", Numero);
            cmd.Parameters.AddWithValue("spcomplemento", Complemento);
            cmd.Parameters.AddWithValue("spbairro", Bairro);
            cmd.Parameters.AddWithValue("spcidade", Cidade);
            cmd.Parameters.AddWithValue("spuf", Uf);
            cmd.Parameters.AddWithValue("spctipo_endereco", Tipo_endereco);
            var dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                Id = dr.GetInt32(0);
            }
        }

        /// <summary>
        /// Obter por Id é um método 
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public static Endereco ObterPorId(int Id)
        {

            Endereco endereco = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from usuario where id = {Id}";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                endereco = new(
                    dr.GetInt32(0),
                    Cliente.ObterPorId(dr.GetInt32(1)),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetString(4),
                    dr.GetString(5),
                    dr.GetString(6),
                    dr.GetString(7),
                    dr.GetString(8),
                    dr.GetString(9)
                    );
            }
            return endereco;
        }
    }

    public static List<Endereco> ObterLista(string? )
} */
