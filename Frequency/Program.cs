int[] freq = new int[26];
Console.WriteLine(string.Join(", ", freq));

string s = "farrah";
string t = "harraf";


foreach (char c in s){
    Console.WriteLine(c);
    Console.WriteLine(freq[c-'a']++);
}
Console.WriteLine(string.Join(", ", freq));


foreach (char c in t){
    Console.WriteLine(c);
    Console.WriteLine(freq[c-'a']--);
}

Console.WriteLine(string.Join(", ", freq));

foreach (int i in freq){
    Console.WriteLine(i);
}
