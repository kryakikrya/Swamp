using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerShooting))]
[RequireComponent(typeof(PlayerHealth))]
public class PlayerFacade : MonoBehaviour
{
    [SerializeField] private PlayerDestroyer _destoyer;
    private PlayerShooting _shootingComponent;
    private PlayerHealth _healthComponent;

    [SerializeField] private List<Weapon> _addableWeapons;

    public List<Weapon> Weapons => _addableWeapons;

    private void Start()
    {
        _shootingComponent = GetComponent<PlayerShooting>();
        _healthComponent = GetComponent<PlayerHealth>();
    }

    public void Shoot()
    {
        _shootingComponent.Shoot();
    }

    public void AddWeapon(GameObject weaponPrefab)
    {
        _shootingComponent.AddWeapon(weaponPrefab);
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
