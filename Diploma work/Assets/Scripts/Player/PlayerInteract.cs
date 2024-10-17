using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.HID;

public class PlayerInteract : MonoBehaviour
{
    [SerializeField] private Transform SnapPoint;
    private Camera cam;
    [SerializeField]
    private float distance = 3f;
    [SerializeField]
    private LayerMask mask;
    private PlayerUI playerUI;
    private InputManager inputManager;

    private Weapon _currentWeapon;

    void Start()
    {
        cam = GetComponent<PlayerLook>().cam;
        playerUI = GetComponent<PlayerUI>();
        inputManager = GetComponent<InputManager>();
    }

    // Update is called once per frame
    void Update()
    {

        playerUI.UpdateText(string.Empty);
        RaycastHit tempHit;
        Ray tempRay = new Ray(cam.transform.position, cam.transform.forward);
        if (Physics.Raycast(tempRay, out tempHit, distance, mask))
        {
            Interactable interactable = tempHit.collider.GetComponent<Interactable>();
            if (interactable != null)
            {
                if (Input.GetKeyDown(KeyCode.E))
                    interactable.BaseInteract();
                playerUI.UpdateText(interactable.promptMessage);
            }
        }
    }
}
