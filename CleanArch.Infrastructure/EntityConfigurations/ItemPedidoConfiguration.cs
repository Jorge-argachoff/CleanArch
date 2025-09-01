using CleanArch.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Infrastructure.EntityConfigurations
{
    public class ItemPedidoConfiguration : IEntityTypeConfiguration<ItemPedido>
    {
        public void Configure(EntityTypeBuilder<ItemPedido> entity)
        {
            entity.HasKey(ip => new { ip.PedidoId, ip.ProdutoId });

            
           entity.HasOne(p => p.Pedido)
           .WithMany(ip => ip.ItensPedido)
           .HasForeignKey(p => p.PedidoId);

            entity.HasOne(p => p.Produto)
                .WithMany(ip => ip.ItensPedido)
                .HasForeignKey(p => p.ProdutoId);
        }
    }
}
