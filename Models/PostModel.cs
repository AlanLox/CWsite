using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CWsite.Models
{
    public class PostModel
    {

        private static IDictionary<string, List<Post>> Posts { get; } = new Dictionary<string, List<Post>>();


        public static void Add(string location, Post post)
        {
            lock (Posts)
            {
                Posts.TryGetValue(location, out List<Post> l);
                l.Insert(0, post);
                Posts[location] = l;
            }
        }

        public static IEnumerable<Post> GetPosts(string location)
        {
            Posts.TryGetValue(location, out List<Post> l);
            lock (l)
            {
                return new List<Post>(l);
            }
        }

        static PostModel()
        {
            Posts.Add("Questions", new List<Post> { new Post(DateTime.Now, "admin", "...") });

            Posts.Add("FourTrees", new List<Post>{ new Post(DateTime.Now, "admin", "...") });

            Posts.Add("ThunderClan", new List<Post> { new Post(DateTime.Now, "admin", "...") });

            Posts.Add("RiverClan", new List<Post> { new Post(DateTime.Now, "admin", "...") });

            Posts.Add("ShadowClan", new List<Post> { new Post(DateTime.Now, "admin", "...") });

            Posts.Add("WindClan", new List<Post> { new Post(DateTime.Now, "admin", "...") });

            Posts.Add("Loners", new List<Post> { new Post(DateTime.Now, "admin", "...") });
        }
    }
}
