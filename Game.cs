namespace lab1
{
    public class Game
    {
        public string Opponetname { get; }
        public int Result { get; }
        public int RatingGame { get; }
        public int ID { get; }
        public Game(string name, int result, int rating, int id)
        {
            RatingGame = rating;
            Opponetname = name;
            Result = result;
            ID = id;

        } 
    }
}
