using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PopulateLevelData : MonoBehaviour {

    private LoadLevelData loadLevelDataScript;
    [SerializeField]
    private int level;
    [SerializeField]
    private Text beginningText;
    [SerializeField]
    private Text endingText;

    void Awake()
    {
        loadLevelDataScript = GetComponent<LoadLevelData>();
        //beginningText.text = loadLevelDataScript.GetBeginningText(level);
        //endingText.text = loadLevelDataScript.GetEndingText(level);
    }
    
    void Start()
    {
        beginningText.text = loadLevelDataScript.GetBeginningText(level);
        endingText.text = loadLevelDataScript.GetEndingText(level);
    }
}
