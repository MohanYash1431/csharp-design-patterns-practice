using ProxyPattern;

IDocument document = new CacheProxy(new RealDocument());


Console.WriteLine("First request:");
Console.WriteLine(document.ReadDocument("DOC-101"));

Console.WriteLine("\nSame document again:");
Console.WriteLine(document.ReadDocument("DOC-101"));

Console.WriteLine("\nDifferent document:");
Console.WriteLine(document.ReadDocument("DOC-102"));