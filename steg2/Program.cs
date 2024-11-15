string[] listan = ["atombomber", "leksakspistoler", "knivar", "legobitar", "gafflar i eluttag"];
string[] klasskamrater = ["Vincent", "Filip", "Konstantin", "Rasmus", "David"];
int[] nummer = [4, 3, 6, 2, 7];
List<string> cities = new List<string>();  // istället för array så blir det en lista
string stad;

for (int i = 0; i < listan.Length; i++) {
    if (i == listan.Length - 1) {
        Console.WriteLine(klasskamrater[i] + " och " + klasskamrater[0] + " leker tillsammans med " + nummer[i] + " " + listan[i]);
    }
    else {
        Console.WriteLine(klasskamrater[i] + " och " + klasskamrater[i+1] + " leker tillsammans med " + nummer[i] + " " + listan[i]);
    }

    Console.WriteLine("Säg en stad!");
    stad = Console.ReadLine();
    if (stad.ToLower() == "exit") {
        break;
    }
    cities.Add(stad);
    foreach (string c in cities) {
        Console.WriteLine(c);
    }
}
Console.ReadLine();
