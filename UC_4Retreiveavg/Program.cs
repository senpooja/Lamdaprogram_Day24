﻿using Lamda;
Console.WriteLine("Welcome to Lamda Expression Problem");
List<CreatePerson> listPersonInCity = new List<CreatePerson>();
listPersonInCity.Add(new CreatePerson("456-37-8664", "Vandana", "Sai pragna residency 4 street", 16));
listPersonInCity.Add(new CreatePerson("488-94-9884", "geetha", "Akgila residency 7 street", 15));
listPersonInCity.Add(new CreatePerson("933-64-9684", "sneha", "Priya residency 7 street", 18));
listPersonInCity.Add(new CreatePerson("928-65-4647", "navya", "Geetha residency 7 street", 89));
listPersonInCity.Add(new CreatePerson("953-74-5474", "gopal", "TTD residency 7 street", 14));
listPersonInCity.Add(new CreatePerson("235-36-3774", "varshu", "Cv residency 7 street", 55));
listPersonInCity.Add(new CreatePerson("235-36-3774", "varshu", "Cv residency 7 street", 65));
listPersonInCity.Add(new CreatePerson("464-74-7677", "sriya", "Aditya residency 7 street", 38));


//UC4
Console.WriteLine("\n______________________________________");
Console.WriteLine("Getting Average Of All The Person's Age: ");
double averageAge = listPersonInCity.Average(e => e.Age);
{
    Console.WriteLine("The Average Of All The Person's Age Is: {0}", averageAge);
}