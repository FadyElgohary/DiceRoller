namespace DiceRoller
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        public MainPage()
        {
            InitializeComponent();
        }


        private void rollDice(object sender, EventArgs e)
        {
            Random rand = new Random();
            int random = rand.Next(1, 7);
            result.Text = random.ToString(); 

        }

        private void rollEmoji(object sender, EventArgs e)
        {
            string[] emojis = new string[] {"💀", "😂", "😭", "👍", "👎", "🦅", "🙏", "🗣️", "🔥"};
            Random rand = new Random();
            int random = rand.Next(0, emojis.Length);
            result.Text = emojis[random];
        }
    }

}
