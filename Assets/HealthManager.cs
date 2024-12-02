public class HealthManager
{
    public int IncreaseHealth(int currentHealth, int increaseAmount, int maxHealth)
    {
        int newHealth = currentHealth + increaseAmount;
        return ClampHealth(currentHealth, newHealth);
    }

    public int ClampHealth(int currentHealth, int maxHealth)
    {
        if (currentHealth > maxHealth)
        {
            return maxHealth;
        }
        else
        {
            return currentHealth;
        }
    }

}
