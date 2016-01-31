using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PopulateJournalData : MonoBehaviour {

    private LoadJournalData loadJournalDataScript;
    private int currentEntry;
    private int currentJournal;
    private bool isOpen = false;


    [SerializeField]
    private int level;
    [SerializeField]
    private GameObject page;
    [SerializeField]
    private Text date;
    [SerializeField]
    private Text paragraph1;
    [SerializeField]
    private Text paragraph2;

    void Awake()
    {
        loadJournalDataScript = GetComponent<LoadJournalData>();
    }

    void Start()
    {
        GenerateBeginningText();
        HideJournal();
    }

    //void OnLevelWasLoaded(int level)
    //{
    //    this.level = level;
    //    OpenJournal();
    //    GenerateBeginningText();
    //    HideJournal();
    //}

    private void GenerateBeginningText()
    {
        if(level == 1)
        {
            return;
        }
        else
        {
            currentJournal = 1;
            currentEntry = 1;
            GenerateText();
        }
    }

    private void GenerateText()
    {
        date.text = loadJournalDataScript.GetDate(currentJournal, currentEntry);
        paragraph1.text = loadJournalDataScript.GetParagraph1(currentJournal, currentEntry);
        paragraph2.text = loadJournalDataScript.GetParagraph2(currentJournal, currentEntry);
    }

    private void HideJournal()
    {
        page.SetActive(false);
    }

    public void ToggleJounal()
    {
        if(isOpen)
        {
            isOpen = false;
            page.SetActive(false);
        }
        else
        {
            isOpen = true;
            page.SetActive(true);
        }

    }

    public void NextJournalPage()
    {
        if(currentJournal + 1 <= level)
        {
            if(currentEntry == 1)
            {
                currentEntry++;
                GenerateText();
            }
            else
            {
                if(currentJournal + 1 < level)
                {
                    currentJournal++;
                    currentEntry = 1;
                    GenerateText();
                }
                else
                {
                    Debug.Log("Trying to access journals that have not been unlocked yet.");
                    return;
                }
            }
        }
        else
        {
            Debug.Log("Trying to access journals that have not been unlocked yet.");
            return;
        }
    }

    public void PreviousJournalPage()
    {
        if(currentJournal >= 1)
        {
            if(currentEntry == 1)
            {
                if(currentJournal > 1)
                {
                    currentJournal--;
                    currentEntry = 2;
                    GenerateText();
                }
                else
                {
                    Debug.Log("Already at first journal");
                }
            }
            else
            {
                currentEntry--;
                GenerateText();
            }
        }
        else
        {
            Debug.Log("Already at first journal");
        }
    }
}
