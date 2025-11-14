using UnityEngine;

[RequireComponent (typeof(PlayerFacade))]
public class Player : MonoBehaviour
{
    private PlayerFacade _playerFacade;

    public PlayerFacade Facade => _playerFacade;

    private void Start()
    {
        _playerFacade = GetComponent<PlayerFacade>();
    }
}
