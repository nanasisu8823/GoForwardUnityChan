using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityChanController : MonoBehaviour
{

    Animator animator;

    Rigidbody2D rigid2D;

    private float groundLevel = -3.0f;

    float jumpVelocity = 20;
    private float dump = 0.8f;

    private float deadline = -9;

    void Start()
    {
        this.rigid2D=GetComponent<Rigidbody2D>();
        this.animator = GetComponent<Animator>();
    }


    void Update()
    {

        this.animator.SetFloat("Horizontal", 1);
        bool isGround = (transform.position.y > this.groundLevel) ? false : true;
        this.animator.SetBool("isGround", isGround);

        GetComponent<AudioSource>().volume = (isGround) ? 1:0;

        if (Input.GetMouseButtonDown(0) && isGround)
        {
            this.rigid2D.velocity = new Vector2(0, this.jumpVelocity);
        }

        if (Input.GetMouseButton(0) == false)
        {
            if (this.rigid2D.velocity.y > 0)
            {
                this.rigid2D.velocity*=this.dump;

            }
        }

        if(transform.position.x<this.deadline)
        {
            GameObject.Find("Canvas").GetComponent<UIController>().GameOver();
            Destroy(gameObject);

        }

    }
}



