using UnityEngine;
using System.Collections;

public class DeathZone : MonoBehaviour
{
    public GameObject ball;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == ball)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
