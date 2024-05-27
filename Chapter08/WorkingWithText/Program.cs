﻿string city = "London";
WriteLine($"{city} is {city.Length} characters long.");

WriteLine($"First char is {city[0]} and fourth is {city[3]}.");

string cities = "Paris,Tehran,Chennai,Sydney,New York,Medellín";

string[] citiesArray = cities.Split(',');

WriteLine($"There are {citiesArray.Length} items in the array:");

foreach (string item in citiesArray)
{
    WriteLine($"  {item}");
}
