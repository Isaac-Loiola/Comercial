using Org.BouncyCastle.Math.EC.Endo;
using Org.BouncyCastle.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ComercialTDSClass
{
    public class ItemPedido
    {

        public int Id { get; set; }
        public int PedidoId { get; set; }
        public Produto Produto { get; set; }
        public double ValorUnit { get; set; }
        public double Quantidade { get; set; }
        public double Desconto { get; set; }
        
        public ItemPedido()
        {
            Produto = new();
        }
        public ItemPedido(int id, int pedidoId, Produto produto, double valorUnit, double quantidade, double desconto)
        {
            Id = id;
            PedidoId = pedidoId;
            Produto = produto;
            ValorUnit = valorUnit;
            Quantidade = quantidade;
            Desconto = desconto;
        }
        public ItemPedido(int pedidoId, Produto produto, double quantidade, double desconto)
        {
            PedidoId = pedidoId;
            Produto = produto;
            Quantidade = quantidade;
            Desconto = desconto;
        }

        public ItemPedido(int id, double quantidade, double desconto)
        {
            Id = id;
            Quantidade = quantidade;
            Desconto = desconto;
        }

        public void Deletar(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_itempedido_delete";
            cmd.Parameters.AddWithValue("spid", Id);

            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_itempedido_insert";
            cmd.Parameters.AddWithValue("sppedido_id", PedidoId);
            cmd.Parameters.AddWithValue("spproduto_id", Produto);
            cmd.Parameters.AddWithValue("spquantidade", Quantidade);
            cmd.Parameters.AddWithValue("spdesconto", Desconto);

            Id = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Connection.Close();
        }

        public bool Atualizar()
        {
            return true;
        }
        public static ItemPedido ObterPorId(int id)
        {
            ItemPedido itemPedido = new();

            return itemPedido;
        }

        public static List<ItemPedido> ObterListaPorPedidoId(int pedidoId)
        {
            List<ItemPedido> items = new();
            
            return items;
        }
    }
}









