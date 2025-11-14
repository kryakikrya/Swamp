using UnityEngine;
using System.Collections.Generic;

public class ShopController : MonoBehaviour
{
    [SerializeField] private GameObject _grid;
    [SerializeField] private GameObject _weaponPanelPrefab;
    [SerializeField] private PlayerFacade _playerFacade;

    private List<Weapon> _weapons;

    private void Awake()
    {
        _weapons = _playerFacade.Weapons;

        foreach (var weapon in _weapons)
        {
            GameObject newPanel = Instantiate(_weaponPanelPrefab, _grid.transform);
            newPanel.GetComponent<WeaponPanel>().Init(weapon.Name, weapon.Icon, weapon, this);
        }
    }

    public void UnlockItem(Weapon weapon)
    {
        foreach (var lockedWeapon in _weapons)
        {
            if (lockedWeapon.Name == weapon.Name)
            {
                _playerFacade.AddWeapon(lockedWeapon.gameObject);
            }
        }
    }
}
