﻿namespace bgRank.Models
{
    public class BoardGame
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int Complexity { get; set; }

        public BoardGame() { }
        
    }
}
