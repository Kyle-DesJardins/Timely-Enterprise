using UnityEngine;
using System.Collections;

public class HealthFunctionality : MonoBehaviour {

    [SerializeField]
    private float maxHealth;

    [HideInInspector]
    private float totalHealth;

    public void setTotalHealth(float x)
    {
        totalHealth = x;
    }

    public float getTotalHealth()
    {
        return totalHealth;
    }

    public float getMaxHealth()
    {
        return maxHealth;
    }

}
