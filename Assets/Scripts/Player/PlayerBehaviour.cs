using UnityEngine;

[RequireComponent(typeof(PlayerFacade))]
public class PlayerBehaviour : MonoBehaviour
{
    private PlayerFacade _playerFacade;
    
    private void Awake()
    {
        _playerFacade = GetComponent<PlayerFacade>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Shoot();
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            ChangeWeaponNext();
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            ChangeWeaponPrevious();
        }
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
