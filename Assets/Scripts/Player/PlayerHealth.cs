using UnityEngine;

public class PlayerHealth : Health
{
    public void Heal(float amount)
    {
        HealthAmount += amount;
        if (HealthAmount > MaxHealth)
            HealthAmount = MaxHealth;

        Debug.Log($"Здоровье: " + HealthAmount);
        InvokeValueChange();
    }
}