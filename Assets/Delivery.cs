using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] bool hasPackage;
    [SerializeField] float destroyDelay = 0.5f;
    [SerializeField] Color noPackage = Color.white;

    SpriteRenderer spriteRenderer; // better practice probably

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Big hit, eh buddy?");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Package" && !hasPackage)
        {
            Debug.Log("Package Picked Up!");
            GetComponent<SpriteRenderer>().color = collision.GetComponent<SpriteRenderer>().color; 
            hasPackage = true;
            Destroy(collision.gameObject, destroyDelay);
        }
        else if (collision.tag == "Customer" && hasPackage) 
        {
            Debug.Log("Package Delivered!");
            GetComponent<SpriteRenderer>().color = noPackage;
            hasPackage = false;
        }
        
    }
}
