using UnityEngine;
using UnityEngine.UIElements;
using Unity.Profiling;

public class PhysicsTimeLogger : MonoBehaviour
{
    ProfilerRecorder _profiler;
    (int count, float time) _sum;

    void OnEnable()
      => _profiler = ProfilerRecorder.StartNew(ProfilerCategory.Physics, "Physics.Simulate");

    void OnDisable()
      => _profiler.Dispose();

    void FixedUpdate()
      => _sum = (_sum.count + 1, _sum.time + _profiler.LastValue * 1e-6f);

    void Update()
    {
        if (_sum.count == 0) return;

        var label = GetComponent<UIDocument>().rootVisualElement.Q<Label>();
        label.text = $"Average: {_sum.time / _sum.count:F2} ms";
    }
}
