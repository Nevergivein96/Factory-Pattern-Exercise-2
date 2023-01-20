namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            bool correctInput;
            do
            {
                Console.Clear();
                correctInput = true;

                Console.WriteLine("What Database would you like to work with?");
                Console.WriteLine("Type: SQL, Mongo, List");

                userInput = Console.ReadLine().ToLower();

                if (userInput != "sql" && userInput != "mongo" && userInput != "list")
                {
                    correctInput = false;
                    Console.WriteLine("invalid entry");
                    Thread.Sleep(1000);
                }
            } while (!correctInput);


            var db = DataAccessFactory.GetDataAccessType(userInput);

            db.SaveData();
            var products = db.LoadData(); 
            foreach( var product in products )
            {
                Console.WriteLine($"Product - {product.name} : Price - {product.price}");
            }
        }
    }
}
