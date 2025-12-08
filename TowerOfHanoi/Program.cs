class Program{
    static int moves;
    public static void Main(string[] args){
        towers(3,1,2,3);
        Console.WriteLine($"Moves count: {moves}");
    }

    public static void towers(int disk, int start, int mid, int end){
        Console.WriteLine("yip");
        if (disk==0) return;
        towers(disk-1, start, end, mid);
        Console.WriteLine("ee");
        Console.WriteLine($"Move Disk {disk} from Peg {start} to Peg {end}");
        towers(disk-1, mid, start, end);

        moves++;
    }
}