using Demo_Asserts;
using NUnit.Framework;

namespace Demo_Asserts_Tests.Igualdade
{
    [TestFixture]
    public class JuntarNomesTests
    {
        /*Método de teste - finalidade: comparar strings juntas*/
        [Test]
        public void DevoJuntarNomeCompleto()
        {
            var sut = new JuntarNomes();
            var nomeCompleto = sut.Juntar("Rafael", "Nascimento");
            Assert.That(nomeCompleto, Is.EqualTo("Rafael Nascimento"));
        }

        /*Método de teste - finalidade: comparar string ignorando maiúsculas e minúsculas*/
        [Test]
        public void DevoJuntarNomeCompleto_CaseSensitive()
        {
            var sut = new JuntarNomes();
            var nomeCompleto = sut.Juntar("Rafael", "Nascimento");
            Assert.That(nomeCompleto, Is.EqualTo("Rafael Nascimento").IgnoreCase);
        }

        /*Método de teste - finalidade: comparar string diferentes*/
        [Test]
        public void DevoJuntarNomeCompleto_NaoIgual()
        {
            var sut = new JuntarNomes();
            var nomeCompleto = sut.Juntar("Rafael", "Nascimento");
            Assert.That(nomeCompleto, Is.Not.EqualTo("Rodolfo Silva").IgnoreCase);
        }



    }
}
