﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Data;
using Org.BouncyCastle.Cms;
using System.ComponentModel.DataAnnotations;
using Org.BouncyCastle.Tls;


namespace SysPecNSLib
{
    public class Cliente
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Cpf { get; set; }
        public string? Telefone { get; set; }
        public string? Email { get; set; }
        public DateTime? Data_Nasc { get; set; }
        public DateTime? Data_Cad { get; set; }
        public bool Ativo { get; set; }


        public Cliente()
        {

        }

        public Cliente(string? nome, string? cpf, string? telefone, string? email, DateTime? data_nasc, DateTime? data_cad)
        {
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Email = email;
            Data_Nasc = data_nasc;
            Data_Cad = data_cad;
        }
        public Cliente(string? nome, string? cpf, string? telefone, string? email, DateTime? data_nasc, bool ativo)
        {
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Email = email;
            Data_Nasc = data_nasc;
            Ativo = ativo;
        }

        public Cliente(int id, string? nome, string? cpf, string? telefone, string? email, DateTime? data_nasc, DateTime data_cad, bool ativo)
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
            while (dr.Read())
            {
                Id = dr.GetInt32(0);
            }
            cmd.Connection.Close();

        }

        /// <summary>
        /// Método Obter por Id 
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public static Cliente ObterPorId(int Id)
        {

            Cliente cliente = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from clientes where id = {Id}";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                cliente = new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetString(4),
                    dr.GetDateTime(5),
                    dr.GetDateTime(6),
                    dr.GetBoolean(7)
                    );
            }
            cmd.Connection.Close();
             return cliente;
        }

        public static List<Cliente> ObterLista(string? nome = "")
        {
            List<Cliente> lista = new();
            var comandosSQL = Banco.Abrir();
            comandosSQL.CommandType = CommandType.Text;
            if (nome=="")
            {
                comandosSQL.CommandText = "select * from clientes order by nome";
            }
            else
            {
                comandosSQL.CommandText = "select * from clientes where nome " + $"Like '%{nome}%' order by nome";
            }

            var dr = comandosSQL.ExecuteReader();
            while(dr.Read())
            {
                lista.Add(
                    new(
                        dr.GetInt32(0),
                        dr.GetString(1),
                        dr.GetString(2),
                        dr.GetString(3),
                        dr.GetString(4),
                        dr.GetDateTime(5),
                        dr.GetDateTime(6),
                        dr.GetBoolean(7)
                        )
                    );
            }
             return lista;
        }
       
        public void Atualizar()
        {
            //cliente: nome, telefone, email, ativo;
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_cliente_update";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("sptelefone", Telefone);
            cmd.Parameters.AddWithValue("spemail", Email);
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

        }
        public static void Arquivar(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"update clientes set ativo = 0 where id = {id}";
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        public static void Restaurar(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"update clientes set ativo = 1 where id = {id}";
            cmd.Connection.Close();

        }
    }
}
   