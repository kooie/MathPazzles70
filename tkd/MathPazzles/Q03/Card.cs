namespace Q03
{
    public class Card
    {
        private readonly int _index;
        public int Index => _index;

        private bool _isFaceUp;
        public bool IsFaceUp => _isFaceUp;
        
        public Card(int index)
        {
            _index = index;
            _isFaceUp = false;
        }

        public void TurnOver()
        {
            _isFaceUp = !IsFaceUp;
        }
    }
}
