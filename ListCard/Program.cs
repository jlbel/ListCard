namespace ListCard
{
    internal class Program
    {
        private static readonly Random random = new Random();
        static Card RandomCard()
        {
            Card card = new Card((Values)random.Next(1, 14), (Suits)random.Next(4));
            return card;
        }
        static void PrintCards(List<Card> cards)
        {
            foreach (Card card in cards) Console.WriteLine($"{card.Value} of {card.Suit}");
        }
        static void Main(string[] args)
        {
           List<Card> cards= new List<Card>();
            IComparer<Card> comparer = new CardComparerByValue();
            Console.WriteLine("Enter number of cards: ");
            if (int.TryParse(Console.ReadKey().KeyChar.ToString(), out int count))
            {
                for (int i = 0; i <= count; i++)
                {
                    cards.Add(RandomCard());
                }
                PrintCards(cards);
                cards.Sort(comparer);
                Console.WriteLine("........Sorting the card........");
                PrintCards(cards);
            }
        }
    }
}