﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trunkController : MonoBehaviour
{
    public GameObject coin;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Sword"))
        {
            coin.SetActive(true);
        }
    }
}
