﻿using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Romanos.Teste
{
    [TestClass]
    public class RomanoTeste
    {
        [TestMethod]
        public void Faz1()
        {
            ConversorRomano.Converter(1).Should().Be("I");
        }
        [TestMethod]
        public void Faz2()
        {
            ConversorRomano.Converter(2).Should().Be("II");
        }
        [TestMethod]
        public void Faz3()
        {
            ConversorRomano.Converter(3).Should().Be("III");
        }
        [TestMethod]
        public void Faz4()
        {
            ConversorRomano.Converter(4).Should().Be("IV");
        }        
        [TestMethod]
        public void Faz5()
        {
            ConversorRomano.Converter(5).Should().Be("V");
        }
        [TestMethod]
        public void Faz6()
        {
            ConversorRomano.Converter(6).Should().Be("VI");
        }
        [TestMethod]
        public void Faz9()
        {
            ConversorRomano.Converter(9).Should().Be("IX");
        }        
        [TestMethod]
        public void Faz10()
        {
            ConversorRomano.Converter(10).Should().Be("X");
        }
        [TestMethod]
        public void Faz11()
        {
            ConversorRomano.Converter(11).Should().Be("XI");
        }
        [TestMethod]
        public void Faz15()
        {
            ConversorRomano.Converter(15).Should().Be("XV");
        }
        [TestMethod]
        public void Faz20()
        {
            ConversorRomano.Converter(20).Should().Be("XX");
        }
        [TestMethod]
        public void Faz50()
        {
            ConversorRomano.Converter(50).Should().Be("L");
        }
        [TestMethod]
        public void Faz51()
        {
            ConversorRomano.Converter(51).Should().Be("LI");
        }
        [TestMethod]
        public void Faz56()
        {
            ConversorRomano.Converter(56).Should().Be("LVI");
        }
        [TestMethod]
        public void Faz40()
        {
            ConversorRomano.Converter(40).Should().Be("XL");
        }
        [TestMethod]
        public void Faz100()
        {
            ConversorRomano.Converter(100).Should().Be("C");
        }
        [TestMethod]
        public void Faz90()
        {
            ConversorRomano.Converter(90).Should().Be("XC");
        }

        
    }
}