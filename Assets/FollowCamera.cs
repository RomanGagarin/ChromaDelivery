using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    // camera's position should same as the car

    [SerializeField] GameObject followTarget;
    [SerializeField] Vector3 offset = new Vector3(0, 0, -25);

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = followTarget.transform.position + offset;
    }
}
