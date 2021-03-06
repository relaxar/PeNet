using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PeNet.Structures;
// <copyright file="ExportedFunctionsParserTest.cs">Copyright ©  2016</copyright>

namespace PeNet.Parser.Tests
{
    [TestClass]
    [PexClass(typeof(ExportedFunctionsParser))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class ExportedFunctionsParserTest
    {
        [PexMethod]
        internal ExportedFunctionsParser Constructor(
            byte[] buff,
            IMAGE_EXPORT_DIRECTORY exportDirectory,
            IMAGE_SECTION_HEADER[] sectionHeaders
            )
        {
            var target = new ExportedFunctionsParser(buff, exportDirectory, sectionHeaders);
            return target;
            // TODO: add assertions to method ExportedFunctionsParserTest.Constructor(Byte[], IMAGE_EXPORT_DIRECTORY, IMAGE_SECTION_HEADER[])
        }
    }
}