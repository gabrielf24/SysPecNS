﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysPecNSLib
{
    public class Categoria
    {


        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Sigla { get; set; }

        public Categoria()
        {

        }

        public Categoria(string? nome, string? sigla)
        {
            Nome = nome;
            Sigla = sigla;
        }
        public Categoria(int id, string? nome, string? sigla)
        {
            Id = id;
            Nome = nome;
            Sigla = sigla;
        }
        public Categoria(int id, string? nome)
        {
            Id = id;
            Nome = nome;
           
        }

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_categoria_insert";
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spsigla", Sigla);
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Connection.Close();

        }
        public static Categoria ObterPorId(int id)
        {
            Categoria categoria = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from categorias where id = {id}";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                categoria = new(
                    dr.GetInt32(0),
                    dr.GetString(1)
                    );
            }
            cmd.Connection.Close();
            return categoria;
        }

        public static List<Categoria> ObterLista()
        {
            List<Categoria> categoria = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from categorias";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                categoria.Add(
                    new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    null ));
            }
            cmd.Connection.Close();
            return categoria;
        }

        public void Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_categoria_update";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spsigla", Sigla);
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

        }

        public void Deletar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = $"delete form categorias where id = {Id}";
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

        }



    }
}
