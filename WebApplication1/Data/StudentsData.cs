using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class StudentsData
    {

        public List<Student> students { get; set; }

        public StudentsData()
        {
            students = new List<Student>();
            students.Add(new Student
            {
                Id = 1,
                FirstName = "Jan",
                LastName = "Kowalski",
                Birthdate = DateTime.Now.Date.ToString("MM") + "/" + DateTime.Now.Date.ToString("dd") + "/" + DateTime.Now.Date.ToString("yyyy"),
                Studies = "Informatyka",
                Picture = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT_cbIlyB8fgAJ29jTbASDvUO53g28QJlkZQw&usqp=CAU"
            });

            students.Add(new Student
            {
                Id = 2,
                FirstName = "Anna",
                LastName = "Malewska",
                Birthdate = DateTime.Now.Date.ToString("MM") + "/" + DateTime.Now.Date.ToString("dd") + "/" + DateTime.Now.Date.ToString("yyyy"),
                Studies = "Informatyka",
                Picture = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT_cbIlyB8fgAJ29jTbASDvUO53g28QJlkZQw&usqp=CAU"
            });

            students.Add(new Student
            {
                Id = 3,
                FirstName = "Karolina",
                LastName = "Piotrak",
                Birthdate = DateTime.Now.Date.ToString("MM") + "/" + DateTime.Now.Date.ToString("dd") + "/" + DateTime.Now.Date.ToString("yyyy"),
                Studies = "Logistyka",
                Picture = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT_cbIlyB8fgAJ29jTbASDvUO53g28QJlkZQw&usqp=CAU"
            });

            students.Add(new Student
            {
                Id = 4,
                FirstName = "Artur",
                LastName = "Grabowski",
                Birthdate = DateTime.Now.Date.ToString("MM") + "/" + DateTime.Now.Date.ToString("dd") + "/" + DateTime.Now.Date.ToString("yyyy"),
                Studies = "Zarządzanie",
                Picture = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT_cbIlyB8fgAJ29jTbASDvUO53g28QJlkZQw&usqp=CAU"
            });

            students.Add(new Student
            {
                Id = 5,
                FirstName = "Tomasz",
                LastName = "Jabłoński",
                Birthdate = DateTime.Now.Date.ToString("MM") + "/" + DateTime.Now.Date.ToString("dd") + "/" + DateTime.Now.Date.ToString("yyyy"),
                Studies = "Zarządzanie",
                Picture = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT_cbIlyB8fgAJ29jTbASDvUO53g28QJlkZQw&usqp=CAU"
            });
            students.Add(new Student
            {
                Id = 6,
                FirstName = "Weronika",
                LastName = "Król",
                Birthdate = DateTime.Now.Date.ToString("MM") + "/" + DateTime.Now.Date.ToString("dd") + "/" + DateTime.Now.Date.ToString("yyyy"),
                Studies = "Zarządzanie",
                Picture = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT_cbIlyB8fgAJ29jTbASDvUO53g28QJlkZQw&usqp=CAU"
            });
            students.Add(new Student
            {
                Id = 7,
                FirstName = "Monika",
                LastName = "Wróblewska",
                Birthdate = DateTime.Now.Date.ToString("MM") + "/" + DateTime.Now.Date.ToString("dd") + "/" + DateTime.Now.Date.ToString("yyyy"),
                Studies = "Informatyka",
                Picture = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT_cbIlyB8fgAJ29jTbASDvUO53g28QJlkZQw&usqp=CAU"
            });
            students.Add(new Student
            {
                Id = 8,
                FirstName = "Artur",
                LastName = "Grabowski",
                Birthdate = DateTime.Now.Date.ToString("MM") + "/" + DateTime.Now.Date.ToString("dd") + "/" + DateTime.Now.Date.ToString("yyyy"),
                Studies = "Zarządzanie",
                Picture = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT_cbIlyB8fgAJ29jTbASDvUO53g28QJlkZQw&usqp=CAU"
            });
            students.Add(new Student
            {
                Id = 9,
                FirstName = "Adam",
                LastName = "Sosnowski",
                Birthdate = DateTime.Now.Date.ToString("MM") + "/" + DateTime.Now.Date.ToString("dd") + "/" + DateTime.Now.Date.ToString("yyyy"),
                Studies = "Zarządzanie",
                Picture = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT_cbIlyB8fgAJ29jTbASDvUO53g28QJlkZQw&usqp=CAU"
            });
            students.Add(new Student
            {
                Id = 10,
                FirstName = "Dominik",
                LastName = "Smoliński",
                Birthdate = DateTime.Now.Date.ToString("MM") + "/" + DateTime.Now.Date.ToString("dd") + "/" + DateTime.Now.Date.ToString("yyyy"),
                Studies = "Zarządzanie",
                Picture = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT_cbIlyB8fgAJ29jTbASDvUO53g28QJlkZQw&usqp=CAU"
            });

        }
    }   
}
