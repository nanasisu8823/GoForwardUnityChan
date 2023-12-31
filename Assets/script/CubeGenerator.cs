using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeGenerator : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject cubePrefab;

    private float delta = 0;

    private float span = 1.0f;

    private float genPosx = 12;

    private float spaceY = 6.9f;

    private float offsetX = 0.5f;

    private float spaceX = 0.4f;

    private int maxBlockNum = 4;

    private float offsetY = 0.3f;




    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;

        if(this.delta>this.span)
        {
            this.delta = 0;
            int n =Random.Range(1,maxBlockNum+1);

            for (int i = 0; i < n; i++)
            {
                GameObject go =Instantiate (cubePrefab);
                go.transform.position = new Vector2(this.genPosx, this.offsetY + i * this.spaceY);

            }

            this.span = this.offsetX + this.spaceX * n;
        }



    }
}
