
using System.Net.Http.Headers;
using System.Reflection;

public class card
{
    public Dictionary<int, string> cards;
    public int rand;

    public card(){
        cards = new();
    }

    public virtual void PrintCards(){}
}


public class hearts : card
{
    card card = new();


    public hearts()
    {
        card.cards = new();
        cards.Add(1, "heartsOne");
        cards.Add(2, "heartsTwo");
        cards.Add(3, "heartsThree");
        cards.Add(4, "heartsFour");
        cards.Add(5, "heartsFive");
        cards.Add(6, "heartsSiv");
        cards.Add(7, "heartsSeven");
        cards.Add(8, "heartsEight");
        cards.Add(9, "heartsNine");
        cards.Add(10, "heartsTen");


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