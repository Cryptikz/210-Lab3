using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        //speed = 0.1f;
    }

    // Update is called once per frame
    void Update()
    {

        //gives the bullet a spawn/speed
        Vector3 newPosition = new Vector3(transform.position.x + speed, transform.position.y + speed);

        transform.position = newPosition;
    }
}
