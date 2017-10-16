using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Wand))]
public class WandProjectileLauncher : MonoBehaviour {
    // The projectil this thing fires
    [SerializeField]
    private Projectile projectilePrefab;


    private Wand wand;



    private void Awake() {
        wand = GetComponent<Wand>();
        wand.OnFire += Wand_OnFire;
    }

    /// <summary>
    /// Spawn a new projectile from the pool on fire.
    /// </summary>
    void Wand_OnFire() {
        projectilePrefab.Get<Projectile>( null, transform.position, transform.rotation );
    }
}
