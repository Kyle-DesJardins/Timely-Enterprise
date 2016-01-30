using UnityEngine;
using System.Collections;

public class KickFunctionality : MonoBehaviour {

    [SerializeField]
    private string customKeyCode;

    [HideInInspector]
    public string kickableTag;

    void Update()
    {
        if (Input.GetKeyDown(customKeyCode))
        {
            Debug.Log(transform.name + " Kick");
        }
    }

}
