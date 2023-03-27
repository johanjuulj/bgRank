namespace bgRank.Models
{
    public class Result
    {
        public int Id { get; set; }
        public List<Player> Players { get; set; }

        public int Time { get; set; }

        public BoardGame game { get; set; }

        public Result() { }
    }
}
