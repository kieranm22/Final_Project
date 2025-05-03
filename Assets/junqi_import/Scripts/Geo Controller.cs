using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GeoController : MonoBehaviour
{
    string String = "Hello ";
    int var = 3;
    Rigidbody2D rb;
    public float speed = 5;
    public string nextlevel = "Scene 2*";
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        Debug.Log("Hello World");
        string String2 = "World";
        Debug.Log(String + String2);
    }

    // Update is called once per frame
    void Update()
    {

        float xInput = Input.GetAxis("Horizontal");
        //bug.Log(xInput);
        rb.velocity = new Vector2(xInput * speed, rb .velocity.y);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Run killer");
        switch (collision.tag)
        {
            case "Death":
                {
                    string thislevel = SceneManager.GetActiveScene().name;
                    SceneManager.LoadScene(thislevel);
                    Debug.Log("player has died");
                    break;
                }

            case "Finish":
                {
                    SceneManager.LoadScene(nextlevel);
                    break;
                }

        }
    }
}
 
        /*
        if (Input .GetKeyDown(KeyCode.A)) 
        {
          rb. velocity = new Vector2(-5, rb.velocity.y);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            rb.velocity = new Vector2(rb.velocity.x, 5);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            rb.velocity = new Vector2(rb.velocity.x, -5);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            rb.velocity = new Vector2(5, rb.velocity.y);
        }


        Debug. Log(var);
        var++;
    }
}
        */