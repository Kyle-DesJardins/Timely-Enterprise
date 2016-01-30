using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;
using System.Collections;

public class levelsEditor : Editor {

    #region Menu Scenes

    [MenuItem("Open Scene/Main Menu", false, 2)]
    public static void OpenMainMenu()
    {
        if (EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo())
        {
            EditorSceneManager.OpenScene("Assets/Scenes/UI/startMenuScene.unity");
        }
    }

    [MenuItem("Open Scene/Koala Quest", false, 2)]
    public static void OpenKoalaQuest()
    {
        if (EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo())
        {
            EditorSceneManager.OpenScene("Assets/Scenes/UI/koalaquest.unity");
        }
    }

    #endregion

    #region World 1

    [MenuItem("Open Scene/World 1/Level 1")]
    public static void OpenLevel1()
    {
        OpenScene(1, 1);
    }

    [MenuItem("Open Scene/World 1/Level 2")]
    public static void OpenLevel2()
    {
        OpenScene(1, 2);
    }

    [MenuItem("Open Scene/World 1/Level 3")]
    public static void OpenLevel3()
    {
        OpenScene(1, 3);
    }

    [MenuItem("Open Scene/World 1/Level 4")]
    public static void OpenLevel4()
    {
        OpenScene(1, 4);
    }

    [MenuItem("Open Scene/World 1/Level 5")]
    public static void OpenLevel5()
    {
        OpenScene(1, 5);
    }

    [MenuItem("Open Scene/World 1/Level 6")]
    public static void OpenLevel6()
    {
        OpenScene(1, 6);
    }

    [MenuItem("Open Scene/World 1/Level 7")]
    public static void OpenLevel7()
    {
        OpenScene(1, 7);
    }

    [MenuItem("Open Scene/World 1/Level 8")]
    public static void OpenLevel8()
    {
        OpenScene(1, 8);
    }

    [MenuItem("Open Scene/World 1/Level 9")]
    public static void OpenLevel9()
    {
        OpenScene(1, 9);
    }

    [MenuItem("Open Scene/World 1/Level 10")]
    public static void OpenLevel10()
    {
        OpenScene(1, 10);
    }

    [MenuItem("Open Scene/World 1/Level 11")]
    public static void OpenLevel11()
    {
        OpenScene(1, 11);
    }

    [MenuItem("Open Scene/World 1/Level 12")]
    public static void OpenLevel12()
    {
        OpenScene(1, 12);
    }

    [MenuItem("Open Scene/World 1/Level 13")]
    public static void OpenLevel13()
    {
        OpenScene(1, 13);
    }

    [MenuItem("Open Scene/World 1/Level 14")]
    public static void OpenLevel14()
    {
        OpenScene(1, 14);
    }

    [MenuItem("Open Scene/World 1/Level 15")]
    public static void OpenLevel15()
    {
        OpenScene(1, 15);
    }

    [MenuItem("Open Scene/World 1/World Complete")]
    public static void OpenWorld1Complete()
    {
        OpenWorldCompleteScene(1);
    }

    #endregion

    #region World 2

    [MenuItem("Open Scene/World 2/Level 1")]
    public static void OpenWorld2Level1()
    {
        OpenScene(2, 1);
    }

    [MenuItem("Open Scene/World 2/Level 2")]
    public static void OpenWorld2Level2()
    {
        OpenScene(2, 2);
    }

    [MenuItem("Open Scene/World 2/Level 3")]
    public static void OpenWorld2Level3()
    {
        OpenScene(2, 3);
    }

    [MenuItem("Open Scene/World 2/Level 4")]
    public static void OpenWorld2Level4()
    {
        OpenScene(2, 4);
    }

    [MenuItem("Open Scene/World 2/Level 5")]
    public static void OpenWorld2Level5()
    {
        OpenScene(2, 5);
    }

    [MenuItem("Open Scene/World 2/Level 6")]
    public static void OpenWorld2Level6()
    {
        OpenScene(2, 6);
    }

    [MenuItem("Open Scene/World 2/Level 7")]
    public static void OpenWorld2Level7()
    {
        OpenScene(2, 7);
    }

    [MenuItem("Open Scene/World 2/Level 8")]
    public static void OpenWorld2Level8()
    {
        OpenScene(2, 8);
    }

    [MenuItem("Open Scene/World 2/Level 9")]
    public static void OpenWorld2Level9()
    {
        OpenScene(2, 9);
    }

    [MenuItem("Open Scene/World 2/Level 10")]
    public static void OpenWorld2Level10()
    {
        OpenScene(2, 10);
    }

