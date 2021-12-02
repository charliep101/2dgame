using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Verticle : MonoBehaviour
{
    [SerializeField] private float movementDistance;
    [SerializeField] private float speed;
    private bool movingUp;
    private float TopEdge;
    private float BottomEdge;

    private void Awake()
    {
        TopEdge = transform.position.y - movementDistance;
        BottomEdge = transform.position.y + movementDistance;
    }



    private void Update()
    {
        if (movingUp)
        {
            if (transform.position.y > TopEdge)
            {
                transform.position = new Vector3(transform.position.y - speed * Time.deltaTime, transform.position.x, transform.position.z);
            }
            else
                movingUp = false;
        }
        else
        {
            if (transform.position.y < BottomEdge)
            {
                transform.position = new Vector3(transform.position.y + speed * Time.deltaTime, transform.position.x, transform.position.z);
            }
            else
                movingUp = true;
        }
    }
}
