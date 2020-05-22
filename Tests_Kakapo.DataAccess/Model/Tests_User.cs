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
            Assert.AreEqual(null, user);
        }

        [TestMethod()]
        public void Test_CreateAnUser()
        {
            // Arrange
            User user = new User();
            user.name = "Khoi Kien Dinh";
            user.username = "khoikien";
            user.email = "matdanhk97@gmail.com";
            user.phone = "+84113114115";
            user.website = "https://github.com";
            user.address = new Address()
            {
                street = "Nguyen Van Linh",
                suite = "Quan 7",
                city = "Ho Chi Minh",
                zipcode = "70000",
            };
            user.address.geo = new Geo()
            {
                lat = "-37.3159",
                lng = "81.1496",
            };
            user.company = new Company()
            {
                name = "SCC Vietnam",
                catchPhrase = "Multi-layered client-server neural-net",
                bs = "harness real-time e-markets",
            };

            bool isCreated;

            //Action
            isCreated = user.CreateAnUser(user);

            // Assert
            Assert.IsTrue(isCreated);
        }

        [TestMethod()]
        public void Test_UpdateAnUser()
        {
            // Arrange
            User user = new User();
            user.id = 1;
            user.name = "Khoi Kien Dinh";
            user.username = "khoikien";
            user.email = "matdanhk97@gmail.com";
            user.phone = "+84113114115";
            user.website = "https://github.com";
            user.address = new Address()
            {
                street = "Nguyen Van Linh",
                suite = "Quan 7",
                city = "Ho Chi Minh",
                zipcode = "70000",
            };
            user.address.geo = new Geo()
            {
                lat = "-37.3159",
                lng = "81.1496",
            };
            user.company = new Company()
            {
                name = "SCC Vietnam",
                catchPhrase = "Multi-layered client-server neural-net",
                bs = "harness real-time e-markets",
            };

            bool isUpdated;

            //Action
            isUpdated = user.UpdateAnUser(user);

            // Assert
            Assert.IsTrue(isUpdated);
        }

        [TestMethod()]
        public void Test_DeleteAnUser()
        {
            // Arrange
            User user = new User();
            bool isDeleted;

            //Action
            isDeleted = user.DeleteAnUser(1);

            // Assert
            Assert.IsTrue(isDeleted);
        }
    }
}