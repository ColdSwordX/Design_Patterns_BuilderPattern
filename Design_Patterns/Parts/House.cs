
namespace Design_Patterns.Parts
{
    public class House
    {

        private List<Floor> floorList = new();
        private Basement basement { get; set; } = new Basement();
        private Roof roof { get; set; } = new Roof();
        private OutSide outSide { get; set; } = new OutSide();
        public void AddFloor(Floor _floor)
        {
            floorList.Add(_floor);
        }
        public List<Floor> GetAllFloors()
        {
            return floorList;
        }
        public void AddBasement(Basement _basement)
        {
            basement = _basement;
        }
        public Basement GetBasement()
        {
            return basement;
        }
        public void AddRoof(Roof _roof)
        {
            roof = _roof;
        }
        public Roof GetRoof()
        {
            return roof;
        }
        public void AddOutSide(OutSide _outSide)
        {
            outSide = _outSide;
        }
        public OutSide GetOutSide()
        {
            return outSide;
        }

    }
}
