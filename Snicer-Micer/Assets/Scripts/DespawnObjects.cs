using UnityEngine;

public class DespawnObjects : MonoBehaviour
{

    public static int ObjectCount = 0;
    public int MaxObjectsInSlicer = 10;

    void Start()
    {

    }


    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        ObjectCount++;
        Debug.Log(ObjectCount);
        

        if (ObjectCount >= MaxObjectsInSlicer)
        {
            Destroy(other.gameObject);
            ObjectCount = 0;
            Debug.Log("ObjectsDestroyed");
        }

        
    }

    
}
