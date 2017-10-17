using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Wand))]
public class WandProjectileLauncher : ProjectileLauncher {
    protected override ProjectileWeapon GetWeapon() {
        return GetComponent<Wand>();
    }
}
