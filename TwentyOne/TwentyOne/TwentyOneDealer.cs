﻿namespace TwentyOne
{
    internal class TwentyOneDealer : Dealer
    {
        private List<Card> _hand = new List<Card>();
        public List<Card> Hand
        {
            get { return _hand; }
            set { _hand = value; }
        }
        public bool Stay { get; set; }
        public bool isBusted { get; set; }
    }
}
