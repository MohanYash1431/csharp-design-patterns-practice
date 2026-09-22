using ChainOfResponsibilityPattern;


var level1 = new Level1Handler();
var level2 = new Level2Handler();
var level3 = new Level3Handler();

//Connect level1 to level2 and level2 to level3
level1.SetNextHandler(level2).SetNextHandler(level3);

//Send every request through the first handler in the chain
int[] priorities = { 5, 10, 15, 20, 25 };

foreach (var priority in priorities)
{
    Console.WriteLine($"\nSending request with priority {priority}");

    var request = new Request { priority = priority };

    level1.processRequest(request);
}