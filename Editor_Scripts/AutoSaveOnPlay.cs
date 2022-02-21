using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;

[InitializeOnLoad]
public class AutoSaveOnPlay
{
	// Constructor
	static AutoSaveOnPlay()
	{
		EditorApplication.playModeStateChanged += SaveOnPlay;
	}

	// Auto save on play function
	private static void SaveOnPlay(PlayModeStateChange state)
	{
		if (state == PlayModeStateChange.ExitingEditMode)
		{
			Debug.Log("Auto-saving on load...");

			EditorSceneManager.SaveOpenScenes();
			AssetDatabase.SaveAssets();
		}
	}
}
