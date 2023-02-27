namespace MauiApp1;

public class Monkey
{
	public string Name { get; set; }
    public string Location { get; set; }
    public string Details { get; set; }
    public string Image { get; set; }
    public int Population { get; set; }

    public Monkey(string name, string location, string details, string image, int population)
    {
        Name = name;
        Location = location;
        Details = details;
        Image = image;
        Population = population;
    }
}
public partial class MainPage : ContentPage
{

    Monkey[] theMonkeys = new Monkey[] {
            new Monkey("Baboon", "Africa And Asia", "Baboons are African and Arabian Old World monkeys belonging to the genus Papio, part of the subfamily Cercopithecinae.", "https://raw.githubusercontent.com/jamesmontemagno/app-monkeys/master/baboon.jpg", 10000),
            new Monkey("Capuchin", "Central and South America", "The capuchin monkeys are New World monkeys of the subfamily Cebinae. Prior to 2011, the subfamily contained only a single genus, Cebus.", "https://raw.githubusercontent.com/jamesmontemagno/app-monkeys/master/capuchin.jpg", 23000),
            new Monkey("Blue Monkey", "Central and East Africa","The blue monkey or diademed monkey is a species of Old World monkey native to Central and East Africa, ranging from the upper Congo River basin east to the East African Rift and south to northern Angola and Zambia", "https://raw.githubusercontent.com/jamesmontemagno/app-monkeys/master/bluemonkey.jpg", 12000)
        };

    int i = 0;



	public MainPage()
    {

        this.BindingContext = theMonkeys[i];


		InitializeComponent();
	}

    private void Right(object sender, EventArgs e)
    {
        if (i < theMonkeys.Length - 1)
        {
            i++;
            this.BindingContext = theMonkeys[i];
        }
    }

    private void Left(object sender, EventArgs e)
    {
        if (i > 0)
        {
            i--;
            this.BindingContext = theMonkeys[i];
        }

    }
}

