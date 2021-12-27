using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    private float _startPositionX = 0.0f;
    private float _startPositionY = -2.5f;

    private float _speed = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(_startPositionX, _startPositionY, 0);
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        PlayerBoundary();

    }

    private void Movement()
    {
        float horizontalMovement = Input.GetAxis("Horizontal");
        float verticalMovement = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * horizontalMovement * _speed * Time.deltaTime);
        transform.Translate(Vector3.up * verticalMovement * _speed * Time.deltaTime);
    }

    private void PlayerBoundary()
    {
        if (transform.position.y > 2.5f)
        {
            transform.position = new Vector3(transform.position.x, 2.5f, 0);
        }
        else if (transform.position.y < -3.5f)
        {
            transform.position = new Vector3(transform.position.x, -3.5f, 0);
        }

        if (transform.position.x > 8.5f)
        {
            transform.position = new Vector3(8.5f, transform.position.y, 0);
        }
        else if (transform.position.x < -8.5f)
        {
            transform.position = new Vector3(-8.5f, transform.position.y, 0);
        }
    }
}
