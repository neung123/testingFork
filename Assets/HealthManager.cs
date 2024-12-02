using UnityEngine;

namespace Project.GameManager
{
    public class HealthManager
    {
        public int IncreaseHealth(int currentHealth, int increaseAmount, int maxHealth)
        {
            int newHealth = currentHealth + increaseAmount;
            return Mathf.Clamp(newHealth, 0, maxHealth);
        }
    }
}