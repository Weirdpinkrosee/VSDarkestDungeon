using UnityEngine;

public class HPSystem : MonoBehaviour 
{
    public float HP;
  
    public float hp
    {
        get { return HP; }
        set { HP = value; }
    }

    public void Subscribe()
    {
        TestButton.HitTest += Damage;  // Subscribes to the event
        //HP = 24;  // Initial HP
    }

    public void Die()
    {
            Destroy(gameObject);  // Destroys the object when HP reaches 0
            HP = 0;
    }

    public void Damage()
    {
        HP -= 7;
    }
}