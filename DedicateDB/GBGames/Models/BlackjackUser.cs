﻿namespace Demo.Models
{
    public class BlackjackUser
    {
        public int Id { get; set; }
        public string GameResult { get; set; }
        public int PlayerValue { get; set; }
        public int DealerValue { get; set; }

        public BlackjackUser(string gameResult, int playerValue, int dealerValue)
        {
            GameResult = gameResult;
            PlayerValue = playerValue;
            DealerValue = dealerValue;
        }
    }
}