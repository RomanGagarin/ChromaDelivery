using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Jobs;

public class Driver : MonoBehaviour
{
    [SerializeField] float moveSpeed = 15f;
    [SerializeField] float steerSpeed = 250f;
    [SerializeField] float slowSpeed = 10f;
    [SerializeField] float boostSpeed = 25f;
    float defaultSpeed = 15f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        moveSpeed = slowSpeed;

    }
    void OnCollisionExit2D(Collision2D collision)
    {
        moveSpeed = defaultSpeed;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Boost")
        {
            StartCoroutine(Boost());
        }
        
    }

    IEnumerator Boost()
    {
        Debug.Log("Boost Start");
        moveSpeed = boostSpeed;
        yield return new WaitForSeconds(3);
        Debug.Log("Boost End");
        moveSpeed = defaultSpeed;

    }
}
