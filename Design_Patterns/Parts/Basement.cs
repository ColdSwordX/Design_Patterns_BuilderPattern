namespace Design_Patterns.Parts
{
    public class Basement
    {
        public int NumberOfItems { get; set; }
        public Basement()
        {
            Random ran = new();

            NumberOfItems = ran.Next();
        }
        public Basement( int _maxItems)
        {
            Random ran = new();

            NumberOfItems = ran.Next(_maxItems);
        }
        public Basement(int _minItems, int _maxItems)
        {
            Random ran = new();

            NumberOfItems = ran.Next(_minItems,_maxItems);
        }
        public int GetItems()
        {
            return NumberOfItems;
        }

    }
}
