using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MagicFilesLib;

using NUnit.Framework;


using Moq;


namespace DirectoryExplorer.Tests
{
    [TestFixture]
    public class test
    {
        private readonly string _file1 = "file.txt";

        private readonly string _file2 = "file2.txt";

        private readonly ICollection<string> files = new List<string>();

        Mock<IDirectoryExplorer> mockObj;
        [OneTimeSetUp]

public void init()

        {

            files.Add(_file1);

            files.Add(_file2);

            mockObj = new Mock<IDirectoryExplorer>();

            mockObj.Setup(m => m.GetFiles(@"C:\")).Returns(files);

        }

        [Test]
   public void Test_NotNull()
        {
            Assert.IsNotNull(mockObj.Object.GetFiles(@"C:\"));
        }

        [Test]
        public void Test_CountEqual()
        {
            Assert.AreEqual(mockObj.Object.GetFiles(@"C:\").Count, 2);
        }

        [Test]
        public void Test_ContainsFile1()
        {
            Assert.That(mockObj.Object.GetFiles(@"C:\").Contains(_file1));
        }
        
    }
}
