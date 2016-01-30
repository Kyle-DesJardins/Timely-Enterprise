using UnityEngine;
using System.Collections;

public class InteractFunctionality : MonoBehaviour {

    [SerializeField]
    private string customKeyCode;

    [HideInInspector]
    public string interactableTag;

    void Update()
    {
        if (Input.GetKeyDown(customKeyCode))
        {
            Debug.Log(transform.name + " Interact");
        }
    }
}
