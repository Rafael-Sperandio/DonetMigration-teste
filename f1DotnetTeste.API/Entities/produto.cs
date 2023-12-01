namespace f1DotnetTeste.API.Entities
{
    public class Produto
    {
      
       
        public Produto()
        {
            

        }
       /*
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
       */
        public void Update(String nnome, decimal nvalor, string ncategoria)
        {
            nome = nnome;
            valor = nvalor;
           categoria = ncategoria;
        }
        public Guid id { get; set; }
        public string nome { get; set; }

        public decimal valor { get; set; }
        public string categoria { get; set; }

    }
}
