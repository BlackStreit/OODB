using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODB
{
    internal class User
    {
        [DisplayName("Возраст")]
        public int age { get; set; }
        [DisplayName("Имя")]
        public string name { get; set; }
        [DisplayName("Пароль")]
        public string password { get; set; }

        public User(string name, string password, int age)
        {
            this.age = age;
            this.name = name;
            this.password = password;
        }
        public override string ToString()
        {
            return $"Name: {name}, Password: {password}, Age: {age}";
        }
    }
}
