using UnityEngine;

[RequireComponent(typeof(PlayerInput))]
[RequireComponent(typeof(PlayerFacade))]
public class PlayerBehaviour : MonoBehaviour
{
    private PlayerInput _playerInput;
    private PlayerFacade _playerFacade;

    private void Awake()
    {
        _playerInput = GetComponent<PlayerInput>();
        _playerFacade = GetComponent<PlayerFacade>();
    }

    private void OnEnable()
    {
        _playerInput.OnShoot += Shoot;
        _playerInput.OnNextWeapon += ChangeWeaponNext;
        _playerInput.OnPreviousWeapon += ChangeWeaponPrevious;
    }

    private void OnDisable()
    {
        _playerInput.OnShoot -= Shoot;
        _playerInput.OnNextWeapon -= ChangeWeaponNext;
        _playerInput.OnPreviousWeapon -= ChangeWeaponPrevious;
    }

    private void Shoot()
    {
        _playerFacade.Shoot();
    }

    private void ChangeWeaponNext()
    {
        _playerFacade.ChangeNextWeapon();
    }

    private void ChangeWeaponPrevious()
    {
        _playerFacade.ChangePreviousWeapon();
    }
}
