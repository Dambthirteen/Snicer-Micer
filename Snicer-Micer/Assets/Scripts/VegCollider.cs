using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class VegCollider : MonoBehaviour
{

    public GameObject[] GmVeg;

    int CarrotCounter;
    int PotatoCounter;
    int AvocadoCounter;

    void Start()
    {

    }


    void Update()
    {
        Debug.Log(CarrotCounter);
        Debug.Log(PotatoCounter);
        Debug.Log(AvocadoCounter);
    }

    private void OnTriggerEnter(Collider other)
    {


        if (other.gameObject.CompareTag("Carrot"))
        {
            CarrotCounter += 1;
        }

        if (other.gameObject.CompareTag("Potato"))
        {
            PotatoCounter += 1;
        }

        if (other.gameObject.CompareTag("Avocado"))
        {
            AvocadoCounter += 1;
        }
        ///Instantiate(GmVeg[1], new Vector3(transform.position.x, -1f, transform.position.z), quaternion.identity);
    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Destroy(other.gameObject);

            SpawnVegetables();

            CarrotCounter = 0;
            PotatoCounter = 0;
            AvocadoCounter = 0;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Carrot"))
        {
            CarrotCounter -= 1;
        }

        if (other.gameObject.CompareTag("Potato"))
        {
            PotatoCounter -= 1;
        }

        if (other.gameObject.CompareTag("Avocado"))
        {
            AvocadoCounter -= 1;
        }
    }

    private void SpawnVegetables()
    {
        for (int i = 0; i < PotatoCounter; i++)
        {
            Instantiate(GmVeg[0], new Vector3(transform.position.x, -1f, transform.position.z), quaternion.identity);
        }
        for (int i = 0; i < CarrotCounter; i++)
        {
            Instantiate(GmVeg[1], new Vector3(transform.position.x, -1f, transform.position.z), quaternion.identity);
        }
        for (int i = 0; i < AvocadoCounter; i++)
        {
            Instantiate(GmVeg[2], new Vector3(transform.position.x, -1f, transform.position.z), quaternion.identity);
        }

    }




}
