using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipa : MonoBehaviour
{
    float nilai;
    void Start()
    {
        nilai = Random.Range(-0.65f, -5.8f);
        transform.position = new Vector2(transform.position.x, nilai);
    }

  
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, Vector2.left * 100, Time.deltaTime * 6);
    }
}
