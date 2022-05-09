using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable_Interaction : MonoBehaviour
{
    //get collected aka destroyed :D
    //add to counter
    public GameObject ball;
    public UI_Score Ui;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == ball)
        {
            Ui.collected++;
            Destroy(this.gameObject);
        }
    }
}
