namespace GenericT_JuanHernandez
{
    internal class Program
    {
        // Juan Hernandez
        // Lecture Example - Generic Classes and Methods
        static void Main(string[] args)
        {
            TeamRoster<BaseballPlayer> tr = new TeamRoster<BaseballPlayer>();
            
            //Console.WriteLine("Hello, World!");

            BaseballPlayer player1 = new BaseballPlayer();
            BaseballPlayer player2 = new BaseballPlayer();
            //Swap<BaseballPlayer>(player1, player2);
            Swap<BaseballPlayer>(player1, player2);

            int a  = 0;
            int b = 10;
            Swap<int>(a,b);

        }
        public static void Swap<T>(T p1, T p2)
        {

            // temp = b
            // b = a 
            // a = temp

            T temp = p2;
            p2 = p1;
            p1 = temp;


        }



    }
}
// Done