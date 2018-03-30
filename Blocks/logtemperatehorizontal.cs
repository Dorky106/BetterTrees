using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PhentrixGames.NewColonyAPI.Classes;

namespace PhentrixGames.Blocks
{
    public class logtemperate : NewColonyAPI.Classes.Type, NewColonyAPI.Interfaces.IAutoType
    {
        public logtemperate() : base("logtemperate", true)
		{
			this.ParentType = "log";

			this.SideYMinus = "logtemperatstump";
            this.SideYPlus = "logtemperatstump";

            this.SideXMinus = "logtemperate";
            this.SideXPlus = "logtemperate";
            this.SideZMinus = "logtemperate";
            this.SideZPlus = "logtemperate";

            this.IsPlaceable = true;

            this.Icon = NewColonyAPI.Helpers.Utilities.MultiCombine(BetterTrees.Main.ModIconsDirectory, "logtemperate.png");
			this.Categories = new List<string> { "essential", "decorative" };
		}
        public override List<BaseRecipe> AddRecipes()
        {
            List<BaseRecipe> ret = new List<BaseRecipe>();
            BaseRecipe rec1 = new BaseRecipe("logtemperate", true);
            InventoryItem result = new InventoryItem("logtemperate");
            rec1.Result.Add(result);
            InventoryItem requirements = new InventoryItem("logtemperatehorizonal");
            rec1.Requirements.Add(requirements);
            ret.Add(rec1);
            return ret;
        }
    }   
    public class logtemperatehorizonal : NewColonyAPI.Classes.Type, NewColonyAPI.Interfaces.IAutoType
    {

        public logtemperatehorizonal() : base("logtemperatehorizonal", true)
		{

			this.RotatableXMinus = "logtemperatehorizontalXM";
            this.RotatableXPlus = "logtemperatehorizontalXP";
            this.RotatableZMinus = "logtemperatehorizontalZM";
            this.RotatableZPlus = "logtemperatehorizontalZP";
            this.SideYMinus = "logtemperatehorizontal";
            this.SideYPlus = "logtemperatehorizontal";

            this.SideXMinus = "logtemperatehorizontal";
            this.SideXPlus = "logtemperatehorizontal";
            this.SideZMinus = "logtemperatehorizontal";
            this.SideZPlus = "logtemperatehorizontal";

            this.IsPlaceable = true;
            this.IsAutoRotatable = true;

            this.Icon = NewColonyAPI.Helpers.Utilities.MultiCombine(BetterTrees.Main.ModIconsDirectory, "loghorizontaltemperate.png");
        }

        public override List<BaseRecipe> AddRecipes()
        {
            List<BaseRecipe> ret = new List<BaseRecipe>();
            BaseRecipe rec1 = new BaseRecipe("logtemperatehorizonal", true);
            InventoryItem result = new InventoryItem("logtemperatehorizonal");
            rec1.Result.Add(result);
            InventoryItem requirements = new InventoryItem("logtemperate");
            rec1.Requirements.Add(requirements);
            ret.Add(rec1);
            return ret;
        }
    }
    public class logtemperatehorizontalXP : NewColonyAPI.Classes.Type, NewColonyAPI.Interfaces.IAutoType
    {
        public logtemperatehorizontalXP() : base("logtemperatehorizontalXP")
        {
            this.ParentType = "logtemperatehorizonal";
            this.IsPlaceable = true;
            this.SideXMinus = "logtemperatstump";
            this.SideXPlus = "logtemperatstump";
        }
    }
    public class logtemperatehorizontalXM : NewColonyAPI.Classes.Type, NewColonyAPI.Interfaces.IAutoType
    {
        public logtemperatehorizontalXM() : base("logtemperatehorizontalXM")
        {
            this.ParentType = "logtemperatehorizonal";
            this.IsPlaceable = true;
            this.SideXMinus = "logtemperatstump";
            this.SideXPlus = "logtemperatstump";
        }
    }
    public class logtemperatehorizontalZP : NewColonyAPI.Classes.Type, NewColonyAPI.Interfaces.IAutoType
    {
        public logtemperatehorizontalZP() : base("logtemperatehorizontalZP")
        {
            this.ParentType = "logtemperatehorizonal";
            this.IsPlaceable = true;
            this.SideZMinus = "logtemperatstump";
            this.SideZPlus = "logtemperatstump";

            this.SideYMinus = "logtemperate";
            this.SideYPlus = "logtemperate";
        }
    }
    public class logtemperatehorizontalZM : NewColonyAPI.Classes.Type, NewColonyAPI.Interfaces.IAutoType
    {
        public logtemperatehorizontalZM() : base("logtemperatehorizontalZM")
        {
            this.ParentType = "logtemperatehorizonal";
            this.IsPlaceable = true;
            this.SideZMinus = "logtemperatstump";
            this.SideZPlus = "logtemperatstump";

            this.SideYMinus = "logtemperate";
            this.SideYPlus = "logtemperate";
        }
    }
}
