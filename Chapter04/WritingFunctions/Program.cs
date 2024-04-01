// TimesTable(10, 10);

ConfigureConsole(culture: "fr-FR");

decimal taxToPay = CalculateTax(amount: 149, twoLetterRegionCode: "FR");
WriteLine($"You must pay {taxToPay:C} in tax.");

// Alternatively, call the function in the interpolated string.
// WriteLine($"You must pay {CalculateTax(amount: 149, twoLetterRegionCode: "FR"):C} in tax.");
