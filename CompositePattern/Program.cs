using CompositePattern;

FileSystemNode file1 = new CompositePattern.File("Photo.jpg", 10);
FileSystemNode file2 = new CompositePattern.File("Resume.pdf", 20);
FileSystemNode file3 = new CompositePattern.File("Notes.txt", 5);

Folder subFolder = new CompositePattern.Folder("Personal");
subFolder.AddChild(file3);

Folder mainFolder = new CompositePattern.Folder("Documents");
mainFolder.AddChild(file1);
mainFolder.AddChild(file2);
mainFolder.AddChild(subFolder);

Console.WriteLine(mainFolder.GetSize());