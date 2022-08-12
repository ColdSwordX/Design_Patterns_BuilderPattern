
// The client code creates a builder object, passes it to the
// director and then initiates the construction process. The end
// result is retrieved from the builder object.


var director = new Director();
var builder = new HouseBuilder();
director.Builder = builder;
do
{
    Console.WriteLine("Full house");
    director.BuildFullFeaturedProduct();
    var house = builder.GetHouse();
    List<Floor> _floors = house.GetAllFloors();

    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine($"This house have a basement with: {house.GetBasement().GetItems()} things in it");
    Console.WriteLine($"The house have {_floors.Count()}");
    int floorcounter = 0;
    foreach (Floor _floor in _floors)
    {
        List<Room> rooms = _floor.GetRooms();
        Console.WriteLine($"floor-{floorcounter} have: {rooms.Count()} rooms");
        int roomcounter = 0;
        foreach (Room _room in rooms)
        {
            List<Room> _doorsConection = _room.DoorsToRooms;
            Console.WriteLine($"{_room.RoomName} have {_room.WindowCount} and {_doorsConection.Count()}");
            int doorcounter = 0;
            foreach (var doorConection in _doorsConection)
            {
                Console.WriteLine($"door-{doorcounter} is connected to {doorConection.RoomName}");
                doorcounter++;
            }
            roomcounter++;
        }
        floorcounter++;
    }
    Console.WriteLine($"Outside there is {house.GetOutSide().Garden}");
    Console.WriteLine($"The roof is {house.GetRoof().Details}");


    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Less house");
    director.BuildMinimalViableProduct(); 
    Console.WriteLine($"This house have a basement with: {house.GetBasement().GetItems()} things in it");
    Console.WriteLine($"The house have {_floors.Count()}");
    floorcounter = 0;
    foreach (Floor _floor in _floors)
    {
        List<Room> rooms = _floor.GetRooms();
        Console.WriteLine($"floor-{floorcounter} have: {rooms.Count()} rooms");
        int roomcounter = 0;
        foreach (Room _room in rooms)
        {
            List<Room> _doorsConection = _room.DoorsToRooms;
            Console.WriteLine($"{_room.RoomName} have {_room.WindowCount} Windows and {_doorsConection.Count()} doors");
            int doorcounter = 0;
            foreach (var doorConection in _doorsConection)
            {
                Console.WriteLine($"door-{doorcounter} is connected to {doorConection.RoomName}");
                doorcounter++;
            }
            roomcounter++;
        }
        floorcounter++;
    }
    Console.WriteLine($"Outside there is {house.GetOutSide().Garden}");
    Console.WriteLine($"The roof is {house.GetRoof().Details}");

} while (Console.ReadLine() != "x");