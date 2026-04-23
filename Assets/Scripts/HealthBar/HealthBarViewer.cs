using UnityEngine;
using UnityEngine.UI;

public class HealthBarViewer : Viewer
{
    [SerializeField] private Slider _healhtBar;

    protected override void ChangeHealthIndicator(float currentValue, float maxValue)
    {
        _healhtBar.maxValue = maxValue;
        _healhtBar.value = currentValue;
    }
}