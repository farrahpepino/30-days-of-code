using System;

class Program{
    static void Main(string[] args){
        string path = @"C:\Users\farrahpepino\Documents\TestFiles";

        Directory.CreateDirectory(path);

        string fileName = "log.txt";
        string filePath = Path.Combine(path, fileName);

        File.WriteAllText(filePath, "Farrah was here.\n");
        File.AppendAllText(filePath,  "No she is not.\n");
        File.AppendAllText(filePath,  "Yes, she is.\n");
        
        if (File.Exists(filePath)){
            string content = File.ReadAllText(filePath);
            Console.WriteLine(content);

        }
        Console.ReadLine();
    }
}

