using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D RB_2D;

    public float moveSpeed;

    public Animator MyAnim;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RB_2D.velocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")) * moveSpeed;

        MyAnim.SetFloat("MoveX", RB_2D.velocity.x);
        MyAnim.SetFloat("MoveY", RB_2D.velocity.y);

        if(Input.GetAxisRaw("Horizontal") == 1 || Input.GetAxisRaw("Horizontal") == -1 || Input.GetAxisRaw("Vertical") == 1 || Input.GetAxisRaw("Vertical") == -1)
        {
            MyAnim.SetFloat("Last_MoveX", Input.GetAxisRaw("Horizontal"));
            MyAnim.SetFloat("Last_MoveY", Input.GetAxisRaw("Vertical"));
        }
    }
}
