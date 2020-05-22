using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kakapo.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kakapo.DataAccess.Model.Tests
{
    [TestClass()]
    public class Tests_User
    {
        [TestMethod()]
        public void Test_GetAllUsers()
        {
            // Arrange
            User user = new User();
            List<User> listOfUser = new List<User>();

            //Action
            listOfUser = user.GetAllUsers();

            // Assert
            Assert.AreNotEqual(0, listOfUser.Count);
        }

        [TestMethod()]
        public void Test_GetAValidUser()
        {
            // Arrange
            User user = new User();

            //Action
            user = user.GetAnUser(1);

            // Assert
            Assert.AreEqual(1, user.id);
            Assert.AreEqual("Leanne Graham", user.name);
            Assert.AreEqual("Bret", user.username);
            Assert.AreEqual("Sincere@april.biz", user.email);
        }

        [TestMethod()]
        public void Test_GetAnInvalidUser()
        {
            // Arrange
            User user = new User();

            //Action
            user = user.GetAnUser(100);

            // Assert
            Assert.AreNotEqual(null, user);
        }
    }
}