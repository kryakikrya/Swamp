using UnityEngine;
public class EnemyHealth : MonoBehaviour, IDamagable
{
    [SerializeField] private int _maxHealth;
    private int _health;

    private void Start()
    {
        _health = _maxHealth;
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
        Destroy(gameObject);
    }
}
