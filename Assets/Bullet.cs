using UnityEngine;

public sealed class Bullet : MonoBehaviour
{
    [SerializeField] float _lifetime = 1;

    async void Start()
    {
        await Awaitable.WaitForSecondsAsync(_lifetime);
        Destroy(gameObject);
    }
}
