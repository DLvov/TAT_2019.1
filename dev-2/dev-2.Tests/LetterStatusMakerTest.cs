using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dev_2.Tests
{
    [TestClass]
    public class LetterStatusMakerTest
    {
        /// <summary>
        /// Negative test for constructor of the LetterStatusMaker class. 
        /// </summary>
        /// <param name="input">Inputed symbol</param>
        [DataTestMethod]
        [DataRow('1')]
        [DataRow('a')]
        [DataRow('*')]
        [DataRow('&')]
        [ExpectedException(typeof(Exception), "Unknown symbol!")]
        public void Constructor_UnknownSymbol_Exception_Check(char input)
        {
            var letter = new LetterStatusMaker(input);
        }

        /// <summary>
        /// Positive test for constructor of the LetterStatusMaker class.
        /// </summary>
        /// <param name="input">Inputed symbol</param>
        [DataTestMethod]
        [DataRow('а')]
        [DataRow('я')]
        [DataRow('ь')]
        [DataRow('+')]
        public void Constructor_RightSymbol_Exception_Check(char input)
        {
            var letter = new LetterStatusMaker(input);
        }
    }
}