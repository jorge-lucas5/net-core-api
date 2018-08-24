using Microsoft.EntityFrameworkCore;
using MyWebApp.AcessoDados.Entidades;
using System.Linq;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyWebApp.AcessoDados
{
    public class MyWebAppContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<ItemPedido> ItensPedidos { get; set; }
        public MyWebAppContext(DbContextOptions<MyWebAppContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //foreach (var entity in builder.Model.GetEntityTypes())
            //{
            //    // Replace table names
            //    entity.Relational().TableName = entity.Relational().TableName.ToSnakeCase();

            //    // Replace column names            
            //    foreach (var property in entity.GetProperties())
            //    {
            //        property.Relational().ColumnName = property.Name.ToSnakeCase();
            //    }

            //    foreach (var key in entity.GetKeys())
            //    {
            //        key.Relational().Name = key.Relational().Name.ToSnakeCase();
            //    }

            //    foreach (var key in entity.GetForeignKeys())
            //    {
            //        key.Relational().Name = key.Relational().Name.ToSnakeCase();
            //    }

            //    foreach (var index in entity.GetIndexes())
            //    {
            //        index.Relational().Name = index.Relational().Name.ToSnakeCase();
            //    }
            //}
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }
            base.OnModelCreating(modelBuilder);
        }


    }
}
