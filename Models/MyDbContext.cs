namespace APS.Models;
using Microsoft.EntityFrameworkCore;

public class MyDbContext : DbContext {
    public MyDbContext (DbContextOptions<MyDbContext> options) : base(options){

    }

    public DbSet<Usuario> Usuario {get; set;}
    public DbSet<Categoria> Categoria {get; set;}
    public DbSet<Produto> Produto {get; set;}
    public DbSet<Carrinho> Carrinho {get; set;}

}