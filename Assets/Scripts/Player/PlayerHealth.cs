using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(PlayerFacade))]
public class PlayerHealth : MonoBehaviour, IDamagable
{
    [SerializeField] private int _maxHealth;
    private int _health;
    private PlayerFacade _playerFacade;

    private void Start()
    {
        _health = _maxHealth;
        _playerFacade = GetComponent<PlayerFacade>();
    }

    public void GetDamage(int damage)
    {
        if (_health - damage > 0)
        {
            _health -= damage;
        }
        else
        {
            Death();
        }
    }

    public void Death()
    {
        _playerFacade.KillPlayer();
    }
}
