using UnityEngine;
using System.Collections;

public class KickFunctionality : MonoBehaviour {

    [SerializeField]
    private string customKeyCode;

    [HideInInspector]
    public string kickableTag;

    [SerializeField]
    private GameObject kickDetect;

    private Animator animator;
    private BoxCollider2D kickDetectCollider;

    void Awake()
    {
        animator = GetComponent<Animator>();
        kickDetectCollider = kickDetect.GetComponent<BoxCollider2D>();
        kickDetectCollider.enabled = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(customKeyCode))
        {
            animator.SetTrigger("Kick");
			Kick();
        }
    }

    public void Kick()
    {
        kickDetectCollider.enabled = true;
    }

    public void EndKick()
    {
        if (kickDetectCollider.enabled)
        {
            kickDetectCollider.enabled = false;
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (kickDetectCollider.IsTouching(col.collider))
        {
            Destroy(col.gameObject);
        }
    }

}
