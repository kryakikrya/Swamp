using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private int _damage;
    [SerializeField] private float _speed;

    public void Init(int damage, float speed)
    {
        _damage = damage;
        _speed = speed;
        print("Init");
    }

    private void Update()
    {
        transform.Translate(Vector2.left * _speed * Time.deltaTime, Space.World);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Player _) == false)
        {
            if (collision.gameObject.TryGetComponent(out EnemyHealth enemy))
            {
                enemy.GetDamage(_damage);
            }

            Destroy(gameObject);
        }
    }
}
