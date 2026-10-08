using SzallodaApp;

Szoba normal = new Szoba(101, 20000);
Szoba normal2 = new Szoba(200, -5555);
Lakosztaly lakosztaly = new Lakosztaly(501,40000,15000);

Console.WriteLine(normal);
Console.WriteLine(lakosztaly);
Console.WriteLine(normal2);

Console.WriteLine(normal.Arkiszamitas(3));