using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PhentrixGames.NewColonyAPI.Classes;

namespace PhentrixGames.Blocks
{
    public class logtaiga : NewColonyAPI.Classes.Type, NewColonyAPI.Interfaces.IAutoType
    {
        public logtaiga() : base("logtaiga", true)
        {
            this.SideYMinus = "logtaigastump";
            this.SideYPlus = "logtaigastump";

            this.SideXMinus = "logtaiga";
            this.SideXPlus = "logtaiga";
            this.SideZMinus = "logtaiga";
            this.SideZPlus = "logtaiga";

            this.IsPlaceable = true;

            this.Icon = NewColonyAPI.Helpers.Utilities.MultiCombine(BetterTrees.Main.ModIconsDirectory, "logTaiga.png");
        }
        public override List<BaseRecipe> AddRecipes()
        {
            List<BaseRecipe> ret = new List<BaseRecipe>();
            BaseRecipe rec1 = new BaseRecipe("logtaiga", true);
            InventoryItem result = new InventoryItem("logtaiga");
            rec1.Result.Add(result);
            InventoryItem requirements = new InventoryItem("logtaigahorizonal");
            rec1.Requirements.Add(requirements);
            ret.Add(rec1);
            return ret;
        }
    }   
    public class logtaigahorizonal : NewColonyAPI.Classes.Type, NewColonyAPI.Interfaces.IAutoType
    {

        public logtaigahorizonal() : base("logtaigahorizonal", true)
        {
            this.RotatableXMinus = "logtaigahorizontalXM";
            this.RotatableXPlus = "logtaigahorizontalXP";
            this.RotatableZMinus = "logtaigahorizontalZM";
            this.RotatableZPlus = "logtaigahorizontalZP";
            this.SideYMinus = "logtaigahorizontal";
            this.SideYPlus = "logtaigahorizontal";

            this.SideXMinus = "logtaigahorizontal";
            this.SideXPlus = "logtaigahorizontal";
            this.SideZMinus = "logtaigahorizontal";
            this.SideZPlus = "logtaigahorizontal";

            this.IsPlaceable = true;
            this.IsAutoRotatable = true;

            this.Icon = NewColonyAPI.Helpers.Utilities.MultiCombine(BetterTrees.Main.ModIconsDirectory, "loghorizontaltaiga.png");
        }

        public override List<BaseRecipe> AddRecipes()
        {
            List<BaseRecipe> ret = new List<BaseRecipe>();
            BaseRecipe rec1 = new BaseRecipe("logtaigahorizonal", true);
            InventoryItem result = new InventoryItem("logtaigahorizonal");
            rec1.Result.Add(result);
            InventoryItem requirements = new InventoryItem("logtaiga");
            rec1.Requirements.Add(requirements);
            ret.Add(rec1);
            return ret;
        }
    }
    public class logtaigahorizontalXP : NewColonyAPI.Classes.Type, NewColonyAPI.Interfaces.IAutoType
    {
        public logtaigahorizontalXP() : base("logtaigahorizontalXP")
        {
            this.ParentType = "logtaigahorizonal";
            this.IsPlaceable = true;
            this.SideXMinus = "logtaigastump";
            this.SideXPlus = "logtaigastump";
        }
    }
    public class logtaigahorizontalXM : NewColonyAPI.Classes.Type, NewColonyAPI.Interfaces.IAutoType
    {
        public logtaigahorizontalXM() : base("logtaigahorizontalXM")
        {
            this.ParentType = "logtaigahorizonal";
            this.IsPlaceable = true;
            this.SideXMinus = "logtaigastump";
            this.SideXPlus = "logtaigastump";
        }
    }
    public class logtaigahorizontalZP : NewColonyAPI.Classes.Type, NewColonyAPI.Interfaces.IAutoType
    {
        public logtaigahorizontalZP() : base("logtaigahorizontalZP")
        {
            this.ParentType = "logtaigahorizonal";
            this.IsPlaceable = true;
            this.SideZMinus = "logtaigastump";
            this.SideZPlus = "logtaigastump";

            this.SideYMinus = "logtaiga";
            this.SideYPlus = "logtaiga";
        }
    }
    public class logtaigahorizontalZM : NewColonyAPI.Classes.Type, NewColonyAPI.Interfaces.IAutoType
    {
        public logtaigahorizontalZM() : base("logtaigahorizontalZM")
        {
            this.ParentType = "logtaigahorizonal";
            this.IsPlaceable = true;
            this.SideZMinus = "logtaigastump";
            this.SideZPlus = "logtaigastump";

            this.SideYMinus = "logtaiga";
            this.SideYPlus = "logtaiga";
        }
    }
}
