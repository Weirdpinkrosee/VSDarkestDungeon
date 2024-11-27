using UnityEngine;

public class HPSystem : MonoBehaviour
{
    private float HP;

    public float hp
    {
        get { return HP; }
        set { HP = value; }
    }

    void Start()
    {
        TestButton.HitTest += Damage;  // Subscribes to the event
        HP = 24;  // Initial HP
    }

    void Update()
    {
        if (HP <= 0)
        {
            Destroy(gameObject);  // Destroys the object when HP reaches 0
            HP = 0;
        }
    }

    private void Damage()
    {
        HP -= 7;
    }
}