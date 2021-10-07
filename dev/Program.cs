using System;
using System.Linq;

namespace dev
{
    class Program
    {
        static void Main(string[] args)
        {
            // получение данных
            using (DatabaseContext db = new DatabaseContext())
            {
                var users = db.users.ToList();
                Console.WriteLine("Список объектов:");
                foreach (User user in users)
                {
                    Console.WriteLine($"[{user.Id}] {user.LastName} {user.Name} {user.Patronymic}");
                }
            }
        }
    }
}
