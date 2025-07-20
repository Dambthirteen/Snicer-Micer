using UnityEngine;

public class DespawnLostObjects : MonoBehaviour
{
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Carrot"))
        {
            Destroy(other.gameObject);
        }

        if (other.gameObject.CompareTag("Potato"))
        {
            Destroy(other.gameObject);
        }

        if (other.gameObject.CompareTag("Avocado"))
        {
            Destroy(other.gameObject);
        }
                


    }
}
