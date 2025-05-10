using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerDie : MonoBehaviour
{
    public GameObject endPanel;
    private string Enemy = "Death";
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("touched");
        if (collision.gameObject.tag == Enemy)
        {
            Debug.Log("die");
            endPanel.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}


