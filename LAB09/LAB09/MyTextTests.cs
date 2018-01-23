﻿
using NUnit.Framework;


namespace LAB09
{
    [TestFixture]
    class MyTextTests
        
    {
        
        [TestCase]
        public void Concat01()
        {
            MyText txt = new MyText();
            Assert.IsNotEmpty(txt.Concat("Olá", ""));
        }
        [TestCase]
        public void Concat03()
        {
            MyText txt = new MyText();
            StringAssert.Contains("Sucesso", txt.Concat("Terminou", "Sucesso"));
        }
        [TestCase]
        public void Concat04()
        {
            MyText txt = new MyText();
            Assert.That(txt.Concat("Terminou", "Sucesso"), Does.Not.Contain("erro"));
        }
        [TestCase]
        public void Concat05()
        {
            MyText txt = new MyText();
            StringAssert.StartsWith("Parabéns", txt.Concat("Parabéns! ",
           "Concluído."));
        }
        [TestCase]
        public void Concat06()
        {
            MyText txt = new MyText();
            StringAssert.EndsWith("!", txt.Concat("Parabéns!", ""));
        }
        [TestCase]
        public void Concat07()
        {
            MyText txt = new MyText();
            StringAssert.AreEqualIgnoringCase("erro", txt.Concat("ER", "RO"));
        }
        [TestCase]
        public void Concat08()
        {
            MyText txt = new MyText();
            StringAssert.IsMatch("sucesso", txt.Concat("Ligação ", "com sucesso."));
        }


    }
}