    [MenuItem("Open Scene/World 2/Level 11")]
    public static void OpenWorld2Level11()
    {
        OpenScene(2, 11);
    }

    [MenuItem("Open Scene/World 2/Level 12")]
    public static void OpenWorld2Level12()
    {
        OpenScene(2, 12);
    }

    [MenuItem("Open Scene/World 2/Level 13")]
    public static void OpenWorld2Level13()
    {
        OpenScene(2, 13);
    }

    [MenuItem("Open Scene/World 2/Level 14")]
    public static void OpenWorld2Level14()
    {
        OpenScene(2, 14);
    }

    [MenuItem("Open Scene/World 2/Level 15")]
    public static void OpenWorld2Level15()
    {
        OpenScene(2, 15);
    }

    [MenuItem("Open Scene/World 2/World Complete")]
    public static void OpenWorld2Complete()
    {
        OpenWorldCompleteScene(2);
    }

    #endregion

    #region World 3
    [MenuItem("Open Scene/World 3/Level 1")]
    public static void OpenWorld3Level1()
    {
        OpenScene(3, 1);
    }

    [MenuItem("Open Scene/World 3/Level 2")]
    public static void OpenWorld3Level2()
    {
        OpenScene(3, 2);
    }

    [MenuItem("Open Scene/World 3/Level 3")]
    public static void OpenWorld3Level3()
    {
        OpenScene(3, 3);
    }

    [MenuItem("Open Scene/World 3/Level 4")]
    public static void OpenWorld3Level4()
    {
        OpenScene(3, 4);
    }

    [MenuItem("Open Scene/World 3/Level 5")]
    public static void OpenWorld3Level5()
    {
        OpenScene(3, 5);
    }

    [MenuItem("Open Scene/World 3/Level 6")]
    public static void OpenWorld3Level6()
    {
        OpenScene(3, 6);
    }

    [MenuItem("Open Scene/World 3/Level 7")]
    public static void OpenWorld3Level7()
    {
        OpenScene(3, 7);
    }

    [MenuItem("Open Scene/World 3/Level 8")]
    public static void OpenWorld3Level8()
    {
        OpenScene(3, 8);
    }

    [MenuItem("Open Scene/World 3/Level 9")]
    public static void OpenWorld3Level9()
    {
        OpenScene(3, 9);
    }

    [MenuItem("Open Scene/World 3/Level 10")]
    public static void OpenWorld3Level10()
    {
        OpenScene(3, 10);
    }

    [MenuItem("Open Scene/World 3/Level 11")]
    public static void OpenWorld3Level11()
    {
        OpenScene(3, 11);
    }

    [MenuItem("Open Scene/World 3/Level 12")]
    public static void OpenWorld3Level12()
    {
        OpenScene(3, 12);
    }

    [MenuItem("Open Scene/World 3/Level 13")]
    public static void OpenWorld3Level13()
    {
        OpenScene(3, 13);
    }

    [MenuItem("Open Scene/World 3/Level 14")]
    public static void OpenWorld3Level14()
    {
        OpenScene(3, 14);
    }

    [MenuItem("Open Scene/World 3/Level 15")]
    public static void OpenWorld3Level15()
    {
        OpenScene(3, 15);
    }

    [MenuItem("Open Scene/World 3/World Complete")]
    public static void OpenWorld3Complete()
    {
        OpenWorldCompleteScene(3);
    }

    #endregion

    #region World 4
    [MenuItem("Open Scene/World 4/Level 1")]
    public static void OpenWorld4Level1()
    {
        OpenScene(4, 1);
    }

    [MenuItem("Open Scene/World 4/Level 2")]
    public static void OpenWorld4Level2()
    {
        OpenScene(4, 2);
    }

    [MenuItem("Open Scene/World 4/Level 3")]
    public static void OpenWorld4Level3()
    {
        OpenScene(4, 3);
    }

    [MenuItem("Open Scene/World 4/Level 4")]
    public static void OpenWorld4Level4()
    {
        OpenScene(4, 4);
    }

    [MenuItem("Open Scene/World 4/Level 5")]
    public static void OpenWorld4Level5()
    {
        OpenScene(4, 5);
    }

    [MenuItem("Open Scene/World 4/Level 6")]
    public static void OpenWorld4Level6()
    {
        OpenScene(4, 6);
    }

    [MenuItem("Open Scene/World 4/Level 7")]
    public static void OpenWorld4Level7()
    {
        OpenScene(4, 7);
    }

    [MenuItem("Open Scene/World 4/Level 8")]
    public static void OpenWorld4Level8()
    {
        OpenScene(4, 8);
    }

