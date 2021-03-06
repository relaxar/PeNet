// <copyright file="ImageNtHeadersParserTest.cs">Copyright ©  2016</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PeNet.Parser.Tests
{
    [TestClass]
    [PexClass(typeof(ImageNtHeadersParser))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class ImageNtHeadersParserTest
    {
        [PexMethod]
        internal ImageNtHeadersParser Constructor(
            byte[] buff,
            uint offset,
            bool is64Bit
            )
        {
            var target = new ImageNtHeadersParser(buff, offset, is64Bit);
            return target;
            // TODO: add assertions to method ImageNtHeadersParserTest.Constructor(Byte[], UInt32, Boolean)
        }
    }
}