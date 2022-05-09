using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground_Controlls : MonoBehaviour
{
    //rotating controlls
    //rotation limit

    public GameObject ground;

    public float turningSpeed;
    public Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>(); 
    }

    void FixedUpdate()
    {
        Rotate();
    }

    //funny stuff i found on internet :)
    public static float ClampAngle(float angle, float min, float max)
    {
        float start = (min + max) * 0.5f - 180;
        float floor = Mathf.FloorToInt((angle - start) / 360) * 360;
        min += floor;
        max += floor;
        return Mathf.Clamp(angle, min, max);
    }

    void Rotate()
    {
        float xRotation = ground.transform.eulerAngles.x;
        float zRotation = ground.transform.eulerAngles.z;

        //Debug.Log("aaaaaaaaaaaaaaaaaaaaaa" + xRotation);

        const float Min_Rotation = -45f;
        const float Max_Rotation = 45f;

        //Controlls
        //Z Rotation
        if (Input.GetKey("w"))
        {
            zRotation -= turningSpeed * Time.fixedDeltaTime;
        }

        if (Input.GetKey("s"))
        {
            zRotation += turningSpeed * Time.fixedDeltaTime;
        }
        //Rotation limits (rotation set to max/ min rotation)
        //help
        zRotation = ClampAngle(zRotation, Min_Rotation, Max_Rotation);

        //X Rotation
        if (Input.GetKey("d"))
        {
            xRotation -= turningSpeed * Time.fixedDeltaTime;
        }

        if (Input.GetKey("a"))
        {
            xRotation += turningSpeed * Time.fixedDeltaTime;
        }
        //Rotation limits 
        xRotation = ClampAngle(xRotation, Min_Rotation, Max_Rotation);

        //ground.transform.rotation = Quaternion.Euler(xRotation, 0f, zRotation);

        rb.MoveRotation(Quaternion.Euler(xRotation, 0f, zRotation)); //else ball falls into the abyss
    }

}
