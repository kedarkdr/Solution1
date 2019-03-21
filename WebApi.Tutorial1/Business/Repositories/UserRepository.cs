using System.Collections.Generic;
using WebApi.Tutorial1.Models;
using System.Linq;
using System;

namespace WebApi.Tutorial1.Business.Repositories
{
    public class UserRepository
    {
        private List<User> _usersStore; // = new List<User>();

        private static readonly log4net.ILog _log = log4net.LogManager.GetLogger("UserRepository");

        public IEnumerable<User> GetAll()
        {
            _log.Info("Received GetAll users request");
            return _usersStore;
        }

        public User GetById(int id)
        {
            try
            {
                return _usersStore.FirstOrDefault(x => x.Id == id);
            }
            catch (Exception ex)
            {
                _log.Error(ex.ToString());
                throw;
            }

        }

        public void Add(User user)
        {
            if(user == null)
            {
                throw new ArgumentException("Cannot add null object to the store", "user");
            }

            _usersStore.Add(user);
        }

    }

}
