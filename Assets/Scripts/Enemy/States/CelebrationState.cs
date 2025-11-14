using UnityEngine;

public class CelebrationState : State
{
    public static readonly int Celebration = Animator.StringToHash("Celebration");

    [SerializeField] private Animator _animator;

    private void OnEnable()
    {
        _animator.Play(Celebration);
    }

    private void OnDisable()
    {
        _animator.StopPlayback();
    }
}
