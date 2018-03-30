using Pipliz.JSON;
using System.Collections.Generic;
using System.IO;
using System;
using System.Text;

namespace PhentrixGames.BetterTrees
{
    [ModLoader.ModManager]
    public static class Main
    {
        public static string ModName = "BetterTrees";
        const string ModKey = "phentrixgames.bettertrees.";


        public static string ModGamedataDirectory = @"gamedata/mods/JackPS9/BetterTrees/gamedata";
        public static string ModAudioDirectory = @"gamedata/mods/JackPS9/BetterTrees/gamedata/Audio";
        public static string ModLocalizationDirectory = @"gamedata/mods/JackPS9/BetterTrees/gamedata/Localization";
        public static string ModMeshesDirectory = @"gamedata/mods/JackPS9/BetterTrees/gamedata/Meshes";
        public static string ModSettingsDirectory = @"gamedata/mods/JackPS9/BetterTrees/gamedata/Settings";
        public static string ModTextureDirectory = @"gamedata/mods/JackPS9/BetterTrees/gamedata/Textures";
        public static string ModMaterialsDirectory = @"gamedata/mods/JackPS9/BetterTrees/gamedata/Textures/Materials";
        public static string ModIconsDirectory = @"gamedata/mods/JackPS9/BetterTrees/gamedata/Textures/Icons";
        public static Version ModVersion = new Version(1, 0, 1, 2);
        /// <summary>
        /// OnAssemblyLoaded callback entrypoint. Used for mod configuration / setup.
        /// </summary>
        /// <param name="path">The starting point of mod file structure.</param>
        [ModLoader.ModCallback(ModLoader.EModCallbackType.OnAssemblyLoaded, ModKey + ".OnAssemblyLoaded")]
        public static void OnAssemblyLoaded (string path)
        {
            //Obtaining Mod Folders
            ModGamedataDirectory = Path.Combine(Path.GetDirectoryName(path), "gamedata").Replace("\\", "/");
            ModSettingsDirectory = Path.Combine(ModGamedataDirectory, "Settings").Replace("\\", "/");
            ModTextureDirectory = Path.Combine(ModGamedataDirectory, "Textures").Replace("\\", "/");
            ModMaterialsDirectory = Path.Combine(ModTextureDirectory, "Materials").Replace("\\", "/");
            ModIconsDirectory = Path.Combine(ModTextureDirectory, "Icons").Replace("\\", "/");

        }
        [ModLoader.ModCallback(ModLoader.EModCallbackType.AfterStartup, ModKey + "AfterStartup")]
        [ModLoader.ModCallbackDependsOn("phentrixgames.newcolonyapi.AfterStartup")]
        public static void AfterStartup()
        {
            //Fully Registering Mod with NewColonyAPI
            NewColonyAPI.Helpers.Utilities.CreateLogs(ModName);
            NewColonyAPI.Managers.ModManager.RegisterMod(ModName, ModVersion, null, "http://phentrixgames.com/mods/bettertrees");
        }
        /// <summary>
        /// AfterWorldLoad callback entry point. Used for localization routines.
        /// </summary>
        [ModLoader.ModCallback(ModLoader.EModCallbackType.AfterWorldLoad, ModKey + ".AfterWorldLoad")]
        [ModLoader.ModCallbackDependsOn("pipliz.server.localization.waitforloading")]
        [ModLoader.ModCallbackProvidesFor("pipliz.server.localization.convert")]
        public static void AfterWorldLoad()
        {
            //Localization of BetterTrees
            NewColonyAPI.Managers.LocalizationManager.Localize(ModName, ModLocalizationDirectory);
        }
    }
}
