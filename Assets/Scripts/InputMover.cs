using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputMover : MonoBehaviour
{
    [SerializeField] KeyCode left;
    [SerializeField] KeyCode right;
    [SerializeField] KeyCode up;
    [SerializeField] KeyCode down;
    [SerializeField] float speed = 1f;
    void Update()
    {
        Vector3 position = this.transform.position;
        if (Input.GetKey(left) && position.x >= -4.5)
        {
            position.x -= speed * Time.deltaTime;
            this.transform.position = position;
        }
        if (Input.GetKey(right) && position.x <= 4.5)
        {
            position.x += speed * Time.deltaTime;
            this.transform.position = position;
        }
        if (Input.GetKey(up) && position.y <= 4.5)
        {
            position.y += speed * Time.deltaTime;
            this.transform.position = position;
        }
        if (Input.GetKey(down) && position.y >= -4.5)
        {
            position.y -= speed * Time.deltaTime;
            this.transform.position = position;
        }
    }
}

