// <copyright file="ImageImportDescriptorsParserTest.cs">Copyright ©  2016</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PeNet.Parser.Tests
{
    [TestClass]
    [PexClass(typeof(ImageImportDescriptorsParser))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class ImageImportDescriptorsParserTest
    {
        [PexMethod]
        internal ImageImportDescriptorsParser Constructor(byte[] buff, uint offset)
        {
            var target = new ImageImportDescriptorsParser(buff, offset);
            return target;
            // TODO: add assertions to method ImageImportDescriptorsParserTest.Constructor(Byte[], UInt32)
        }
    }
}