using Kakapo.DataAccess.Config;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace Kakapo.DataAccess.Model
{
    public class User
    {
        #region Properties
        public int id { get; set; }
        public string name { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string website { get; set; }
        public Address address { get; set; }
        public Company company { get; set; }
        #endregion

        #region Instances
        #endregion

        #region Methods
        public List<User> GetAllUsers()
        {
            List<User> listOfUser = new List<User>();
            string apiUrl = "https://jsonplaceholder.typicode.com/users";
            RestSharpConfig restSharp = new RestSharpConfig(apiUrl, Method.GET);
            listOfUser = JsonConvert.DeserializeObject<List<User>>(restSharp.ExcuteRequest());

            return listOfUser;
        }

        public User GetAnUser(int id)
        {
            User user = new User();
            string apiUrl = "https://jsonplaceholder.typicode.com/users/" + id;
            RestSharpConfig restSharp = new RestSharpConfig(apiUrl, Method.GET);
            user = JsonConvert.DeserializeObject<User>(restSharp.ExcuteRequest());

            return user;
        }

        public void DeleteAnUser(int id)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}