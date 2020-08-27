namespace Individual.Exercises.Classes
{
    public class Television
    {
       
        public Television()
        {
            IsOn = false;
            CurrentChannel = 3;
            CurrentVolume = 2;
        }

        public bool IsOn { get; private set; }

        public int CurrentChannel { get; private set; }

        public int CurrentVolume { get; private set; }

        public void TurnOff()
        {
            IsOn = false;
        }

        public void TurnOn()
        {
            CurrentChannel = 3;
            CurrentVolume = 2;
            IsOn = true;
        }

        public void ChangeChannel(int newChannel)
        {
            if(IsOn && (newChannel > 2 && newChannel < 19))
            {
                CurrentChannel = newChannel;
            }
        }

        public void ChannelUp()
        {
            if(IsOn)
            {
                CurrentChannel++;

                if (CurrentChannel > 18)
                {
                    CurrentChannel = 3;
                }
            }
        }

        public void ChannelDown()
        {
            if (IsOn)
            {
                CurrentChannel--;

                if (CurrentChannel < 3)
                {
                    CurrentChannel = 18;
                }
            }
        }

        public void RaiseVolume()
        {
            if (IsOn)
            {
                CurrentVolume++;

                if (CurrentVolume > 10)
                {
                    CurrentVolume = 10;
                }
            }
        }

        public void LowerVolume()
        {
            if (IsOn)
            {
                CurrentVolume--;

                if (CurrentVolume < 0)
                {
                    CurrentVolume = 0;
                }
            }
        }
    }
}
