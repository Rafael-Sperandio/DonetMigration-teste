namespace f1DotnetTeste.API.Entities
{
    public class Livro
    {
        public Guid id { get; set; }
        public string nome { get; set; }
        public string Sinopse {  get; set; }
        public string Autor {  get; set; }
        public DateTime data_lacamento { get; set; }

        //public int qtd { get; set; }//quantidade
        //public decimal valor { get; set; }
        
        public Livro() { }
        /*
         CREATE TABLE Livro (
        Livroid  SERIAL  NOT NULL ,
        nome varchar(50) NOT NULL,
        Autor varchar(50) NOT NULL,
        Sinopse varchar(250),
        data_lacamento Date NOT NULL,
        Status varchar(15)  NOT NULL,
        PRIMARY KEY (Livroid)
        );
         * 
         * */
    }
}
