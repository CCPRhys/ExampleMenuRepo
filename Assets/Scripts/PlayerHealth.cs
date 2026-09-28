using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    private int health = 100;
    private int maxHealth;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Current health is " + health);
        ApplyDamage(67);
        Debug.Log("Current health is " + health);
    }

    // Update is called once per frame
    void Update()
    {

    }

    bool ApplyDamage(int damage)
    {
        if(health - damage < 0)
        {
            //die
            return true;
        }
        else
        {
            health = health - damage;
            return false;
        }
    }

}
