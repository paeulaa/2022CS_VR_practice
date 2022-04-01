using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonManager : MonoBehaviour
{
    public GameObject gun;
    public GameObject sword;

    public static int isGun;
    public static int isSword;

    // Start is called before the first frame update
    void Start()
    {
        gun.SetActive(true);
        sword.SetActive(false);
        isGun = 1;
        isSword = 0;
    }

    public void ShowGun()
    {
        gun.SetActive(true);
        sword.SetActive(false);
        isGun = 1;
        isSword = 0;
        Debug.Log("showGun/isGun" + isGun);
        Debug.Log("showGun/isSword" + isSword);
    }

    public void ShowSword()
    {
        sword.SetActive(true);
        gun.SetActive(false);
        isGun = 0;
        isSword = 1;
        Debug.Log("showSword/isGun" + isGun);
        Debug.Log("showSword/isSword" + isSword);
    }
}
