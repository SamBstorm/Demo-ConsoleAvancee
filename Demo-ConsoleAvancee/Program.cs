namespace Demo_ConsoleAvancee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            ColorString colorString = new ColorString();

            colorString.text = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Ipsa, labore. Ullam 😉 quam at repellendus magnam. Sunt cum nulla accusamus nostrum. Sequi iure atque modi. Atque voluptas exercitationem impedit error obcaecati. 🔥🍃🚿";
            colorString.colors = new Dictionary<int, ConsoleColor>
            {
                {71, ConsoleColor.Green},
                {76, ConsoleColor.Gray}
            };
            Console.WriteLine(colorString.text);

            colorString.Writeline(Console.WindowWidth/2-20,3,60);
            Thread.Sleep(2000);
            Console.WriteLine("🔻");
            Console.ReadLine();
            colorString.Writeline();

            Console.WriteLine(
@"/-----\
| O O |
\__-__/"
);
            string[] words = colorString.text.Split(new char[] { ' ', '.', ',',';' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
