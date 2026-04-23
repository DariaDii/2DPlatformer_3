using TMPro;
using UnityEngine;

public class TextIndicatorViewer : Viewer
{
    [SerializeField] private TextMeshProUGUI _currentValueText;
    [SerializeField] private TextMeshProUGUI _maxValueText;

    protected override void ChangeHealthIndicator(float currentValue, float maxValue)
    {
        _currentValueText.text = currentValue.ToString();
        _maxValueText.text = maxValue.ToString();
    }
}