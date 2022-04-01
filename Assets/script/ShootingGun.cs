using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;
public class ShootingGun : MonoBehaviour
{

    public GameObject MyGun;
    public GameObject Fire;
    public GameObject bullet;
    public Transform point;

    //private XRGrabInteractable grabInteractable;
    private float speed = 80f;

    [Space]
    [SerializeField] public InputActionReference Grab_L;
    [SerializeField] public InputActionReference Grab_R;
    [SerializeField] public InputActionReference Mouse_L;
    [SerializeField] public InputActionReference Mouse_R;
    void Start()
    {
        Grab_L.action.performed += GoToMouseL;
        Grab_R.action.performed += GoToMouseR;
        Debug.Log("isGun" + buttonManager.isGun);
        Debug.Log("isSword" + buttonManager.isSword);

    }

    private void GoToMouseL(InputAction.CallbackContext obj)
    {
        Mouse_L.action.performed += Doingsth;
    }
    private void GoToMouseR(InputAction.CallbackContext obj)
    {
        Mouse_R.action.performed += Doingsth;
    }

    private void Doingsth(InputAction.CallbackContext obj)
    {
        Debug.Log("Success");
        GameObject fiya = Instantiate(Fire, point.position, point.rotation);
        GameObject bullets = Instantiate(bullet, point.position, point.rotation);
        bullets.GetComponent<Rigidbody>().velocity = speed * point.forward;
        Destroy(fiya, 1);
    }

    private void theEnd(InputAction.CallbackContext obj)
    {
        Debug.Log("Not now");
    }
}

