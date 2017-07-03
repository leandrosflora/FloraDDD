using FloraDDD.Domain.Entities;
using FloraDDD.Domain.ValueObject;
using System.Collections.Generic;

namespace FloraDDD.Domain.IRepositories
{
    public interface IUsuarioRepository
    {
        bool CpfJaCadastrado(Cpf cpf, int usuarioId);
        bool LoginJaCadastrado(string login, int usuarioId);
        Usuario Get(string login);
        Usuario Get(Email email);
        Usuario Get(int id);
        void Salvar(Usuario usuario);
        List<Usuario> GetAll();
    }
}