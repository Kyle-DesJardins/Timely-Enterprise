using UnityEngine;
using System.Collections;

public class LoadLevelData : MonoBehaviour {

    [SerializeField]
    private string path = "Text/Level_1";

    private LevelCollection lc;


    void Awake()
    {
        lc = LevelCollection.Load(path);
    }

    public string GetBeginningText(int level)
    {
        return lc.entries[level-1].BeginningText;
    }

    public string GetEndingText(int level)
    {
        return lc.entries[level-1].EndText;
    }
}
