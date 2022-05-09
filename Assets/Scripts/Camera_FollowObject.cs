using UnityEngine;

public class Camera_FollowObject : MonoBehaviour
{
    //TO DO:
    //camera follow object  (DONE)
    //smooth camera follow doesnt fit perfectly so standard following player is used


    //object that camera follows
    public Transform target;
    public Vector3 cameraPosition;

    //smooth movement
    //public float smoothSpeed = 0.125f;

    //offset to object
    //public Vector3 offset;

    void FixedUpdate ()
    {
         transform.position = target.transform.position + cameraPosition;

        //camera rotation?
        //if player moves in 

        //smoothing
        //Vector3 desiredPosition = target.position + offset; //position to snap too
        //Vector3 smoothPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed); //current position, endpoint, float

        //transform.position = smoothPosition;

        //camera always look at player = rotational calculation become automated
        //transform.LookAt(target);
    }
}
