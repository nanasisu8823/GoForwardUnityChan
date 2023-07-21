using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    // Start is called before the first frame update
    private float scrollSpeed = -1;

    private float deadline = -16;

    private float startline = 15.8f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(this.scrollSpeed * Time.deltaTime, 0, 0);
        if(transform.position.x<this.deadline)
        {
            transform.position = new Vector2(this.startline, 0);
        }


    }
}
