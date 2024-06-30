using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BooScript : MonoBehaviour
{

    public Rigidbody2D boo;
    public float flightStrength;

    [SerializeField] private Transform poleCheck;
    [SerializeField] private LayerMask poleLayer;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        killReset();

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)){

            boo.velocity = Vector2.up * flightStrength;
        }
        if (isTouching())
        {
            Debug.Log("YES");
        }
        if (transform.position.y < -20)
        {
            killReset() ;
        }
            
    }
    private bool isTouching()
    {
        return Physics2D.OverlapCircle(poleCheck.position, 0.2f, poleLayer);
    }
    private void killReset()
    {
        Destroy(gameObject);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }
}
