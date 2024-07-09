using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class BooScript : MonoBehaviour
{

    public Rigidbody2D boo;
    public float flightStrength;
    public GameObject spawner;
    public SpawnScrpit sc;

    [SerializeField] private Transform poleCheck;
    [SerializeField] private LayerMask poleLayer;
    public LogicScrpit logic;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        killReset();
        logic.setScoreToZero();

    }
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScrpit>();
        sc = spawner.GetComponent<SpawnScrpit>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began){

            boo.velocity = Vector2.up * flightStrength;
        }
        if (isTouching())
        {
            Debug.Log("YES");
        }
        if (transform.position.y < -20 || transform.position.y > 19)
        {
            killReset() ;
            logic.setScoreToZero();
        }
            
    }
    private bool isTouching()
    {
        return Physics2D.OverlapCircle(poleCheck.position, 0.2f, poleLayer);
    }
    private void killReset()
    {
        Destroy(gameObject);
        SpawnScrpit.score = Mathf.Max(SpawnScrpit.score, 0);
        Debug.Log(SpawnScrpit.score);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        SpawnScrpit.score = 0;
    }
}
