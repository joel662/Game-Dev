using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScrpit : MonoBehaviour
{
    public GameObject[] handPrefabs;
    public float spawnRate = 2f;
    private float timer = 0;
    public static int score = -2;
    public float heightOffset = 10;
    // Start is called before the first frame update
    void Start()
    {
        spawnHands();
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
            spawnHands();
            timer = 0;
            score=score+1;
        }
        
    }

    void spawnHands()
    {
        int randomIndex = Random.Range(0, handPrefabs.Length);
        GameObject selectedHand = handPrefabs[randomIndex];

        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        Instantiate(selectedHand, new Vector3(transform.position.x, Random.RandomRange(lowestPoint,highestPoint), 0), transform.rotation);
    
    }
}
