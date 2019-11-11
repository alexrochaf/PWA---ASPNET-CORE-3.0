namespace PWApp.Models
{
    public class SuperHeroi
    {
        protected SuperHeroi()
        {
        }

        public SuperHeroi(int? id, string nome, string superPoder, byte[] foto)
        {
            Id = id ?? 0;
            Nome = nome;
            SuperPoder = superPoder;
            Foto = foto;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string SuperPoder { get; set; }
        public byte[] Foto { get; set; }
    }
}
