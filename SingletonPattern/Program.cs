using SingletonPattern;

var logger1 = Logger.GetInstance("app.log");
var logger2 = Logger.GetInstance("app.log");
var logger3 = Logger.GetInstance("app.log");

Console.WriteLine(
    $"logger1 and logger2 are the same object: {ReferenceEquals(logger1, logger2)}");

Console.WriteLine(
    $"logger2 and logger3 are the same object: {ReferenceEquals(logger2, logger3)}");