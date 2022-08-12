namespace Design_Patterns.Parts
{
    public class Room
    {
        public string RoomName { get; set; } = "";
        public List<Room> DoorsToRooms { get; set; } = new();
        public int Size { get; set; }
        public int WindowCount { get; set; }
        public Room GenerateRoom(int _roomSize, string _name, int _windowCount)
        {
            Room room = new();
            room.SetSize(_roomSize);
            room.SetName(_name);
            room.AddWindow(_windowCount);

            return room;
        }
        public void GenerateDoor(Room _room)
        {
            if (_room.DoorsToRooms.IndexOf(this) == -1)
            {
                _room.DoorsToRooms.Add(this);
            }
            if (DoorsToRooms.IndexOf(_room) == -1)
            {
                DoorsToRooms.Add(_room);
            }
        }
        public void AddWindow(int _windowCount)
        {
            for (int i = 0; i < _windowCount; i++)
            {
                WindowCount++;

            }
        }
        public void SetSize(int _roomSize)
        {
            Size = _roomSize;
        }
        public void SetName(string _roomName)
        {
            RoomName = _roomName;
        }
    }
}
