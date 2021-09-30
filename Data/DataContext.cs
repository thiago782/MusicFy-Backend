using MusicFy_Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace MusicFy_Backend.Data
{
    public class DataContext : DbContext
    {
       // Construtor

       public DataContext(DbContextOptions<DataContext> options) : base(options) { }
   
   
       //lista de propriedades das classes de modelos que vao virar tabelas no banco
     public DbSet<Musica> Musicas {get; set;}
   
    }
}