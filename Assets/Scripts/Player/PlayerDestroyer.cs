using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDestroyer : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    [SerializeField] private float _delay;

    public void KillPlayer()
    {
        Destroy(_player);
        Invoke(nameof(ChangeScene), _delay);
    }

    private void ChangeScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
