using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    [SerializeField] protected Bullet Bullet;
    [SerializeField] protected Transform FirePosition;

    [SerializeField] private string _name;
    [SerializeField] private Sprite _icon;

    [SerializeField] protected int _damage;
    [SerializeField] protected float _speed;

    public virtual void Shoot()
    {
        Bullet bullet = Instantiate(Bullet, FirePosition.position, Quaternion.identity);
        InitializeBullet(bullet, _damage, _speed);
    }

    public void InitializeBullet(Bullet bullet, int damage, float speed)
    {
        bullet.Init(damage, speed);
    }

    public string Name => _name;

    public Sprite Icon => _icon;
}
