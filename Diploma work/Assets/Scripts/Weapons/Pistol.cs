using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : Weapon, IPickable
{
    public Weapon OnPicked()
    {
        return this;
    }

    public override void UseWeapon()
    {
        Debug.Log("Boom");
    }

    public override void InitWeapon(Transform parentTr, Transform playerTr)
    {
        base.InitWeapon(parentTr, playerTr);

        transform.rotation = playerTr.rotation;
    }
}
