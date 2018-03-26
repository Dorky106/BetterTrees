using PhentrixGames.BetterTrees;
using PhentrixGames.NewColonyAPI.Helpers;

namespace PhentrixGames.Textures
{
    public class logtaiga : NewColonyAPI.Classes.Texture, NewColonyAPI.Interfaces.IAutoTexture
    {
        public logtaiga() : base("logtaiga", Utilities.MultiCombine(Main.ModMaterialsDirectory, "albedo", "logTaiga.png"))
        { }
    }
    public class logtaigahorizontal : NewColonyAPI.Classes.Texture, NewColonyAPI.Interfaces.IAutoTexture
    {
        public logtaigahorizontal() : base("logtaigahorizontal", Utilities.MultiCombine(Main.ModMaterialsDirectory, "albedo", "loghorizontaltaiga.png"))
        { }
    }
    public class logtaigastump : NewColonyAPI.Classes.Texture, NewColonyAPI.Interfaces.IAutoTexture
    {
        public logtaigastump() : base("logtaigastump", Utilities.MultiCombine(Main.ModMaterialsDirectory, "albedo", "stumptaiga.png"))
        { }
    }

    public class logtemperate : NewColonyAPI.Classes.Texture, NewColonyAPI.Interfaces.IAutoTexture
    {
        public logtemperate() : base("logtemperate", Utilities.MultiCombine(Main.ModMaterialsDirectory, "albedo", "logTemperate.png"))
        { }
    }
    public class logtemperatehorizontal : NewColonyAPI.Classes.Texture, NewColonyAPI.Interfaces.IAutoTexture
    {
        public logtemperatehorizontal() : base("logtemperatehorizontal", Utilities.MultiCombine(Main.ModMaterialsDirectory, "albedo", "loghorizontaltemperate.png"))
        { }
    }
    public class logtemperatstump : NewColonyAPI.Classes.Texture, NewColonyAPI.Interfaces.IAutoTexture
    {
        public logtemperatstump() : base("logtemperatstump", Utilities.MultiCombine(Main.ModMaterialsDirectory, "albedo", "stumptemperate.png"))
        { }
    }


}
