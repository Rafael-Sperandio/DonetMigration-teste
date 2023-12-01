using f1DotnetTeste.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace f1DotnetTeste.API.Persistence
{
    public class MEUDBContext: DbContext
    {
          
        private List<Produto> _produtos;
        public DbSet<Produto> Produtos { get; set; }


        public MEUDBContext(DbContextOptions<MEUDBContext> options):base(options) { 
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>(e =>
            {
                e.HasKey(pe => pe.id);
                e.Property(pe => pe.nome).IsRequired(true);

            }
            
            );
            base.OnModelCreating(modelBuilder);
        }
        /*
        
        public ProdutoDBContext()
        {
            _produtos = new List<Produto>();

        }
        */
        public List<Produto> listarFrutas()
        {
            _produtos.Add(new Produto() { nome = "Banana", valor = 8, categoria = "fruta" });
            _produtos.Add(new Produto() { nome = "kiwi", valor = 8, categoria = "fruta" });
            _produtos.Add(new Produto() { nome = "Morango", valor = 8, categoria = "fruta" });
            _produtos.Add(new Produto() { nome = "Pera", valor = 8, categoria = "fruta" });
            _produtos.Add(new Produto() { nome = "Abcaxi", valor = 8, categoria = "fruta" });
            _produtos.Add(new Produto() { nome = "Melão", valor = 9, categoria = "fruta" });

            return _produtos;
        }
        public List<Produto> listareletronico()
        {
            _produtos.Add(new Produto() { nome = "galaxy", valor = 1000, categoria = "eletronico" });
            _produtos.Add(new Produto() { nome = "Iphone", valor = 2000, categoria = "eletronico" });
            _produtos.Add(new Produto() { nome = "Ipad ", valor = 3000, categoria = "eletronico" });


            return _produtos;
        }
    }
}
