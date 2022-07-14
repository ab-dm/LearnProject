﻿using LearnProject.MorseCodeAlphabet;
using NUnit.Framework;

namespace LearnProjectTest.MorseCodeAlphabetTest
{
    [TestFixture]
    public class UsingIfTests
    {
        [TestCase('A', ExpectedResult = ".-")]
        [TestCase('a', ExpectedResult = ".-")]
        [TestCase('B', ExpectedResult = "-...")]
        [TestCase('b', ExpectedResult = "-...")]
        [TestCase('C', ExpectedResult = "-.-.")]
        [TestCase('c', ExpectedResult = "-.-.")]
        [TestCase('D', ExpectedResult = "-..")]
        [TestCase('d', ExpectedResult = "-..")]
        [TestCase('E', ExpectedResult = ".")]
        [TestCase('e', ExpectedResult = ".")]
        [TestCase('F', ExpectedResult = "..-.")]
        [TestCase('f', ExpectedResult = "..-.")]
        [TestCase('G', ExpectedResult = "--.")]
        [TestCase('g', ExpectedResult = "--.")]
        [TestCase('H', ExpectedResult = "....")]
        [TestCase('h', ExpectedResult = "....")]
        [TestCase('I', ExpectedResult = "..")]
        [TestCase('i', ExpectedResult = "..")]
        [TestCase('J', ExpectedResult = ".---")]
        [TestCase('j', ExpectedResult = ".---")]
        [TestCase('K', ExpectedResult = "-.-")]
        [TestCase('k', ExpectedResult = "-.-")]
        [TestCase('L', ExpectedResult = ".-..")]
        [TestCase('l', ExpectedResult = ".-..")]
        [TestCase('M', ExpectedResult = "--")]
        [TestCase('m', ExpectedResult = "--")]
        [TestCase('N', ExpectedResult = "-.")]
        [TestCase('n', ExpectedResult = "-.")]
        [TestCase('O', ExpectedResult = "---")]
        [TestCase('o', ExpectedResult = "---")]
        [TestCase('P', ExpectedResult = ".--.")]
        [TestCase('p', ExpectedResult = ".--.")]
        [TestCase('Q', ExpectedResult = "--.-")]
        [TestCase('q', ExpectedResult = "--.-")]
        [TestCase('R', ExpectedResult = ".-.")]
        [TestCase('r', ExpectedResult = ".-.")]
        [TestCase('S', ExpectedResult = "...")]
        [TestCase('s', ExpectedResult = "...")]
        [TestCase('T', ExpectedResult = "-")]
        [TestCase('t', ExpectedResult = "-")]
        [TestCase('U', ExpectedResult = "..-")]
        [TestCase('u', ExpectedResult = "..-")]
        [TestCase('V', ExpectedResult = "...-")]
        [TestCase('v', ExpectedResult = "...-")]
        [TestCase('W', ExpectedResult = ".--")]
        [TestCase('w', ExpectedResult = ".--")]
        [TestCase('X', ExpectedResult = "-..-")]
        [TestCase('x', ExpectedResult = "-..-")]
        [TestCase('Y', ExpectedResult = "-.--")]
        [TestCase('y', ExpectedResult = "-.--")]
        [TestCase('Z', ExpectedResult = "--..")]
        [TestCase('z', ExpectedResult = "--..")]
        [TestCase(' ', ExpectedResult = "")]
        [TestCase('+', ExpectedResult = "")]
        [TestCase('0', ExpectedResult = "")]
        [TestCase('9', ExpectedResult = "")]
        public string GetMorseCode(char c)
        {
            // Act
            return UsingIf.GetMorseCode(c);
        }
    }
}