    [MenuItem("Open Scene/World 4/Level 9")]
    public static void OpenWorld4Level9()
    {
        OpenScene(4, 9);
    }

    [MenuItem("Open Scene/World 4/Level 10")]
    public static void OpenWorld4Level10()
    {
        OpenScene(4, 10);
    }

    [MenuItem("Open Scene/World 4/Level 11")]
    public static void OpenWorld4Level11()
    {
        OpenScene(4, 11);
    }

    [MenuItem("Open Scene/World 4/Level 12")]
    public static void OpenWorld4Level12()
    {
        OpenScene(4, 12);
    }

    [MenuItem("Open Scene/World 4/Level 13")]
    public static void OpenWorld4Level13()
    {
        OpenScene(4, 13);
    }

    [MenuItem("Open Scene/World 4/Level 14")]
    public static void OpenWorld4Level14()
    {
        OpenScene(4, 14);
    }

    [MenuItem("Open Scene/World 4/Level 15")]
    public static void OpenWorld4Level15()
    {
        OpenScene(4, 15);
    }

    [MenuItem("Open Scene/World 4/World Complete")]
    public static void OpenWorld4Complete()
    {
        OpenWorldCompleteScene(4);
    }

    #endregion

    #region World 5
    [MenuItem("Open Scene/World 5/Level 1")]
    public static void OpenWorld5Level1()
    {
        OpenScene(5, 1);
    }

    [MenuItem("Open Scene/World 5/Level 2")]
    public static void OpenWorld5Level2()
    {
        OpenScene(5, 2);
    }

    [MenuItem("Open Scene/World 5/Level 3")]
    public static void OpenWorld5Level3()
    {
        OpenScene(5, 3);
    }

    [MenuItem("Open Scene/World 5/Level 4")]
    public static void OpenWorld5Level4()
    {
        OpenScene(5, 4);
    }

    [MenuItem("Open Scene/World 5/Level 5")]
    public static void OpenWorld5Level5()
    {
        OpenScene(5, 5);
    }

    [MenuItem("Open Scene/World 5/Level 6")]
    public static void OpenWorld5Level6()
    {
        OpenScene(5, 6);
    }

    [MenuItem("Open Scene/World 5/Level 7")]
    public static void OpenWorld5Level7()
    {
        OpenScene(5, 7);
    }

    [MenuItem("Open Scene/World 5/Level 8")]
    public static void OpenWorld5Level8()
    {
        OpenScene(5, 8);
    }

    [MenuItem("Open Scene/World 5/Level 9")]
    public static void OpenWorld5Level9()
    {
        OpenScene(5, 9);
    }

    [MenuItem("Open Scene/World 5/Level 10")]
    public static void OpenWorld5Level10()
    {
        OpenScene(5, 10);
    }

    [MenuItem("Open Scene/World 5/Level 11")]
    public static void OpenWorld5Level11()
    {
        OpenScene(5, 11);
    }

    [MenuItem("Open Scene/World 5/Level 12")]
    public static void OpenWorld5Level12()
    {
        OpenScene(5, 12);
    }

    [MenuItem("Open Scene/World 5/Level 13")]
    public static void OpenWorld5Level13()
    {
        OpenScene(5, 13);
    }

    [MenuItem("Open Scene/World 5/Level 14")]
    public static void OpenWorld5Level14()
    {
        OpenScene(5, 14);
    }

    [MenuItem("Open Scene/World 5/Level 15")]
    public static void OpenWorld5Level15()
    {
        OpenScene(5, 15);
    }

    [MenuItem("Open Scene/World 5/World Complete")]
    public static void OpenWorld5Complete()
    {
        OpenWorldCompleteScene(5);
    }

    #endregion

    #region World 6
    [MenuItem("Open Scene/World 6/Level 1")]
    public static void OpenWorld6Level1()
    {
        OpenScene(6, 1);
    }

    [MenuItem("Open Scene/World 6/Level 2")]
    public static void OpenWorld6Level2()
    {
        OpenScene(6, 2);
    }

    [MenuItem("Open Scene/World 6/Level 3")]
    public static void OpenWorld6Level3()
    {
        OpenScene(6, 3);
    }

    [MenuItem("Open Scene/World 6/Level 4")]
    public static void OpenWorld6Level4()
    {
        OpenScene(6, 4);
    }

    [MenuItem("Open Scene/World 6/Level 5")]
    public static void OpenWorld6Level5()
    {
        OpenScene(6, 5);
    }

