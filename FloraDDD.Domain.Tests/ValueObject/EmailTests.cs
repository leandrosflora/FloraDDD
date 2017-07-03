using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FloraDDD.Domain.ValueObject;

namespace FloraDDD.Domain.Tests.ValueObject
{
    [TestClass]
    public class EmailTests
    {
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Email_New_Email_Em_Branco()
        {
            var email = new Email("");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Email_New_Email_Null()
        {
            var email = new Email(null);
        }

        [TestMethod]
        public void Email_New_Email_Valido()
        {
            var endereco = "teste@gmail.com";
            var email = new Email(endereco);
            Assert.AreEqual(endereco, email.Endereco);
        }
        
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Email_New_Email_Invalido()
        {
            var email = new Email("sdfgsdbglsdkjbgsdlkgb");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Email_New_Email_Erro_MaxLength()
        {
            var endereco = "teste@gmail.com.br";
            while (endereco.Length < Email.EnderecoMaxLength + 1)
            {
                endereco = endereco + "teste@gmail.com.br";
            }

            new Email(endereco);
        }
    }
}

