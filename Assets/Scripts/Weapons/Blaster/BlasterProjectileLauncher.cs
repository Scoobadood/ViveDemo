using UnityEngine;

[RequireComponent( typeof( Blaster ) )]
public class BlasterProjectileLauncher : ProjectileLauncher {
    protected override ProjectileWeapon GetWeapon() {
        return GetComponent<Blaster>();
    }
}
