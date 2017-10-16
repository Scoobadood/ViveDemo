using System;
using UnityEngine;


[RequireComponent( typeof( Wand ) )]
public class WandTeleporter : MonoBehaviour {

    // The projectil this thing fires
    [SerializeField]
    private Projectile projectilePrefab;


    private Wand wand;
    private int layerMask;

    private void Awake() {
        wand = GetComponent<Wand>();
        wand.OnFire += Wand_OnFire;
    }

    /// <summary>
    /// Spawn a new projectile from the pool on fire.
    /// </summary>
    void Wand_OnFire() {
        RaycastHit rayInfo;
        Ray ray = new Ray( transform.position, transform.forward );
        if ( Physics.Raycast( ray, out rayInfo, Mathf.Infinity, (int) layerMask ) ){
            DoTeleport( rayInfo.point );
        }
    }

            /// <summary>
            /// Find player and move to location
            /// </summary>
            /// <param name="point">Point.</param>
    private void DoTeleport( Vector3 point ) {
        FindObjectOfType<SteamVR_PlayArea>( ).transform.position = point;
    }
}
