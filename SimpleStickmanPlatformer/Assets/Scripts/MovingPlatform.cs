using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public float platformSpeed = 0.5f;
    public Vector3 finishPosition = Vector3.zero;

    private Vector3 _startPosition;
    private float _trackPercent = 0;
    private int _direction = 1;

    void Start()
    {
        _startPosition = transform.position; //положение в сцене - это точка, с которой начинается движение
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, finishPosition);
    }

    void Update()
    {
        _trackPercent += _direction * platformSpeed * Time.deltaTime;
        float deltaX = (finishPosition.x - _startPosition.x) * _trackPercent + _startPosition.x;
        float deltaY = (finishPosition.y - _startPosition.y) * _trackPercent + _startPosition.y;
        transform.position = new Vector3(deltaX, deltaY, _startPosition.z);

        if ((_direction == 1 && _trackPercent > .9f) || (_direction == -1 && _trackPercent < .1f))
        {
            _direction *= -1;
        }
    }
}
