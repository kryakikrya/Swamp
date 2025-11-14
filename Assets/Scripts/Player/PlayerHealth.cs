using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(PlayerFacade))]
public class PlayerHealth : MonoBehaviour, IDamagable
{
    [SerializeField] private int _maxHealth;

    private int _health;

    private PlayerFacade _playerFacade;

    public event UnityAction<int,int> OnHealthChange;

    private void Start()
    {
        _health = _maxHealth;
        _playerFacade = GetComponent<PlayerFacade>();
    }

    public void GetDamage(int damage)
    {
        if (_health - damage <= 0)
        {
            Death();
        }

        _health = Mathf.Clamp(_health - damage, 0, _maxHealth);

        OnHealthChange?.Invoke(_health, _maxHealth);
    }

    public void Death()
    {
        _playerFacade.KillPlayer();
    }

    public int GetHealth() => _health;
}
