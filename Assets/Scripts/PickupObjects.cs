using UnityEngine;

public class PickupObjects : MonoBehaviour
{
    public GrandDoor grandDoor;
    public TreasureDoor treasureDoor;
    
    public int collectedKey = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (collectedKey >= 2)
        {
            grandDoor.OpenGrandDoor();
        }

        if (collectedKey >= 3) 
        { 
            treasureDoor.OpenTreasureDoor();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Key")
        {
            collectedKey++;
            Destroy(other.gameObject);
        }
    }
}
