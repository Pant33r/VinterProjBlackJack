public class cloves : card{
    card card = new();
    public cloves(){
        card.cards = new();
        cards.Add(1, "ClovesOne");
        cards.Add(2, "ClovesTwo");
        cards.Add(3, "ClovesThree");
        cards.Add(4, "ClovesFour");
        cards.Add(5, "ClovesFive");
        cards.Add(6, "ClovesSix");
        cards.Add(7, "ClovesSeven");
        cards.Add(8, "ClovesEight");
        cards.Add(9, "ClovesNine");
        cards.Add(10, "ClovesTen");
        // cards.Add(10, "ClovesKnight");
        // cards.Add(10, "ClovesQueen");
        // cards.Add(10, "ClovesKing");

        rand = Random.Shared.Next(0, cards.Count);
    }

    public override void PrintCards()
    {
        foreach (var card in cards)
        {
            //System.Console.WriteLine($"{card.Key}, {card.Value}");
        }
        System.Console.WriteLine(cards[rand]);
    }
}