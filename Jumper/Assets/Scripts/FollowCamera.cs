using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    private Vector3 offset;

    public Transform target;
    public float smoothTime = 0.2f;

    private Vector3 _velocity = Vector3.zero;
    
    void Start()
    {
        offset = transform.position - target.transform.position;
    }

    private void LateUpdate()
    {
        transform.position = target.position + offset;
    }
}
