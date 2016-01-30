using UnityEngine;
using System.Collections;

public class DuckFunctionality : MonoBehaviour {

    [SerializeField]
    private string customKeyCode;

    void Update()
    {
        if(Input.GetKeyDown(customKeyCode))
        {
            Debug.Log(transform.name + " Duck");
        }
    }

}
