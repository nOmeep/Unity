using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlappyBird : MonoBehaviour
{
    public float jumpForce = 5;

    private Rigidbody2D flappyBird;
    private float _rotationAngle = 0;

    void Start()
    {
        flappyBird = GetComponent<Rigidbody2D>();
        _rotationAngle = Mathf.Clamp(_rotationAngle, -15, 15);
    }

    
    void Update()
    {
        Quaternion target = Quaternion.Euler(0, 0, Mathf.Clamp(GetComponent<Rigidbody2D>().velocity.y * 20, -90, 90));
        transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * 10);
        if (Input.GetMouseButtonDown(0))
        {
            flappyBird.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "FBPipe" || collision.collider.tag == "DeadZone")
        {
            Destroy(gameObject);
            SceneManager.LoadScene("SampleScene");
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
