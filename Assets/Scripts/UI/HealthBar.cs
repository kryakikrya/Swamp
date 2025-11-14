using UnityEngine;

public class HealthBar : Bar
{
    [SerializeField] private PlayerHealth _health;

    private void OnEnable()
    {
        _health.OnHealthChange += OnValueChanged;
        Slider.value = 1;
    }

    private void OnDisable()
    {
        _health.OnHealthChange -= OnValueChanged;
    }
}
