namespace YARG.Core.Game
{
    public partial class ColorProfile
    {

        public static ColorProfile Default = new("Default");

        public string Name;

        public FiveFretGuitarColors FiveFretGuitar;

        public ColorProfile(string name)
        {
            Name = name;

            FiveFretGuitar = new FiveFretGuitarColors();
        }
    }
}