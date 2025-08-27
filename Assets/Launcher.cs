using UnityEngine;

public sealed class Launcher : MonoBehaviour
{
    [SerializeField] GameObject _bulletPrefab = null;
    [SerializeField] Vector3 _initialVelocity = Vector3.forward * 100;
    [SerializeField] float _interval = 0.3f;

    async void Start()
    {
        while (true)
        {
            var bullet = Instantiate(_bulletPrefab, transform.position, transform.rotation);
            bullet.GetComponent<Rigidbody>().linearVelocity = _initialVelocity;
            await Awaitable.WaitForSecondsAsync(_interval);
        }
    }
}
