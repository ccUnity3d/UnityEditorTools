﻿using UnityEngine;
using System.Collections;
using UnityEditor;
using System.IO;

public class CreateAssetBundle : Editor
{

    [MenuItem("Helper/AB_BuildAll")]
    static void Build()
    {
        string path = EditorHelper.bundlePath;
        if (!Directory.Exists(path)) Directory.CreateDirectory(path);
        BuildPipeline.BuildAssetBundles(path);
        AssetDatabase.Refresh();
    }

}