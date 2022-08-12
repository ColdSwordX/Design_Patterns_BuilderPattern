namespace Design_Patterns.Builder_Pattern
{
    public class HouseBuilder : IBuilder
    {
        private House _house = new();
        public HouseBuilder()
        {
            Reset();
        }
        public void Reset()
        {
            _house = new();
        }
        // Saves the result and resets the builder to be ready for a new order.
        public House GetHouse()
        {
            House result = _house;

            Reset();

            return result;
        }
        public void BuildBasement()
        {
            Basement basement = new(1000000);
            _house.AddBasement(basement);
        }
        public void BuildFloors()
        {

            Floor floor = new();
            Console.WriteLine("How many floors should be build");
            int floorCount = Convert.ToInt32(Console.ReadLine());
            if (floorCount > 1)
            {
                Console.WriteLine("And how big should the floor's be?");
            }
            else
            {
                Console.WriteLine("And how big should the floor be?");
            }
            int floorSize = Convert.ToInt32(Console.ReadLine());
            List<Floor> floorlist = floor.GenerateFloors(floorCount, floorSize);
            foreach (Floor _floor in floorlist)
            {
                _house.AddFloor(_floor);
            }
        }
        public void BuildRooms()
        {
            foreach (Floor _floor in _house.GetAllFloors())
            {
                int totalRoomSize = 0;
                do
                {
                    int roomSize;
                    Room room = new();
                    if ((_floor.FloorSize - totalRoomSize) <= 15)
                    {
                        roomSize = _floor.FloorSize - totalRoomSize;
                    }
                    else
                    {
                        roomSize = (_floor.FloorSize - totalRoomSize) / 2;
                    }
                    room = room.GenerateRoom(roomSize, $"room-{_floor.RoomList.Count}", (roomSize / 10));
                    _floor.AddRoom(room);
                    totalRoomSize += roomSize;

                 } while (_floor.FloorSize > totalRoomSize);
            }
        }
        public void BuildDoors()
        {
            foreach (Floor floor in _house.GetAllFloors())
            {
                foreach (Room room in floor.RoomList)
                {
                    Random ran = new();
                    
                    if (ran.Next(1) == 0)
                    {
                        int count = floor.RoomList.Count();

                        room.GenerateDoor(floor.RoomList.ElementAt(ran.Next(count)));
                    }
                }
            }
        }
        public void BuildOutSide()
        {
            Random ran = new();
            OutSide outSide = new();
            switch (ran.Next(4))
            {
                case 0:
                    outSide.Garden = "Trees";
                    break;
                case 1:
                    outSide.Garden = "Swimming Pool";
                    break;
                case 2:
                    outSide.Garden = "Garage";
                    break;
                case 3:
                    outSide.Garden = "Fancy Statues";
                    break;
                default:
                    outSide.Garden = "Wild and untamed";
                    break;
            }
            _house.AddOutSide(outSide);
        }
        public void BuildRoof()
        {

            Random ran = new();
            Roof roof = new();
            switch (ran.Next(4))
            {
                case 0:
                    roof.Details = "Flat";
                    break;
                case 1:
                    roof.Details = "Tall with tiles";
                    break;
                case 2:
                    roof.Details = "Another house ontop";
                    break;
                case 3:
                    roof.Details = "Flat with billbord";
                    break;
                default:
                    roof.Details = "Tall with windoes";
                    break;
            }
            _house.AddRoof(roof);
        }
        
    }
}
