using UnityEngine;

public class DestroyBottom : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    public void OnTriggerStay(Collider other)
    {
        Destroy(other.gameObject, 5f);
    }
    
}
