using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CWsite.Models
{
    public class RegistrationModel
    {
        public static IDictionary<string, User> Users { get; } = new Dictionary<string, User>();

        public static void Add(User user)
        {
            lock (Users)
            {
                Users.Add(user._login, user);
            }
        }

        /*public static void Add(Post post)
        {
            lock (Posts)
            {
                Posts.Add(post);
            }
        }*/



        /*public static IEnumerable<Post> GetPosts()
        {
            lock (Posts)
            {
                return new List<Post>(Posts);
            }
        }*/

        /*static Model()
        {
            Posts.Add(new Post(
                new DateTime(2020, 1, 1, 16, 13, 49),
                "Author 1",
                "First default message"));
            Posts.Add(new Post(
                DateTime.Now,
                "Author 2",
                "Second default message"));
        }*/
    }
}
