using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    // Start is called before the first frame update

    private float speed = -12;
    private float deadline = -10;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(this.speed * Time.deltaTime, 0, 0);

        if (transform.position.x < this.deadline)
        {
            Destroy(gameObject);
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if(collision.gameObject.tag=="box"||collision.gameObject.tag=="ground")
            {
            GetComponent<AudioSource>().Play();
            }
        else
        {

        }
    }
  

}
