using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trunkController : MonoBehaviour
{
    public GameObject coin;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Sword"))
        {
            coin.SetActive(true);
        }
    }
}
