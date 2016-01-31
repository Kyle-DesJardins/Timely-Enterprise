using UnityEngine;
using System.Collections;

public class HitFunctionality : MonoBehaviour {

    [SerializeField]
    private string customKeyCode;

    [HideInInspector]
    public string hittableTag;

    [SerializeField]
    private GameObject punchDetect;

    private Animator animator;
    private BoxCollider2D punchDetectCollider;

    void Awake()
    {
        animator = GetComponent<Animator>();
        punchDetectCollider = punchDetect.GetComponent<BoxCollider2D>();
        punchDetectCollider.enabled = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(customKeyCode))
        {
            animator.SetTrigger("Punch");
        }
    }

    public void Punch()
    {
        punchDetectCollider.enabled = true;
    }

    public void EndPunch()
    {
        if (punchDetectCollider.enabled)
        {
            punchDetectCollider.enabled = false;
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(punchDetectCollider.IsTouching(col.collider))
        {
            Destroy(col.gameObject);
        }
    }

    

}
