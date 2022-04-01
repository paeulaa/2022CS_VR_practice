using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    public GameObject coin;
    public GameObject trunk;
    public GameObject sword;
    private Vector3 scaleChange, positionChange;
    private Vector3 temp;
    private Vector3 temp2;

    // Start is called before the first frame update
    void Start()
    {
        coin.transform.position = new Vector3(1.4f, 0.5f, -0.8f);
        coin.SetActive(false);
        //scaleChange = new Vector3(1f, 1f, 1f);
        //positionChange = new Vector3(0f, 0.7f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (coin.transform.position.y < 1.5f || coin.transform.localScale.y < 1f)
        {
            // coin.transform.localScale.x += Time.deltaTime;
            // coin.transform.localScale.y += Time.deltaTime;
            // coin.transform.localScale.z += Time.deltaTime;
            // coin.transform.position.y += Time.deltaTime;
            temp = coin.transform.localScale;

            temp.x += Time.deltaTime;
            temp.y += Time.deltaTime;
            temp.z += Time.deltaTime;

            coin.transform.localScale = temp;


            temp2 = coin.transform.position;

            temp2.y += Time.deltaTime;

            coin.transform.position = temp2;


        }

    }
}
