using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{

    float time = 0;
    float timer = 2;
    public GameObject pipa;

    void Update()
    {
        if (time <=0)
        {
            Instantiate(pipa, transform.position, Quaternion.identity);
            time = timer;
        }
        else
        {
            time -= Time.deltaTime;
        }
    }


}

