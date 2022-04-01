using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;

public class teleController : MonoBehaviour
{
    public GameObject baseControllerGameObject;
    public GameObject teleportationGameObject;
    public InputActionReference teleportActivaitonReference;

    public UnityEvent onTeleportActivate;
    public UnityEvent onTeleportCancel;

    // Start is called before the first frame update
    void Start()
    {
        teleportActivaitonReference.action.performed += TeleportModeActivate;
        teleportActivaitonReference.action.canceled += TeleportModeCancel;
    }

    private void TeleportModeActivate(InputAction.CallbackContext obj)
    {
        Debug.Log("Press success");
        Invoke("DeactivateTeleporter", .1f);
    }
    void DeactivateTeleporter() => onTeleportCancel.Invoke();
    private void TeleportModeCancel(InputAction.CallbackContext obj) => onTeleportActivate.Invoke();
}
