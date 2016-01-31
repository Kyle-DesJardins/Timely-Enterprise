using UnityEngine;
using System.Collections;

public class HitFunctionality : MonoBehaviour {

    [SerializeField]
    private string customKeyCode;

    [HideInInspector]
    public string hittableTag;

    private Animator animator;

    void Awake()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(customKeyCode))
        {
            animator.SetTrigger("Punch");
        }
    }

    public void punch()
    {
        Debug.Log("Hit Test");
    }

}
