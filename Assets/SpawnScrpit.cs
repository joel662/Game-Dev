using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScrpit : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2f;
    private float timer = 0;
    public static int score = -3;
    public float heightOffset = 10;
    // Start is called before the first frame update
    void Start()
    {
        
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnPipe();
            timer = 0;
            score=score+1;
        }
        
    }

    void spawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        Instantiate(pipe, new Vector3(transform.position.x, Random.RandomRange(lowestPoint,highestPoint), 0), transform.rotation);
    
    }
}
