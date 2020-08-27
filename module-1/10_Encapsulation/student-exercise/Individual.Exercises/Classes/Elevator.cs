namespace Individual.Exercises.Classes
{
    public class Elevator
    {
       public Elevator(int numberOfFloors)
        {
            NumberOfLevels = numberOfFloors;
            CurrentLevel = 1;
        }

        public int CurrentLevel { get; private set; }

        public int NumberOfLevels { get; }

        public bool DoorIsOpen { get; private set; }

        public void OpenDoor()
        {
            DoorIsOpen = true;
        }

        public void CloseDoor()
        {
            DoorIsOpen = false;
        }

        public void GoUp(int desiredFloor)
        {
            if(!DoorIsOpen && (desiredFloor <= NumberOfLevels) && (desiredFloor > CurrentLevel))
            {
                CurrentLevel = desiredFloor;
            }
        }

        public void GoDown(int desiredFloor)
        {
            if ((!DoorIsOpen && (desiredFloor > 0)) && (desiredFloor < CurrentLevel))
            {
                CurrentLevel = desiredFloor;
            }
        }
    }

}
