using UnityEditor;
using UnityEditor.SceneManagement;

public class levelsEditor : Editor {

    #region Menu Scenes

    [MenuItem("Open Scene/Title", false, 2)]
    public static void OpenTitle()
    {
        if (EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo())
        {
            EditorSceneManager.OpenScene("Assets/Scenes/Title.unity");
        }
    }

    #endregion

    #region Test Scenes

    [MenuItem("Open Scene/Test Scenes/Alex Test", false)]
    public static void OpenAlexTest()
    {
        if (EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo())
        {
            EditorSceneManager.OpenScene("Assets/Scenes/Alex Test.unity");
        }
    }

    [MenuItem("Open Scene/Test Scenes/Kyle Test", false)]
    public static void OpenKyletest()
    {
        if (EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo())
        {
            EditorSceneManager.OpenScene("Assets/Scenes/Kyle Test.unity");
        }
    }

    #endregion

    #region World Scenes

    [MenuItem("Open Scene/World 1", false)]
    public static void OpenWorld1()
    {
        if(EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo())
        {
            EditorSceneManager.OpenScene("Assets/Scenes/World 1.unity");
        }
    }

    [MenuItem("Open Scene/World 2", false)]
    public static void OpenWorld2()
    {
        if (EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo())
        {
            EditorSceneManager.OpenScene("Assets/Scenes/World 2.unity");
        }
    }

    [MenuItem("Open Scene/World 3", false)]
    public static void OpenWorld3()
    {
        if (EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo())
        {
            EditorSceneManager.OpenScene("Assets/Scenes/World 3.unity");
        }
    }

    [MenuItem("Open Scene/World 4", false)]
    public static void OpenWorld4()
    {
        if (EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo())
        {
            EditorSceneManager.OpenScene("Assets/Scenes/World 4.unity");
        }
    }

    [MenuItem("Open Scene/World 5", false)]
    public static void OpenWorld5()
    {
        if (EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo())
        {
            EditorSceneManager.OpenScene("Assets/Scenes/World 5.unity");
        }
    }

    [MenuItem("Open Scene/World 6", false)]
    public static void OpenWorld6()
    {
        if (EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo())
        {
            EditorSceneManager.OpenScene("Assets/Scenes/World 6.unity");
        }
    }

    #endregion

}
