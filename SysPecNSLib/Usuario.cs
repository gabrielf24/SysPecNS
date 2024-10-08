﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Org.BouncyCastle.Cms;

namespace SysPecNSLib
{
    public class Usuario
    {


        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? Senha { get; set; }
        public Nivel Nivel { get; set; }
        public bool Ativo { get; set; }

        public Usuario()
        {
            Nivel = new();
        }

        public Usuario(string? nome, string? email, string? senha, Nivel nivel)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            Nivel = nivel;
        }

        public Usuario(string? nome, string? email, string? senha, Nivel nivel, bool ativo)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            Nivel = nivel;
            Ativo = ativo;
        }

        public Usuario(int id, string? nome, string? email, string? senha, Nivel nivel, bool ativo)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Senha = senha;
            Nivel = nivel;
            Ativo = ativo;
        }

        public void Inserir()
        {
           var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_usuario_insert";
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spemail", Email);
            cmd.Parameters.AddWithValue("spsenha", Senha);
            cmd.Parameters.AddWithValue("spnivel", Nivel.Id);
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
        public static Usuario ObterPorId(int Id)
        {

            Usuario usuario = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from usuarios where id = {Id}";
            var dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                usuario = new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    Nivel.ObterPorId(dr.GetInt32(4)),
                    dr.GetBoolean(5)
                    );
            }
            cmd.Connection.Close();
            return usuario;
        }

        public static List<Usuario> ObterLista(string? nome = "")
        {
            List<Usuario> lista = new();
            var comandosSQL = Banco.Abrir();
            comandosSQL.CommandType = CommandType.Text;
            if (nome=="")
            {
                comandosSQL.CommandText = "select * from usuarios order by nome";
            }
            else 
            {
                comandosSQL.CommandText = "select * from usuarios where nome " + $"like '%{nome}%' order by nome";
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
                        Nivel.ObterPorId(dr.GetInt32(4)),
                        dr.GetBoolean(5)
                        )
                    );
            }
            

            return lista;
        }

        public static Usuario EfetuarLogin(string email, string senha)
        {
            Usuario usuario = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from usuarios where email = '{email}'and senha = md5('{senha}')";
            var dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                usuario = new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    Nivel.ObterPorId(dr.GetInt32(4)),
                    dr.GetBoolean(5)
                );
            }
            cmd.Connection.Close();
            return usuario;
        }
        public void Atualizar()
        {
            // usuario: nome, senha, nível... 
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_usuario_altera";
            //cmd.Parameters.Add("spid",MySqlDbType.Int32).Value = Id;
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spnivel", Nivel.Id);
            cmd.Parameters.AddWithValue("spsenha", Senha);
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

        }
        public static void Arquivar(int id) 
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"update usuarios set ativo = 0 where id = {id}";
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        public static void Restaurar(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"update usuarios set ativo = 1 where id = {id}";
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
    }

    internal class MySqlDbType
    {
    internal static MySql.Data.MySqlClient.MySqlDbType Int32;
    }
    
        
}
