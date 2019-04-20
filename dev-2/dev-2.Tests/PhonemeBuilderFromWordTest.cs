using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dev_2.Tests
{
    [TestClass]
    public class PhonemeBuilderFromWordTest
    {
        /// <summary>
        ///  Negative test for constructor of the PhonemeBuilderFromWord class.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(Exception), "String is empty!")]
        public void EmptyString_Exception_Check()
        {
            var phonemeBuilder = new PhonemeBuilderFromWord(String.Empty);
        }

        /// <summary>
        /// Negative test for constructor of the PhonemeBuilderFromWord class.
        /// </summary>
        /// <param name="input">Inputed string</param>
        [DataTestMethod]
        [DataRow("a")]
        [DataRow("+")]
        [ExpectedException(typeof(Exception), "String length is shorter than 2 characters!")]
        public void ShortString_Exception_Check(string input)
        {
            var phonemeBuilder = new PhonemeBuilderFromWord(input);
        }

        /// <summary>
        /// Positive test for BuildPhoneme method of the PhonemeBuilderFromWord class.
        /// </summary>
        /// <param name="input">Inputed string</param>
        /// <param name="expectedResult">Expected result string</param>
        [DataTestMethod]
        [DataRow("молоко+", "малако")]
        [DataRow("поле+но", "пал'эна")]
        public void UnstressedO_Check(string input, string expectedResult)
        {
            var phonemeBuilder = new PhonemeBuilderFromWord(input);
            var result = phonemeBuilder.BuildPhoneme();
            Assert.AreEqual(result, expectedResult);
        }

        /// <summary>
        /// Positive test for BuildPhoneme method of the PhonemeBuilderFromWord class.
        /// </summary>
        /// <param name="input">Inputed string</param>
        /// <param name="expectedResult">Expected result string</param>
        [DataTestMethod]
        [DataRow("ме+сто", "м'эста")]
        [DataRow("тря+пка", "тр'апка")]
        [DataRow("мель", "м'эл'")]
        public void SoftConsonant_Check(string input, string expectedResult)
        {
            var phonemeBuilder = new PhonemeBuilderFromWord(input);
            var result = phonemeBuilder.BuildPhoneme();
            Assert.AreEqual(result, expectedResult);
        }

        /// <summary>
        /// Positive test for BuildPhoneme method of the PhonemeBuilderFromWord class.
        /// </summary>
        /// <param name="input">Inputed string</param>
        /// <param name="expectedResult">Expected result string</param>
        [DataTestMethod]
        [DataRow("ёлка", "йолка")]
        [DataRow("вью+га", "в'йуга")]
        [DataRow("моё", "майо")]
        public void DoubleVowel_Check(string input, string expectedResult)
        {
            var phonemeBuilder = new PhonemeBuilderFromWord(input);
            var result = phonemeBuilder.BuildPhoneme();
            Assert.AreEqual(result, expectedResult);
        }

        /// <summary>
        /// Positive test for BuildPhoneme method of the PhonemeBuilderFromWord class.
        /// </summary>
        /// <param name="input">Inputed string</param>
        /// <param name="expectedResult">Expected result string</param>
        [DataTestMethod]
        [DataRow("ска+зка", "скаска")]
        [DataRow("сде+лать", "зд'элат'")]
        [DataRow("зуб", "зуп")]
        public void VoicingStunningConsonants_Check(string input, string expectedResult)
        {
            var phonemeBuilder = new PhonemeBuilderFromWord(input);
            var result = phonemeBuilder.BuildPhoneme();
            Assert.AreEqual(result, expectedResult);
        }
    }
}