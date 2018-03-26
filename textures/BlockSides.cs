using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PhentrixGames.NewColonyAPI.Helpers;

namespace PhentrixGames.BetterTrees
{
    public class XM : NewColonyAPI.Classes.Texture, NewColonyAPI.Interfaces.IAutoTexture
    {
        public XM() : base("XM", Utilities.MultiCombine(Main.ModMaterialsDirectory, "albedo", "x-.png")) {}
    }
    public class XP : NewColonyAPI.Classes.Texture, NewColonyAPI.Interfaces.IAutoTexture
    {
        public XP() : base("XP", Utilities.MultiCombine(Main.ModMaterialsDirectory, "albedo", "x+.png")) { }
    }
    public class ZM : NewColonyAPI.Classes.Texture, NewColonyAPI.Interfaces.IAutoTexture
    {
        public ZM() : base("ZM", Utilities.MultiCombine(Main.ModMaterialsDirectory, "albedo", "z-.png")) { }
    }
    public class ZP : NewColonyAPI.Classes.Texture, NewColonyAPI.Interfaces.IAutoTexture
    {
        public ZP() : base("ZP", Utilities.MultiCombine(Main.ModMaterialsDirectory, "albedo", "z+.png")) { }
    }
}
