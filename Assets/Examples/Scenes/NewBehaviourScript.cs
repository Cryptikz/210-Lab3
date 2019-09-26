using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    //creating rigibody
    public Rigidbody2D RigidBody;
    public float MoveSpeed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        //physics based player movement
        if (Input.GetKey(KeyCode.A))
        {
            RigidBody.MovePosition(transform.position - new Vector3(MoveSpeed, 0f, 0f));

        }
        if (Input.GetKey(KeyCode.D))
        {
            RigidBody.MovePosition(transform.position + new Vector3(MoveSpeed, 0f, 0f));
        }

        if (Input.GetKey(KeyCode.W))
        {
            RigidBody.MovePosition(transform.position + new Vector3(0f, MoveSpeed, 0f));

        }
        if (Input.GetKey(KeyCode.S))
        {
            RigidBody.MovePosition(transform.position - new Vector3(0f, MoveSpeed, 0f));
        }
    }
}
