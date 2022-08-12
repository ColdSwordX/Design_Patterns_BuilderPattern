namespace Design_Patterns
{
    // The Director is only responsible for executing the building steps in a
    // particular sequence. It is helpful when producing products according to a
    // specific order or configuration. Strictly speaking, the Director class is
    // optional, since the client can control builders directly.
    public class Director
    {
        private IBuilder _builder;

        public IBuilder Builder
        {
            set { _builder = value; }
        }

        // The Director can construct several product variations using the same
        // building steps.
        public void BuildMinimalViableProduct()
        {
            _builder.BuildFloors();
            _builder.BuildRooms();
            _builder.BuildDoors();
            _builder.BuildRoof();
        }

        public void BuildFullFeaturedProduct()
        {
            _builder.BuildBasement();
            _builder.BuildFloors();
            _builder.BuildRooms();
            _builder.BuildDoors();
            _builder.BuildRoof();
            _builder.BuildOutSide();

        }
    }
}
