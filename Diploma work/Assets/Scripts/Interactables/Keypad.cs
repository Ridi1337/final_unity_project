using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keypad : Interactable
{
    [SerializeField] private GameObject door;
    private bool doorOpen = false;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    protected override void Interact()
    {
        if (door.GetComponent<Animator>().GetBool("IsOpen") && doorOpen) return;

        doorOpen = !doorOpen;
        door.GetComponent<Animator>().SetBool("IsOpen", doorOpen);
        Debug.Log($"state: {doorOpen} => {Time.time}");
    }
}   
