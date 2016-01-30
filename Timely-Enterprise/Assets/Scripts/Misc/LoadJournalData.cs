using UnityEngine;
using System.Collections;

public class LoadJournalData : MonoBehaviour {

    [SerializeField]
    private string path = "Text/Journal_1";

    private JournalCollection jc;
    

    void Start()
    {
        jc = JournalCollection.Load(path);
    }

    public string GetDate(int entry)
    {
        return jc.entries[entry].date;
    }

    public string GetParagraph1(int entry)
    {
        return jc.entries[entry].paragraph1;
    }

    public string GetParagraph2(int entry)
    {
        return jc.entries[entry].paragraph2;
    }
}