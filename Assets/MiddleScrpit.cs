using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiddleScrpit : MonoBehaviour
{
    public LogicScrpit logic;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScrpit>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("It Entered");
        logic.addScore();
    }
}
