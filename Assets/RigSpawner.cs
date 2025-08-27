using UnityEngine;

public sealed class RigSpawner : MonoBehaviour
{
    [SerializeField] GameObject _prefab = null;
    [SerializeField] int _spawnCount = 10;
    [SerializeField] Vector3 _delta = Vector3.right * 1.5f;

    void Start()
    {
        for (int i = 0; i < _spawnCount; i++)
        {
            var pos = _delta * (i - (_spawnCount - 1) * 0.5f);
            Instantiate(_prefab, pos, Quaternion.identity);
        }
    }
}
