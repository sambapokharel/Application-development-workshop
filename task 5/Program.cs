// DateTime variables for birthday
DateTime birthdate = new DateTime(2005, 12, 19);
// DateTime variable for current date and time
DateTime currentDate = DateTime.Now;
//Calculatimg age
TimeSpan ageSpan = currentDate - birthdate;
int ageInYears = (int)(ageSpan.TotalDays / 365.25);
// Prints your birthdate, the current date, and your age in years
Console.WriteLine($"Birthdate: {birthdate}");
Console.WriteLine($"Current Date: {currentDate}");
Console.WriteLine($"Age in Years: {ageInYears}");

// Adds 10 days to your birthdate and prints the resulting date
DateTime futureBirthdate = birthdate.AddDays(10);
Console.WriteLine($"Birthdate + 10 days: {futureBirthdate}");