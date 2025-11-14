using UnityEngine;
using System;

public class PlayerInput : MonoBehaviour
{
    public PlayerInputs PlayerControl { get; private set; }

    public Action OnShoot;
    public Action OnNextWeapon;
    public Action OnPreviousWeapon;

    private void Awake()
    {
        PlayerControl = new PlayerInputs();

        PlayerControl.DefaultMap.Shot.performed += ctx => OnShoot();
        PlayerControl.DefaultMap.NextWeapon.performed += ctx => OnNextWeapon();
        PlayerControl.DefaultMap.PreviousWeapon.performed += ctx => OnPreviousWeapon();

        PlayerControl.Enable();
    }

    private void OnEnable()
    {
        PlayerControl.Enable();
    }

    private void OnDisable()
    {
        PlayerControl.Disable();
    }
}
