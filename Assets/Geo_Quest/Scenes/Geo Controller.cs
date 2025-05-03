using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Collections.LowLevel.Unsafe;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GeoController : MonoBehaviour
{

    SpriteRenderer spriteRenderer;

    Rigidbody2D rb;
    int speed = 5;
    public string nextlevel = "level_2";
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        
        
        

        float xinput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(xinput, rb.velocity.y);

        rb.velocity = new Vector2(xinput * speed, rb.velocity.y);


        if (Input.GetKeyDown(KeyCode.Alpha1)) 
        {
            spriteRenderer.color = Color.yellow;

        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            spriteRenderer.color = Color.blue;

        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            spriteRenderer.color = Color.red;

        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    { Debug.Log("Hit");
        switch (collision.tag)

        {
            case "Death":

                {
                    string thislevel = SceneManager.GetActiveScene().name;
                    SceneManager.LoadScene(thislevel);
                    break;
                

                }
            case "Finish":
                { SceneManager.LoadScene(nextlevel);
                    break;
                
                
                }
       
        
        
        
        
        
        }
    }
}