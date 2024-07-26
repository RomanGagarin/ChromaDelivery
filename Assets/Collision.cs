using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Big hit buddy, eh?");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("BOOOOOOOOOOOOOOOOOOOOSTT!");
    }
}
