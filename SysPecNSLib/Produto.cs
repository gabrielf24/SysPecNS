﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SysPecNSLib
{
    public class Produto
    {
        public int Id { get; set; }
        public string? CodBar { get; set; }
        public string? Descricao { get; set; }
        public double Valor_unit { get; set; }
        public string? UnidadeVenda { get; set; }
        public Categoria? Categoria { get; set; }
        public double EstoqueMinimo { get; set; }
        public double ClasseDesconto { get; set; }
        public byte[]? Imagem { get; set; }
        public DateTime? DataCad { get; set; }
        public Produto() {
        
        }

        public Produto(string codBar, string descricao, double valor_unit, string unidadeVenda, Categoria? categoria, double estoqueMinimo, double classeDesconto)
        {
            CodBar = codBar;
            Descricao = descricao;
            Valor_unit = valor_unit;
            UnidadeVenda = unidadeVenda;
            Categoria = categoria;
            EstoqueMinimo = estoqueMinimo;
            ClasseDesconto = classeDesconto;
        }

        public Produto(string codBar, string descricao, double valor_unit, string unidadeVenda, Categoria? categoria, double estoqueMinimo, double classeDesconto, byte[]? imagem)
        {
            CodBar = codBar;
            Descricao = descricao;
            Valor_unit = valor_unit;
            UnidadeVenda = unidadeVenda;
            Categoria = categoria;
            EstoqueMinimo = estoqueMinimo;
            ClasseDesconto = classeDesconto;
            Imagem = imagem;
        }
        public Produto(string codBar, string descricao, double valor_unit, string unidadeVenda, Categoria? categoria, double estoqueMinimo, double classeDesconto, byte[]? imagem = null, DateTime? dataCad = null)
        {
            CodBar = codBar;
            Descricao = descricao;
            Valor_unit = valor_unit;
            UnidadeVenda = unidadeVenda;
            Categoria = categoria;
            EstoqueMinimo = estoqueMinimo;
            ClasseDesconto = classeDesconto;
            Imagem = imagem;
            DataCad = dataCad;
        }
        public Produto(int id, string codBar, string descricao, double valor_unit, string unidadeVenda, Categoria? categoria, double estoqueMinimo, double classeDesconto, byte[]? imagem = null, DateTime? dataCad = null)
        {
            Id = id;
            CodBar = codBar;
            Descricao = descricao;
            Valor_unit = valor_unit;
            UnidadeVenda = unidadeVenda;
            Categoria = categoria;
            EstoqueMinimo = estoqueMinimo;
            ClasseDesconto = classeDesconto;
            Imagem = imagem;
            DataCad = dataCad;
        }
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "sp_produto_insert";
            cmd.Parameters.AddWithValue("spcod_barras", CodBar);
            cmd.Parameters.AddWithValue("spdescricao", Descricao);
            cmd.Parameters.AddWithValue("spvalor_unit", Valor_unit);
            cmd.Parameters.AddWithValue("spunidade_venda", UnidadeVenda);
            cmd.Parameters.AddWithValue("spcategoria_id", Categoria.Id);
            cmd.Parameters.AddWithValue("spestoque_minimo", EstoqueMinimo);
            cmd.Parameters.AddWithValue("spclasse_desconto", ClasseDesconto);
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Connection.Close();
        }
        public void Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "sp_produto_insert";
            cmd.Parameters.AddWithValue("spcod_barras", CodBar);
            cmd.Parameters.AddWithValue("spdescricao", Descricao);
            cmd.Parameters.AddWithValue("spvalor_unit", Valor_unit);
            cmd.Parameters.AddWithValue("spunidade_venda", UnidadeVenda);
            cmd.Parameters.AddWithValue("spcategoria_id", Categoria.Id);
            cmd.Parameters.AddWithValue("spestoque_minimo", EstoqueMinimo);
            cmd.Parameters.AddWithValue("spclasse_desconto", ClasseDesconto);
            cmd.ExecuteNonQuery();
            
        }

        public static Produto ObterPorId(int Id)
        {
            Produto produto = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from produtos where id = {Id}";
            var dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                produto = new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetDouble(3),
                    dr.GetString(4),
                    Categoria.ObterPorId(dr.GetInt32(5)),
                    dr.GetDouble(6),
                    dr.GetDouble(7),
                    (byte[])dr.GetValue(8),
                    dr.GetDateTime(9)
                    );
            }
            cmd.Connection.Close();
            return produto;
        }
        public static Produto ObterPorId(string id)
        {
            Produto produto = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from produtos where cod_barras = '{id}'";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                 produto = new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetDouble(3),
                    dr.GetString(4),
                    Categoria.ObterPorId(dr.GetInt32(5)),
                    dr.GetDouble(6),
                    dr.GetDouble(7),
                   null,
                    dr.GetDateTime(9)
                    );
            }
            cmd.Connection.Close();
            return produto;
        }
        public static List<Produto> ObterLista()
        {
            List<Produto> produtos = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from produtos";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                produtos.Add(new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetDouble(3),
                    dr.GetString(4),
                    Categoria.ObterPorId(dr.GetInt32(5)),
                    dr.GetDouble(6),
                    dr.GetDouble(7),
                    null,
                    dr.GetDateTime(9)
                    ));
            }
            cmd.Connection.Close();
            return produtos;
        }
    }
}