using PhentrixGames.BetterTrees;
using PhentrixGames.NewColonyAPI.Helpers;

namespace PhentrixGames.Textures
{
    public class leavestaiga : NewColonyAPI.Classes.Texture, NewColonyAPI.Interfaces.IAutoTexture
    {
        public leavestaiga() : base("leavestaiga", Utilities.MultiCombine(Main.ModMaterialsDirectory, "albedo", "firTree.png"))
        { }
    }
    
    public class leavestemperate : NewColonyAPI.Classes.Texture, NewColonyAPI.Interfaces.IAutoTexture
    {
        public leavestemperate() : base("leavestemperate", Utilities.MultiCombine(Main.ModMaterialsDirectory, "albedo", "leavestemperate.png"))
        { }
    }
}
