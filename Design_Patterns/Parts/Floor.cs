namespace Design_Patterns.Parts
{
    public class Floor
    {
        public int FloorSize { get; set; }
        public List<Room> RoomList { get; set; } = new();

        private Floor GenerateFloor(int _floorSize)
        {
            Floor floor = new();
            floor.FloorSize = _floorSize;


            return floor;
        }
        public void AddRoom(Room _room)
        {
            RoomList.Add(_room);
        }

        public List<Floor> GenerateFloors(int _floorCount, int _floorSize)
        {
            List<Floor> floors = new();
            

            for (int i = 0; i < _floorCount; i++)
            {
                floors.Add(GenerateFloor(_floorSize));
            }

            return floors;
        }
        public List<Room> GetRooms()
        {
            return RoomList;
        }
    }
}
