using UnityEngine;

public abstract class ProjectileLauncher : MonoBehaviour
{
    // The projectil this thing fires
    [SerializeField]
    private Projectile projectilePrefab;


    private ProjectileWeapon weapon;



    private void Awake() {
        weapon = GetWeapon();
        weapon.OnFire += Weapon_OnFire;
    }

    protected abstract ProjectileWeapon GetWeapon();

    /// <summary>
    /// Spawn a new projectile from the pool on fire.
    /// </summary>
    void Weapon_OnFire() {
        projectilePrefab.Get<Projectile>( null, transform.position, transform.rotation );
    }
}
