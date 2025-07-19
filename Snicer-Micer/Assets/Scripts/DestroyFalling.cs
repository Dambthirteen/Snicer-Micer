using UnityEngine;

public class DestroyFalling : MonoBehaviour
{

    public int CountLostVeg;
    

    void Start()
    {
        
    }


    void Update()
    {
        Debug.Log(CountLostVeg);
        
    }


    public void OnCollisionEnter(Collision other)
    {
        CountLostVegetables();
        



        Destroy(other.gameObject);
    }

    public void CountLostVegetables()
    {
        CountLostVeg += 1;
    }
}
