using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CWsite
{
    public class User
    {
        public string _currentName { get; set; }

        public string _kittenName { get; set; }
        public string _squireName { get; set; }
        public string _warriorName { get; set; }
        public string _leaderName { get; set; }

        public string _age { get; set; }
        public string _gender { get; set; } 
        public string _clan { get; set; }
        public string _rank { get; set; }

        public string _description { get; set; }

        public string _login { get; set; }
        public string _password { get; set; }


        public User(string kittenName, string squireName, string warriorName, string leaderName, string age, string gender, string clan,
            string rank, string description, string login, string password) {
            _kittenName = kittenName;
            _squireName = squireName;
            _warriorName = warriorName;
            _leaderName = leaderName;
            _age = age;
            _gender = gender;
            _clan = clan;
            _rank = rank;
            _description = description;
            _login = login;
            _password = password;

            if (_rank == "Котёнок") _currentName = _kittenName;
            else if (_rank == "Оруженосец" || _rank == "Ученик целителя") _currentName = _squireName;
            else if (_rank == "Воин" || _rank == "Целитель" || _rank == "Старейшина") _currentName = _warriorName;
        }

        public User() { }

    }
}
