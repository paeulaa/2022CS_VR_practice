using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletController : MonoBehaviour
{
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnTriggerEnter(Collider other)
    {
        switch (other.tag)
        {
            case "50":
                Debug.Log("Got 50 points.");
                rb.isKinematic = true;
                ScoreController.TotalScore += 50;
                break;

            case "25":
                Debug.Log("Got 25 points.");
                rb.isKinematic = true;
                ScoreController.TotalScore += 25;
                break;

            case "20":
                Debug.Log("Got 20 points.");
                rb.isKinematic = true;
                ScoreController.TotalScore += 20;
                break;

            case "15":
                Debug.Log("Got 15 points.");
                rb.isKinematic = true;
                ScoreController.TotalScore += 15;
                break;

            case "10":
                Debug.Log("Got 10 points.");
                rb.isKinematic = true;
                ScoreController.TotalScore += 10;
                break;

            default:
                Debug.Log("Failed.");
                rb.isKinematic = true;
                break;
        }
    }
}
