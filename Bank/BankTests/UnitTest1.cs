using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BankAccountNS;

namespace BankTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Debit_WithValidAmount_UpdatesBalance()
        {
            // preparación del caso de prueba 
            double beginningBalance = 11.99;
            double debitAmount = 4.55;
            double expected = 7.44;
            BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);

            // acción a probar
            account.Debit(debitAmount);

            // afirmación de la prueba (valor esperado Vs. Valor obtenido)
            double actual = account.Balance;

            Assert.AreEqual(expected, actual, 0.001, "Error");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void DebitAmountMenorque0()
        {
            // preparación del caso de prueba 
            double beginningBalance = 12;
            double debitAmount = -1;
            BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);

            // acción a probar
            account.Debit(debitAmount);
        }
    }
}
