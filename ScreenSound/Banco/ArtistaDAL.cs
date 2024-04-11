using Microsoft.Data.SqlClient;
using ScreenSound.Modelos;

namespace ScreenSound.Banco
{
    internal class ArtistaDAL : DAL<Artista>
    {
        private readonly ScreenSoundContext context;

        public ArtistaDAL(ScreenSoundContext context)
        {
            this.context = context;
        }

        public override IEnumerable<Artista> Listar()
        {
            return context.Artista.ToList();
        }

        public override void Adicionar(Artista artista)
        {
            context.Artista.Add(artista);
            context.SaveChanges();
        }

        public override void Atualizar(Artista artista)
        {
            context.Artista.Update(artista);
            context.SaveChanges();
        }

        public override void Deletar(Artista artista)
        {
            context.Artista.Remove(artista);
            context.SaveChanges();
        }

        public Artista? RecuperarPeloNome(string nome)
        {
            return context.Artista.FirstOrDefault(a => a.Nome.Equals(nome));
        }
    }
}
