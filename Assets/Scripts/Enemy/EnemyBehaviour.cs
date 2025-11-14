using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    [SerializeField] private State _startState;
    [SerializeField] private Player _target;
    [SerializeField] private EnemyLine _orderInLayer;

    private State _currentState;

    public State Current => _currentState;

    private void Start()
    {
        Reset(_startState);
    }

    private void Update()
    {
        if (_currentState == null)
        {
            return;
        }

        var nextState = _currentState.GetNextState();

        if (nextState != null)
        {
            Transit(nextState);
        }
    }

    public void Init(Player traget)
    {
        _target = traget;
        _orderInLayer.ChangeLine();
    }

    private void Reset(State startState)
    {
        _currentState = startState;

        if (_currentState != null)
        {
            _currentState.Enter(_target);
        }
    }

    private void Transit(State nextState)
    {
        if (_currentState != null)
        {
            _currentState.Exit();
        }

        if (_currentState != null)
        {
            nextState.Enter(_target);
        }

        _currentState = nextState;
    }
}
