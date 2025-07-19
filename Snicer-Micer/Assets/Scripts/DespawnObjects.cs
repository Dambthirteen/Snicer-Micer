using UnityEngine;

public class DespawnObjects : MonoBehaviour
{

    public static int ObjectCount = 0;
    public int MaxObjectsInSlicer = 3;
    public bool DestroyNow = false;

    void Start()
    {

    }


    void Update()
    {
        Debug.Log(ObjectCount);
    }

    void OnTriggerEnter(Collider other)
    {
        ObjectCount++;
        


        if (ObjectCount >= MaxObjectsInSlicer && !DestroyNow)
        {
            DestroyNow = true;
        }
    }

    void OnTriggerStay(Collider collider)
    {
        if (DestroyNow)
        {
            for (int i = 0; i < ObjectCount; i++)
            {
                Destroy(collider.gameObject);
            }

            ObjectCount = 0;
            DestroyNow = false;
        }
    }




}
