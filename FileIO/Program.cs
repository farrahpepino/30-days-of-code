using System;

class Program{
    static void Main(string[] args){
         string path = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
            "TestFiles"
        );

        Directory.CreateDirectory(path);

        string fileName = "log.txt";
        string filePath = Path.Combine(path, fileName);

        File.WriteAllText(filePath, "Farrah was here.\n");
        File.AppendAllText(filePath,  "No she is not.\n");
        File.AppendAllText(filePath,  "Yes, she is.\n");

        Console.ReadLine();
    }
}

