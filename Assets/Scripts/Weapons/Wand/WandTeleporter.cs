using System;
using UnityEngine;


[RequireComponent( typeof( Wand ) )]
public class WandTeleporter : MonoBehaviour {

    [SerializeField]
    private LayerMask layerMask;

    private ProjectileWeapon wand;


    private void Awake() {
        wand = GetComponent<Wand>();
        wand.OnFire += Wand_OnFire;
    }

    /// <summary>
    /// Teleport on fire if possible
    /// </summary>
    void Wand_OnFire() {
        RaycastHit hitInfo;
        Ray ray = new Ray( transform.position, transform.forward );
        if ( Physics.Raycast( ray, out hitInfo, Mathf.Infinity, (int) layerMask ) ){
            DoTeleport( hitInfo.point );
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
