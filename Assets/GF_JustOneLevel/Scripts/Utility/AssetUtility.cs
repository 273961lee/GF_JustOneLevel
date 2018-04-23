﻿public static class AssetUtility {
    public static string GetDataTableAsset (string assetName) {
        return string.Format ("Assets/GF_JustOneLevel/DataTables/{0}.csv", assetName);
    }

    public static string GetDictionaryAsset (string assetName) {
        return string.Format ("Assets/GF_JustOneLevel/Localization/{0}/Dictionaries/{1}.xml", GameEntry.Localization.Language.ToString (), assetName);
    }

    public static string GetFontAsset (string assetName) {
        return string.Format ("Assets/GF_JustOneLevel/Localization/{0}/Fonts/{1}.ttf", GameEntry.Localization.Language.ToString (), assetName);
    }

    public static string GetSceneAsset (string assetName) {
        return string.Format ("Assets/GF_JustOneLevel/Scenes/{0}.unity", assetName);
    }

    public static string GetMusicAsset (string assetName) {
        return string.Format ("Assets/GF_JustOneLevel/Music/{0}.mp3", assetName);
    }

    public static string GetSoundAsset (string assetName) {
        return string.Format ("Assets/GF_JustOneLevel/Sounds/{0}.wav", assetName);
    }

    public static string GetEntityAsset (string assetName) {
        return string.Format ("Assets/GF_JustOneLevel/Entities/{0}.prefab", assetName);
    }

    public static string GetUIFormAsset (string assetName) {
        return string.Format ("Assets/GF_JustOneLevel/UI/UIForms/{0}.prefab", assetName);
    }

    public static string GetUISpriteAsset (string assetName) {
        return string.Format ("Assets/GF_JustOneLevel/UI/UISprites/{0}.png", assetName);
    }

    public static string GetUISoundAsset (string assetName) {
        return string.Format ("Assets/GF_JustOneLevel/UI/UISounds/{0}.wav", assetName);
    }
}