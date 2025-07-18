using Unity.VisualScripting;
using UnityEngine;

public class VegCollider : MonoBehaviour
{

    public GameObject[] GmVeg;

    void Start()
    {

    }


    void Update()
    {

    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log(other.gameObject.name);
    }


}
