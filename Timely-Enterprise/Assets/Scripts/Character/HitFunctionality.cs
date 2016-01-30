using UnityEngine;
using UnityEditor;
using System.Collections;

public class HitFunctionality : MonoBehaviour {

    [SerializeField]
    private string customKeyCode;

    [HideInInspector]
    public string hittableTag;

    void Update()
    {
        if(Input.GetKeyDown(customKeyCode))
        {
            Debug.Log(transform.name + " Hit");
        }
    }

}
