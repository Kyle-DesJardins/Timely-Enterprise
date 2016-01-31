using UnityEngine;
using System.Collections;

public class LoadJournalData : MonoBehaviour {

    [SerializeField]
    private string path1 = "Text/Journal_1";
    [SerializeField]
    private string path2 = "Text/Journal_2";
    [SerializeField]
    private string path3 = "Text/Journal_3";
    [SerializeField]
    private string path4 = "Text/Journal_4";


    private JournalCollection jc1;
    private JournalCollection jc2;
    private JournalCollection jc3;
    private JournalCollection jc4;

    void Awake()
    {
        jc1 = JournalCollection.Load(path1);
        jc2 = JournalCollection.Load(path2);
        jc3 = JournalCollection.Load(path3);
        jc4 = JournalCollection.Load(path4);
    }

    public string GetDate(int journal, int entry)
    {
        switch(journal)
        {
            case 1:
                return jc1.entries[entry-1].date;
            case 2:
                return jc2.entries[entry-1].date;
            case 3:
                return jc3.entries[entry-1].date;
            case 4:
                return jc4.entries[entry-1].date;
            default:
                Debug.Log("GetDate: Not Valid Journal Number");
                return null;
        }
    }

    public string GetParagraph1(int journal, int entry)
    {
        switch (journal)
        {
            case 1:
                return jc1.entries[entry-1].paragraph1;
            case 2:
                return jc2.entries[entry-1].paragraph1;
            case 3:
                return jc3.entries[entry-1].paragraph1;
            case 4:
                return jc4.entries[entry-1].paragraph1;
            default:
                Debug.Log("GetParagraph1: Not Valid Journal Number");
                return null;
        }
    }

    public string GetParagraph2(int journal, int entry)
    {
        switch (journal)
        {
            case 1:
                return jc1.entries[entry-1].paragraph2;
            case 2:
                return jc2.entries[entry-1].paragraph2;
            case 3:
                return jc3.entries[entry-1].paragraph2;
            case 4:
                return jc4.entries[entry-1].paragraph2;
            default:
                Debug.Log("GetParagraph1: Not Valid Journal Number");
                return null;
        }
    }
}