//using System.Data.Entity.Migrations;
using FloraDDD.Domain.Entities;
using FloraDDD.Domain.Enuns;
using FloraDDD.Domain.ValueObject; 

namespace FloraDDD.Repositories.Seeds
{
    public class UsuarioSeed
    {
        public static void Seed(EfDbContext context)
        {
            var endereco = new Endereco("Rua teste", "complemento teste", "numero teste", "bairroteste", "cidadeteste",
                Uf.SP, new Cep("06414-110"));

            var usu = new Usuario("adminMaster", new Cpf("40914294830"), new Email("teste@gmail.com"), "testeteste", "testeteste", endereco);

            context.Usuarios.Add(usu);
        }
    }
}
