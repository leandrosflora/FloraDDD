using FloraDDD.Domain.Entities;
using FloraDDD.Domain.ValueObject;

namespace FloraDDD.Domain.IApp
{
    public interface IUsuarioApp
    {
        Usuario Get(string login);
        Usuario Get(Email email);
        Usuario Get(int id);
        void Salvar(Usuario usuario);
    }
}
