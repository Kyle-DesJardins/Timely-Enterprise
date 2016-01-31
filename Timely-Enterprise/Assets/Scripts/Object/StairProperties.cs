using UnityEngine;
using System.Collections;

public class StairProperties : MonoBehaviour {

    [SerializeField]
    private GameObject partner;
    [SerializeField]
    private bool bottom;

    public bool getBottom()
    {
        return bottom;
    }
}
