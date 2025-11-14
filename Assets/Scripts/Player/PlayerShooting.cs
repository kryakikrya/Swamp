using UnityEngine;
using System.Collections.Generic;

public class PlayerShooting : MonoBehaviour
{
    [SerializeField] private List<Weapon> _weaponList;
    [SerializeField] private Transform _hand;
    [SerializeField] private GameObject _grid;

    private int _currentWeaponID = 0;

    public List<Weapon> Weapons => _weaponList;

    public void Shoot()
    {
        if (_weaponList.Count > 0)
        {
            _weaponList[_currentWeaponID].Shoot();
        }
    }

    public void ChangeNextWeapon()
    {
        if (_weaponList.Count > 0)
        {
            _weaponList[_currentWeaponID].gameObject.SetActive(false);

            if (_currentWeaponID + 1 >= _weaponList.Count)
            {
                _currentWeaponID = 0;
            }
            else
            {
                _currentWeaponID++;
            }

            _weaponList[_currentWeaponID].gameObject.SetActive(true);
        }
    }

    public void ChangePreviousWeapon()
    {
        if (_weaponList.Count > 0)
        {
            _weaponList[_currentWeaponID].gameObject.SetActive(false);

            if (_currentWeaponID <= 0)
            {
                _currentWeaponID = _weaponList.Count - 1;
            }
            else
            {
                _currentWeaponID--;
            }

            _weaponList[_currentWeaponID].gameObject.SetActive(true);
        }
    }

    public void AddWeapon(GameObject weaponPrefab)
    {
        weaponPrefab.transform.SetParent(_grid.transform);

        _weaponList.Add(weaponPrefab.GetComponent<Weapon>());
    }
}
