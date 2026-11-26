namespace MultiInterfaceLib
{
    public class SmartPhone : ICamera, IMusicPlayer
    {
        public string PlayMusic()
        {
            return "playing music";
        }

        public string TakePhoto()
        {
            return "taking photo";
        }
    }
}
