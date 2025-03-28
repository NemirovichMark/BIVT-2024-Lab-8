namespace Lab_8;

class Program
{
    public static void Main(string[] args)
    {
        Purple_1 p1 = new Purple_1("Hello, World!");
        p1.Review();
        Console.WriteLine("Purple_1:");
        Console.WriteLine(p1);
        
        string text2 = "Разделить заданный текст (не более 1000 символов) на строки, содержащие не более 50 символов. Перенос осуществлять вместо пробела, слова не переносить. Добавить равномерно пробелы между словами (начиная с левого пробела), чтобы каждая строка содержала ровно 50 символов. Свойство Output должно возвращать массив строк, отформатированных по ширине. Метод ToString() должен возвращать массив отформатированных строк построчно.";
        Purple_2 p2 = new Purple_2(text2);
        p2.Review();
        Console.WriteLine("\nPurple_2:");
        Console.WriteLine(p2);
        
        string text3 = "Да, я люблю шаурму, она самая вкусная, самая вкусная, классная вкусная классная вкусная, шаурма, шаурма, шаурму я люблю, шаурму я люблю. Бывает я покупаю, бывает я покупаю.";
        Purple_3 p3 = new Purple_3(text3);
        p3.Review();
        Console.WriteLine("\nPurple_3:");
        Console.WriteLine($"Output text: {p3}");
        Console.WriteLine("Codes:");
        foreach ((string, char) code in p3.Codes) Console.WriteLine($"Pair, code: '{code.Item1}' = '{code.Item2}'");
        
        string text4 = p3.Output;
        Purple_4 p4 = new Purple_4(text4, p3.Codes);
        p4.Review();
        Console.WriteLine("\nPurple_4:");
        Console.WriteLine($"Output: {p4}");
    }
}