namespace Food_Shortage
{
    class Citizen : IBuyer
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Food { get; set; }
        public string Birthdate { get; set; }
        public void BuyFood()
        {
            Food += 10;
        }
    }
}