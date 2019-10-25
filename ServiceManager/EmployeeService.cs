using System;
using System.Collections.Generic;

namespace ServiceManager
{
    public class EmployeeService : IEmployeeService
    {
        public EmployeeService()
        {
        }

        public List<string> GetEmployeeNameList()
        {
            var list = new List<string>
            {
                "Shravan Madavu",
                "Girish kumar",
                 "Nidhi Reddy",
                "Maya  Nayar",
                 "Shagun Patel",
                "Sandhya reddy",
                 "Gayathri Rai",
                "Nisha Shetty",
                 "Ramesh Patel",
                "Samaresh kumar",
                "Ravi reddy",
                 "Anand maurya",
                "Nimisha Patel",
                 "Ramesh S",
                "Sandesh nayar",
                "Navami Rai",
                "Jagan Kundar",
                "Charu Shetty",
                "Naveena kundar",
                "Megha Choudhary",
                "Nayana Rao",
                "Shanmukha Maurya",
                "Naveen padki",
                "Sharu srivastava",
                "Dheeraj Kushwaha",
                "Joshi naveen",
                "Kotte Jayan",
                "Ravi naganna",
                "Kiran kumar",
                "Elicia Esposito",
                "Buster Faye",
                "Loriann Santi",
                "Leena Sherrick",
                "Jenise Mcnabb",
                "Juana Donaldson",
                "Shantell Nauman",
                "Karlene Levert",
                "Marianela Hafner",
                "Efrain Miguez",
                "Almeta Fannon",
                "Shani Castro",
                "Erline Kardos",
                "Loretta Tomer",
                "Clarence Valasq",
                "Micheal Dimmick",
                "Carlton Linn",
                "Bessie Morreal",
                "Garland Boatner",
                "Vivien Perras"

            };

            return list;
        }
    }
}
