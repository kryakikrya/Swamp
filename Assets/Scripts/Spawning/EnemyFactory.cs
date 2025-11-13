using UnityEngine;

public class EnemyFactory : MonoBehaviour
{
    [SerializeField] private Wave[] _waves;
    [SerializeField] private Vector3 _spawnPoint;
    [SerializeField] private Player _target;

    private bool _needSpawn;

    private Wave _currentWave;
    private int _currentWaveNumber = -1;
    private float _timeAfterLastSpawn;
    private int _spawned = 0;

    private int _currentEnemy = 0;

    private void Start()
    {
        _spawnPoint = transform.position;
        NextWave();
    }

    private void Update()
    {
        if (_needSpawn)
        {
            if (_timeAfterLastSpawn > _currentWave.Delay)
            {
                if (_spawned + 1 >= _currentWave.Counts[_currentEnemy])
                {
                    if (_currentEnemy + 1 >= _currentWave.Counts.Length)
                    {
                        _needSpawn = false;
                    }
                    else
                    {
                        _currentEnemy++;
                        _spawned = 0;
                    }
                }

                CreateEnemy();

                _spawned++;

                _timeAfterLastSpawn = 0;
            }

            _timeAfterLastSpawn += Time.deltaTime;
        }
    }

    public void NextWave()
    {
        _currentWaveNumber++;

        if (_currentWaveNumber >= _waves.Length)
        {
            Destroy(gameObject);
            return;
        }

        _currentWave = _waves[_currentWaveNumber];

        _currentEnemy = 0;
        _spawned = 0;

        _needSpawn = true;
    }

    private void CreateEnemy()
    {
        GameObject newEnemy = Instantiate(_currentWave.EnemyPrefabs[_currentEnemy], _spawnPoint, Quaternion.identity);
        EnemyBehaviour enemyBehaviour = newEnemy.GetComponent<EnemyBehaviour>();
        enemyBehaviour.Init(_target);
    }
}
