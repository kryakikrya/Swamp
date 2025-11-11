using UnityEngine;

public class MoveState : State
{
    [SerializeField] private float _speed;

    private void Update()
    {
        transform.Translate(new Vector3(_speed, 0));
    }
}
