using UnityEngine;

[CreateAssetMenu(fileName = "NewWave", menuName = "Wave/WaveData", order = 1)]
public class Wave : ScriptableObject
{
    public GameObject[] EnemyPrefabs;
    public int[] Counts;
    public float Delay;
}
