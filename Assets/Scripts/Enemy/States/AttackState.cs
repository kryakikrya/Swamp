using UnityEngine;

public class AttackState : State
{
    [SerializeField] private int _damage;
    [SerializeField] private float _delay;
    [SerializeField] private Animator _animator;

    private float _lastAttackTime;

    private PlayerFacade _targetFacade;

    private void Start()
    {
        _targetFacade = Target.GetComponent<PlayerFacade>();
    }

    private void Update()
    {
        if(_lastAttackTime <= 0)
        {
            _lastAttackTime = _delay;
            Attack(_targetFacade);
        }

        _lastAttackTime -= Time.deltaTime;
    }

    private void Attack(PlayerFacade target)
    {
        _animator.Play("Hit");
        target.GetDamage(_damage);
    }
}
