using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent( Wand)]
public class WandProjectileLauncher : MonoBehaviour {

    private void Awake() {
        wand = GetComponent<Wand>();
    }
}
