using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoodleJumper : MonoBehaviour
{
    private Rigidbody2D _character;

    public float jumpForce = 12.0f;
    public float speed = 500f;

    void Start()
    {
        _character = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        _character.velocity = new Vector2(Input.GetAxis("Horizontal") * speed * Time.deltaTime, _character.velocity.y);

        if (Mathf.Approximately(_character.velocity.y, 0))
        {
            _character.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }
}
