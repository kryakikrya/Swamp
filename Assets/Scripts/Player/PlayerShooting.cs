using UnityEngine;
using System.Collections.Generic;

public class PlayerShooting : MonoBehaviour
{
    [SerializeField] private List<Weapon> _weaponList;

    private int _currentWeaponID = 0;

    public void Shoot()
    {
        _weaponList[_currentWeaponID].Shoot();
    }

    public void ChangeNextWeapon()
    {
        if (_currentWeaponID + 1 >= _weaponList.Count)
        {
            _currentWeaponID = 0;
        }
        else
        {
            _currentWeaponID++;
        }
    }

    public void ChangePreviousWeapon()
    {
        if (_currentWeaponID - 1 <= 0)
        {
            _currentWeaponID = _weaponList.Count - 1;
        }
        else
        {
            _currentWeaponID--;
        }
    }
}
