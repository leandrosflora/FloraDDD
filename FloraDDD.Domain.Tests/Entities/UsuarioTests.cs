﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FloraDDD.Domain.Entities;
using FloraDDD.Domain.Enuns;
using FloraDDD.Domain.ValueObject;

namespace FloraDDD.Domain.Tests.Entities
{
    [TestClass]
    public class UsuarioTests
    {
        private Cpf Cpf { get; set; }
        private Email Email { get; set; }
        private string Login { get; set; }

        private string Senha { get; set; }
        private string SenhaConfirmacao { get; set; }
        private Usuario Usuario { get; set; }

        private Endereco Endereco { get; set; }

        public UsuarioTests()
        {
            Cpf = new Cpf("40914294830");
            Email = new Email("teste@gmail.com");
            Login = "adminteste";
            Senha = "123456";
            SenhaConfirmacao = "123456";
            Endereco = new Endereco("rua teste", "complemento teste", "numero teste", "bairro teste", "cidade teste",
                Uf.SP, new Cep("06400-000")); 
            Usuario = new Usuario(Login, Cpf, Email, Senha, SenhaConfirmacao, Endereco);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Usuario_New_Cpf_Obrigatorio()
        {
            new Usuario(Login, null, Email, Senha, SenhaConfirmacao, Endereco);
        }
        
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Usuario_New_Login_Obrigatorio()
        {
            new Usuario("", Cpf, Email, Senha, SenhaConfirmacao, Endereco);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Usuario_New_Email_Obrigatorio()
        {
            new Usuario(Login, Cpf, null, Senha, SenhaConfirmacao, Endereco);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Usuario_New_Senha_Obrigatorio()
        {
            new Usuario(Login, Cpf, Email, "", SenhaConfirmacao, Endereco);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Usuario_New_SenhaConfirmacao_Obrigatorio()
        {
            new Usuario(Login, Cpf, Email, Senha, "", Endereco);
        }

        [TestMethod]
        public void Usuario_New_Cpf()
        {
            Assert.AreEqual(Cpf, Usuario.Cpf);
        }

        [TestMethod]
        public void Usuario_New_Login()
        {
            Assert.AreEqual(Login, Usuario.Login);
        }

        [TestMethod]
        public void Usuario_New_Email()
        {
            Assert.AreEqual(Email, Usuario.Email);
        }

        [TestMethod]
        public void Usuario_New_Senha()
        {
            Assert.IsNotNull(Usuario.Senha);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Usuario_SetLogin_Min_Value()
        {
            Usuario.SetLogin("12345");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Usuario_SetLogin_Max_Value()
        {
            Usuario.SetLogin("1234567890123456789012345678901");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Usuario_SetSenha_Min_Value()
        {
            var senha = "12345";
            new Usuario(Login, Cpf, Email, senha, senha, Endereco);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Usuario_SetSenha_Max_Value()
        {
            var senha = "1234567890123456789012345678901";
            new Usuario(Login, Cpf, Email, senha, senha, Endereco);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Usuario_SetSenha_Senhas_Nao_Conferem()
        {
            new Usuario(Login, Cpf, Email, "testeteste", "blablablabla", Endereco);
        }
    }
}
