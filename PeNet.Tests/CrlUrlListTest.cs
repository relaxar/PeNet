using System;
using System.Security.Cryptography.X509Certificates;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

// <copyright file="CrlUrlListTest.cs">Copyright ©  2016</copyright>

namespace PeNet.Tests
{
    [TestClass]
    [PexClass(typeof(CrlUrlList))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class CrlUrlListTest
    {
        [PexMethod]
        public CrlUrlList Constructor(X509Certificate2 cert)
        {
            var target = new CrlUrlList(cert);
            return target;
            // TODO: add assertions to method CrlUrlListTest.Constructor(X509Certificate2)
        }

        [PexMethod]
        public CrlUrlList Constructor(byte[] rawData)
        {
            var target = new CrlUrlList(rawData);
            return target;
            // TODO: add assertions to method CrlUrlListTest.Constructor(Byte[])
        }
    }
}