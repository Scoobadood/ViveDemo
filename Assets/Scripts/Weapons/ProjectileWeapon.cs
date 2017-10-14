using System;
using UnityEngine;

public class ProjectileWeapon : MonoBehaviour {
	// Time before reshooting
	[SerializeField]
	private float rechargeTime = 1.0f;

	private SteamVR_TrackedController controller;

	private float nextFireTime = 0.0f;

	public event Action OnFire = delegate { };

	protected void Awake() {
		controller = GetComponentInParent<SteamVR_TrackedController>();
	}


	protected void Update() {
		if ( CanFire() && ShouldFire() ) {
			Fire();
		}
	}

	/// <summary>
	/// Should fire if we have trigger pressed
	/// </summary>
	/// <returns><c>true</c>, if fire was shoulded, <c>false</c> otherwise.</returns>
	private bool ShouldFire() {
		return controller.triggerPressed;
	}

	/// <summary>
	/// True if we met our timer requirement
	/// </summary>
	/// <returns><c>true</c>, if fire was caned, <c>false</c> otherwise.</returns>
	private bool CanFire() {
		return Time.time >= nextFireTime;
	}

	private void Fire() {
		OnFire();

		nextFireTime = Time.time + rechargeTime;
	}
}
