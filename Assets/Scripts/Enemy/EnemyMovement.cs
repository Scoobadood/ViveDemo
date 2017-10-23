using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

    private Animator animator;


    private void Awake( ) {
        animator = GetComponent<Animator>();
    }



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	private void Update () {
        Vector3 targetPosition = Player.Instance
		
	}
}
