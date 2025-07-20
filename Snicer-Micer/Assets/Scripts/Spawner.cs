using UnityEngine;

public class Spawner : MonoBehaviour
{
    float timer = 1;
    public GameObject[] gm;

    public float RandX1;
    public float RandX2;

    public Transform from;
    public Transform to;

    void Start()
    {
        transform.rotation = Random.rotationUniform;
        
    }


    void Update()
    {
        
        
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
        else
        {
            int chance = Random.Range(1, 101);
            float pos_x = Random.Range(RandX1, RandX2);
            float RandHeight = Random.Range(8, 12);

            if (chance < 32)
            {
                Instantiate(gm[0], new Vector3(pos_x, RandHeight, 0f), Quaternion.Euler(new Vector3(Random.Range(-45, 90), Random.Range(0, 45), Random.Range(45, -45))));
            }
            else if (chance > 33 && chance < 66)
            {
                Instantiate(gm[1], new Vector3(pos_x, RandHeight, 0f), Quaternion.Euler(new Vector3(Random.Range(-45, 90), Random.Range(0, 45), Random.Range(45, -45))));
            }
            else
            {
                Instantiate(gm[2], new Vector3(pos_x, RandHeight, 0f), Quaternion.Euler(new Vector3(Random.Range(-45, 90), Random.Range(0, 45), Random.Range(45, -45))));
            }

            timer = Random.Range(0.7f, 0.9f);

        }
        
    }
}
