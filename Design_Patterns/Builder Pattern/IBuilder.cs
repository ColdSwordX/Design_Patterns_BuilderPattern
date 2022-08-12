namespace Design_Patterns
{
    // The Builder interface specifies methods for creating the different parts
    // of the Product objects.

    public interface IBuilder
    {
        void BuildBasement();
        void BuildRooms();
        void BuildDoors();
        void BuildFloors();
        void BuildRoof();
        void BuildOutSide();

    }
}
