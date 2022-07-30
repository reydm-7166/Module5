using Module1;
using NUnit.Framework;

namespace Module1Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Create()
        {
            insertclass user = new insertclass();
            Assert.AreEqual(true, user.TestInsert("Reymond", 21, 21, 212123123));
        }
        [Test]
        public void Delete()
        {
            insertclass user = new insertclass();
            Assert.AreEqual(true, user.TestDelete(2));
        }
        [Test]
        public void ConnectDB()
        {
            insertclass user = new insertclass();
            Assert.AreEqual(true, user.DatabaseConnection());
        }
    }
}