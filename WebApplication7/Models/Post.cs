using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication7.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public string Image { get; set; } // Caminho da imagem já hospedada
        public IFormFile ImageFile { get; set; } // O buffer do arquivo durante o upload
    }
}
