using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lompat : MonoBehaviour
{
    Rigidbody2D fp;
    public float jump;
    float score;

    public Text scoretxt;
    void Start()
    {
        fp = GetComponent<Rigidbody2D>();
    }

   
    void Update()
    {
        scoretxt.text = "" + score;

        if (Input.GetMouseButtonUp(0))
        {
            fp.velocity = Vector2.up * jump;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "poin")
        {
            score++;
        }

        if(collision.gameObject.tag == "pipa")
        {
            Destroy(gameObject);
        }

    }
}
