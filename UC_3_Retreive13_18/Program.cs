﻿using Lamda;

Console.WriteLine("Welcome to Lamda Expression Problem");
List<CreatePerson> listPersonInCity = new List<CreatePerson>();
listPersonInCity.Add(new CreatePerson("456-37-8664", "Vandana", "Sai pragna residency 4 street", 39));
listPersonInCity.Add(new CreatePerson("488-94-9884", "geetha", "Akgila residency 7 street", 50));
listPersonInCity.Add(new CreatePerson("933-64-9684", "sneha", "Priya residency 7 street", 26));
listPersonInCity.Add(new CreatePerson("456-37-8664", "Vandana", "Sai pragna residency 4 street", 16));
listPersonInCity.Add(new CreatePerson("488-94-9884", "geetha", "Akgila residency 7 street", 15));
listPersonInCity.Add(new CreatePerson("933-64-9684", "sneha", "Priya residency 7 street", 18));
listPersonInCity.Add(new CreatePerson("928-65-4647", "navya", "Geetha residency 7 street", 89));
listPersonInCity.Add(new CreatePerson("953-74-5474", "gopal", "TTD residency 7 street", 94));
listPersonInCity.Add(new CreatePerson("953-74-5474", "gopal", "TTD residency 7 street", 14));
listPersonInCity.Add(new CreatePerson("235-36-3774", "varshu", "Cv residency 7 street", 55));
listPersonInCity.Add(new CreatePerson("464-74-7677", "sriya", "Aditya residency 7 street", 38));

//UC-2
Console.WriteLine("Retrieving Top Two Aged persons From List Who Are Older Than 60 Years: ");
foreach (CreatePerson person in listPersonInCity.FindAll(e => (e.Age >= 60)).Take(2).ToList())
{
    Console.WriteLine("Name: {0} \n Age: {1}", person.Name, person.Age);
}

//UC-3
Console.WriteLine("Checking Whether any person is teen ager or not: ");
foreach (CreatePerson person in listPersonInCity.FindAll(e => (e.Age >= 13 && e.Age <= 18)))
{
    Console.WriteLine("Name: {0} \n Age: {1}", person.Name, person.Age);
}