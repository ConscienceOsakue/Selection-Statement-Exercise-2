namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What is your favorite school subject?");
            var subject = Console.ReadLine();

            switch (subject)
            {
                case "Math":
                    Console.WriteLine("Math is a tough subject.");
                    break;
                case "English":
                    Console.WriteLine("Englist is a tough subject.");
                    break;
                case "Science":
                    Console.WriteLine("Science is a tough subject.");
                    break;
                case "Physics":
                    Console.WriteLine("Physics is a tough subject.");
                    break;
                case "Biology":
                    Console.WriteLine("Biology is a tough subject.");
                    break;
                default: 
                    Console.WriteLine($"Oh Wow! I haven't taken that subject before, {subject} sounds fun.");
                    break;
            }
        }
    }
}