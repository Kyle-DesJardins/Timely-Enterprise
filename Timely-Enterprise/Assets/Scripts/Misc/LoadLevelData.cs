using UnityEngine;
using System.Collections;

public class LoadLevelData : MonoBehaviour {

    [SerializeField]
    private string path = "Text/Level_1";

    private LevelCollection lc;


    void Start()
    {
        lc = LevelCollection.Load(path);
    }

    public string GetBeginningText(int level)
    {
        return lc.entries[level].BeginningText;
    }

    public string GetEndingText(int level)
    {
        return lc.entries[level].EndText;
    }
}
