using Microsoft.EntityFrameworkCore;

namespace crud_api.Model
{
    public class Usuario
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public DateTime dtNascimento { get; set; }
    }
}