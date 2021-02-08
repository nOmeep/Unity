using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMove : MonoBehaviour
{
    public float obstacleSpeed = 3f;
    
    void Start()
    {
        Debug.Log("Это пасхалка?");
    }

    
    void Update()
    {
        transform.Translate(-obstacleSpeed * Time.deltaTime, 0, 0);
    }
}
