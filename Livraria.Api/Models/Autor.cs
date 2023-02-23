using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Livraria.Api.Models
{
    [PrimaryKey(nameof(IdAutor))]
    public class Autor
    {
        public Autor(int idAutor, string nome, int dataNascimento, string obras)
        {
            this.IdAutor = idAutor;
            this.Nome = nome;
            this.DataNascimento = dataNascimento;
            this.Obras = obras;
        }

        public int IdAutor { get; set; }

        public string Nome { get; set; }

        public int DataNascimento { get; set; }

        public string Obras { get; set; }
    }
}
