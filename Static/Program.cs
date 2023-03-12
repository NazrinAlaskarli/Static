namespace Static
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            {
                User user = new User("Arzu", "Mehdiyeva", 3);
                User user1 = new User("Aytac", "Huseynova", 2);
                User user2 = new User("Nazrin", "Alaskarli", 5);
                User user3 = new User("Narmin", "Alizade", 8);
                User user4 = new User("Nargiz", "Alaskarova", 11);

                Console.WriteLine(user.GetDetails());

            }
        }

    }
}