    [MenuItem("Open Scene/World 6/Level 6")]
    public static void OpenWorld6Level6()
    {
        OpenScene(6, 6);
    }

    [MenuItem("Open Scene/World 6/Level 7")]
    public static void OpenWorld6Level7()
    {
        OpenScene(6, 7);
    }

    [MenuItem("Open Scene/World 6/Level 8")]
    public static void OpenWorld6Level8()
    {
        OpenScene(6, 8);
    }

    [MenuItem("Open Scene/World 6/Level 9")]
    public static void OpenWorld6Level9()
    {
        OpenScene(6, 9);
    }

    [MenuItem("Open Scene/World 6/Level 10")]
    public static void OpenWorld6Level10()
    {
        OpenScene(6, 10);
    }

    [MenuItem("Open Scene/World 6/Level 11")]
    public static void OpenWorld6Level11()
    {
        OpenScene(6, 11);
    }

    [MenuItem("Open Scene/World 6/Level 12")]
    public static void OpenWorld6Level12()
    {
        OpenScene(6, 12);
    }

    [MenuItem("Open Scene/World 6/Level 13")]
    public static void OpenWorld6Level13()
    {
        OpenScene(6, 13);
    }

    [MenuItem("Open Scene/World 6/Level 14")]
    public static void OpenWorld6Level14()
    {
        OpenScene(6, 14);
    }

    [MenuItem("Open Scene/World 6/Level 15")]
    public static void OpenWorld6Level15()
    {
        OpenScene(6, 15);
    }

    [MenuItem("Open Scene/World 6/World Complete")]
    public static void OpenWorld6Complete()
    {
        OpenWorldCompleteScene(6);
    }

    #endregion

    #region World 7
    [MenuItem("Open Scene/World 7/Level 1")]
    public static void OpenWorld7Level1()
    {
        OpenScene(7, 1);
    }

    [MenuItem("Open Scene/World 7/Level 2")]
    public static void OpenWorld7Level2()
    {
        OpenScene(7, 2);
    }

    [MenuItem("Open Scene/World 7/Level 3")]
    public static void OpenWorld7Level3()
    {
        OpenScene(7, 3);
    }

    [MenuItem("Open Scene/World 7/Level 4")]
    public static void OpenWorld7Level4()
    {
        OpenScene(7, 4);
    }

    [MenuItem("Open Scene/World 7/Level 5")]
    public static void OpenWorld7Level5()
    {
        OpenScene(7, 5);
    }

    [MenuItem("Open Scene/World 7/Level 6")]
    public static void OpenWorld7Level6()
    {
        OpenScene(7, 6);
    }

    [MenuItem("Open Scene/World 7/Level 7")]
    public static void OpenWorld7Level7()
    {
        OpenScene(7, 7);
    }

    [MenuItem("Open Scene/World 7/Level 8")]
    public static void OpenWorld7Level8()
    {
        OpenScene(7, 8);
    }

    [MenuItem("Open Scene/World 7/Level 9")]
    public static void OpenWorld7Level9()
    {
        OpenScene(7, 9);
    }

    [MenuItem("Open Scene/World 7/Level 10")]
    public static void OpenWorld7Level10()
    {
        OpenScene(7, 10);
    }

    [MenuItem("Open Scene/World 7/Level 11")]
    public static void OpenWorld7Level11()
    {
        OpenScene(7, 11);
    }

    [MenuItem("Open Scene/World 7/Level 12")]
    public static void OpenWorld7Level12()
    {
        OpenScene(7, 12);
    }

    [MenuItem("Open Scene/World 7/Level 13")]
    public static void OpenWorld7Level13()
    {
        OpenScene(7, 13);
    }

    [MenuItem("Open Scene/World 7/Level 14")]
    public static void OpenWorld7Level14()
    {
        OpenScene(7, 14);
    }

    [MenuItem("Open Scene/World 7/Level 15")]
    public static void OpenWorld7Level15()
    {
        OpenScene(7, 15);
    }

    [MenuItem("Open Scene/World 7/World Complete")]
    public static void OpenWorld7Complete()
    {
        OpenWorldCompleteScene(7);
    }

    #endregion

    private static void OpenScene(int world, int level)
    {
        if (EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo())
        {
            EditorSceneManager.OpenScene("Assets/Scenes/Levels/World " + world + "/level " + world + "-" + level + ".unity");
        }
    }

    private static void OpenWorldCompleteScene(int world)
    {
        if(EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo())
        {
            EditorSceneManager.OpenScene("Assets/Scenes/Levels/World " + world + "/world " + world + " complete.unity");
        }
    }

}
