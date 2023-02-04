using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public static class Repository
    {
        private static ArrayList UserRepo { get; set; } = new ArrayList();

        public static bool Add(User user)
        {
            if (user.Password.Count() < 4 || user.Password.Count() > 8)
            { return false; }
            UserRepo.Add(user);
            return true;
        }

        public static bool Auth(string username, string password)
        {
            bool flag = false;
            foreach(User item in UserRepo)
            {
                if (item.Username.Equals(username) && item.Password.Equals(password))
                {
                    Console.WriteLine("Logado com sucesso");
                    flag = true;
                }
            }
            return flag;
        }
    }
}
