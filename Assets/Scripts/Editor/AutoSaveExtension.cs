using UnityEditor;
using UnityEditor.SceneManagement;

[InitializeOnLoad]
public class AutoSaveExtension
{
    static AutoSaveExtension()
    {
        EditorApplication.playModeStateChanged += AutoSaveWhenPlaymodeStarts;
    }

    private static void AutoSaveWhenPlaymodeStarts(PlayModeStateChange playModeStateChange)
    {
        if (playModeStateChange == PlayModeStateChange.ExitingEditMode)
        {
            // Save the scene and the assets.
            EditorSceneManager.SaveOpenScenes();
            AssetDatabase.SaveAssets();
        }
    }
}