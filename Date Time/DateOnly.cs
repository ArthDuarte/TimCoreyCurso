


DateOnly birthday = DateOnly.Parse(s:"01/02/2015");

Console.WriteLine(birthday);

//DateOnly vai chamar somente a data, tirando qualquer horário.

TimeOnly opensAt = TimeOnly.Parse(s:"8:00 AM");
TimeOnly rightNow = TimeOnly.FromDateTime(DateTime.Now);

Console.WriteLine(opensAt);
Console.WriteLine(rightNow);    