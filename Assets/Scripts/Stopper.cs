using UnityEngine;
using System.Collections;

public class Stopper : MonoBehaviour
{
    public GameManager gameManager;
    public int stopperIndex;

    void OnCollisionEnter2D(Collision2D other)
    {
        gameManager.mailsToPickup[stopperIndex] = other.gameObject;
    }
}