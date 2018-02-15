using System;
using System.Collections.Generic;

namespace BrightExistence.SimpleTools
{
    public class Variables
    {
        public static string ModGamedataDirectory;
        public static Dictionary<string, ItemTypesServer.ItemTypeRaw> itemsMaster;

        // AUTO-REGISTERED TEXTURES
        public static List<SpecificTexture> SpecificTextures = new List<SpecificTexture>();

        // AUTO-REGISTERED ITEMS
        public static List<SimpleItem> Items = new List<SimpleItem>();

        // AUTO-REGISTERED RECIPES
        public static List<SimpleRecipe> Recipes = new List<SimpleRecipe>();

        // AUTO-REGISTERED RESEARCHABLES
        public static List<SimpleResearchable> Researchables = new List<SimpleResearchable>();
    }
}
