using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    class Animal
    {

        public string name;
        public int age;
        public string gender;

        public Animal(string name, int age, string gender)
        {
            this.Age = age;
            this.Name = name;
            this.Gender = gender;
        }



        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (!string.IsNullOrEmpty(name))
                {
                    throw new ArgumentNullException("Invalid input");
                }
                name = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (!string.IsNullOrEmpty(name))
                {
                    throw new ArgumentNullException("Invalid input");
                }
                else if (age <= 0)
                {
                    throw new ArgumentException("Invalid input");
                }
                age = value;
            }
        }

        public string Gender
        {
            get
            {
                return gender;
            }
            set
            {
                if (gender == "Male" || gender == "Female")
                {
                    Console.WriteLine(gender);
                }

                else
                {
                    throw new ArgumentNullException("Invalid input");
                }
                gender = value;
            }
        }

        public virtual string ProduceSound()
        {
            return string.Empty;
        }


        public virtual string Result()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append($"{this.Name} {this.Age} {this.Gender}{Environment.NewLine}");
            return stringBuilder.ToString();
        }
    }
}
