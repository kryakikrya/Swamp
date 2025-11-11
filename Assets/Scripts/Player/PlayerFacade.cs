using UnityEngine;

[RequireComponent(typeof(PlayerShooting))]
[RequireComponent(typeof(PlayerHealth))]
[RequireComponent(typeof(PlayerAnimation))]
public class PlayerFacade : MonoBehaviour
{
    [SerializeField] private PlayerDestroyer _destoyer;
    private PlayerShooting _shootingComponent;
    private PlayerHealth _healthComponent;
    private PlayerAnimation _animationComponent;

    private void Start()
    {
        _shootingComponent = GetComponent<PlayerShooting>();
        _healthComponent = GetComponent<PlayerHealth>();
        _animationComponent = GetComponent<PlayerAnimation>();
    }

    public void Shoot()
    {
        _shootingComponent.Shoot();
    }

    public void ChangeNextWeapon()
    {
        _shootingComponent.ChangeNextWeapon();
    }

    public void ChangePreviousWeapon()
    {
        _shootingComponent.ChangePreviousWeapon();
    }

    public void GetDamage(int damage)
    {
        _healthComponent.GetDamage(damage);
    }

    public void KillPlayer()
    {
        _destoyer.KillPlayer();
    }
}
