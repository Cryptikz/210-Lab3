using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform Player; //The transform component of the player
    public float LerpSpeed; //How quickly to interpolate the camera's position

    private void LateUpdate()
    {
        //following the object
        Vector3 targetPosition = new Vector3(Player.position.x, Player.position.y, transform.position.z);

        //interpolation
        transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * LerpSpeed);
    }
}
