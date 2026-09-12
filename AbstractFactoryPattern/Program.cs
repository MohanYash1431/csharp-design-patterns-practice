using AbstractFactoryPattern.UiExample;

Console.WriteLine("Linux UI");

var myView = new UiRenderer(new LinuxUiFactory());

Console.WriteLine();
Console.WriteLine("Windows UI");

myView.Toggle(new WindowsUiFactory());

Console.WriteLine();
Console.WriteLine("Mac UI"); 

myView.Toggle(new WindowsUiFactory());