using UnityEngine;

public class EnemyLine : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _sprite;

    [SerializeField] private int _minOrder;
    [SerializeField] private int _maxOrder;

    public void ChangeLine()
    {
        _sprite.sortingOrder = Random.Range(_minOrder, _maxOrder);
    }
}
