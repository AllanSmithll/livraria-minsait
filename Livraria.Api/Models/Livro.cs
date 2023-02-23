using Microsoft.EntityFrameworkCore;

namespace Livraria.Api.Models
{
    [PrimaryKey(nameof(Isbn))]
    public class Livro
    {
        public Livro(Guid isbn, string titulo, string subtitulo, string resumo, string genero, int quantPaginas, string dataPublicacao, int edicao, string nomeAutor, string nomeEditora)
        {
            this.Isbn = isbn;
            this.Titulo = titulo;
            this.Subtitulo = subtitulo;
            this.Resumo = resumo;
            this.Genero = genero;
            this.QuantPaginas = quantPaginas;
            this.DataPublicacao = dataPublicacao;
            this.Edicao = edicao;
            this.NomeAutor = nomeAutor;
            this.NomeEditora = nomeEditora;
        }

        public Guid Isbn { get; set; }

        public string Titulo { get; set; }

        public string Subtitulo { get; set; }

        public string Resumo { get; set; }

        public string Genero { get; set; }

        public int QuantPaginas { get; set; }

        public string DataPublicacao { get; set; }

        public int Edicao { get; set; }

        public string NomeAutor { get; set; }

        public string NomeEditora { get; set; }
    }
}
