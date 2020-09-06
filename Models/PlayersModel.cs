using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CWsite.Models
{

    public class PlayersModel
    {

        public static IDictionary<string, List<User>> GetClan(string clan)
        {
            var thisClan = new Dictionary<string, List<User>>();
            foreach (var user in RegistrationModel.Users)
            {
                if (user.Value._login == "admin") continue;
                if (user.Value._clan == clan && clan != "Другие")
                {
                    var userRank = user.Value._rank;
                    if (userRank == "Предводитель")
                        if (!thisClan.ContainsKey("Предводитель")) thisClan.Add("Предводитель", new List<User> { user.Value });
                        else
                        {
                            thisClan.TryGetValue("Предводитель", out List<User> u);
                            u.Add(user.Value);
                            thisClan["Предводитель"] = u;
                        }

                    else if (userRank == "Глашатай")
                        if (!thisClan.ContainsKey("Глашатай")) thisClan.Add("Глашатай", new List<User> { user.Value });
                        else
                        {
                            thisClan.TryGetValue("Глашатай", out List<User> u);
                            u.Add(user.Value);
                            thisClan["Глашатай"] = u;
                        }

                    else if (userRank == "Воин")
                        if (!thisClan.ContainsKey("Воин")) thisClan.Add("Воин", new List<User> { user.Value });
                        else
                        {
                            thisClan.TryGetValue("Воин", out List<User> u);
                            u.Add(user.Value);
                            thisClan["Воин"] = u;
                        }

                    else if (userRank == "Целитель")
                        if (!thisClan.ContainsKey("Целитель")) thisClan.Add("Целитель", new List<User> { user.Value });
                        else
                        {
                            thisClan.TryGetValue("Целитель", out List<User> u);
                            u.Add(user.Value);
                            thisClan["Целитель"] = u;
                        }
                    else if (userRank == "Ученик целителя")
                        if (!thisClan.ContainsKey("Ученик целителя")) thisClan.Add("Ученик целителя", new List<User> { user.Value });
                        else
                        {
                            thisClan.TryGetValue("Ученик целителя", out List<User> u);
                            u.Add(user.Value);
                            thisClan["Ученик целителя"] = u;
                        }
                    else if (userRank == "Оруженосец")
                        if (!thisClan.ContainsKey("Оруженосец")) thisClan.Add("Оруженосец", new List<User> { user.Value });
                        else
                        {
                            thisClan.TryGetValue("Оруженосец", out List<User> u);
                            u.Add(user.Value);
                            thisClan["Оруженосец"] = u;
                        }
                    else if (userRank == "Котёнок")
                        if (!thisClan.ContainsKey("Котёнок")) thisClan.Add("Котёнок", new List<User> { user.Value });
                        else
                        {
                            thisClan.TryGetValue("Котёнок", out List<User> u);
                            u.Add(user.Value);
                            thisClan["Котёнок"] = u;
                        }
                    else if (userRank == "Старейшина")
                        if (!thisClan.ContainsKey("Старейшина")) thisClan.Add("Старейшина", new List<User> { user.Value });
                        else
                        {
                            thisClan.TryGetValue("Старейшина", out List<User> u);
                            u.Add(user.Value);
                            thisClan["Старейшина"] = u;
                        }
                }
                else if (clan == "Одиночки/домашние" && user.Value._clan == "Домашний") {
                        if (!thisClan.ContainsKey("Домашний")) thisClan.Add("Домашний", new List<User> { user.Value });
                        else
                        {
                            thisClan.TryGetValue("Домашний", out List<User> u);
                            u.Add(user.Value);
                            thisClan["Домашний"] = u;
                        }
                }
                else if (clan == "Одиночки/домашние" && user.Value._clan == "Одиночка")
                {
                    if (!thisClan.ContainsKey("Одиночка")) thisClan.Add("Одиночка", new List<User> { user.Value });
                    else
                    {
                        thisClan.TryGetValue("Одиночка", out List<User> u);
                        u.Add(user.Value);
                        thisClan["Одиночка"] = u;
                    }
                }
            }
            return thisClan;
        }





        public static User GetUser(string userName) {
            User u = new User();
            foreach (var user in RegistrationModel.Users)
            {
                if (user.Value._currentName == userName)
                {
                    u = user.Value;
                    break;
                }
            }
            return u;
        }
    }
}
