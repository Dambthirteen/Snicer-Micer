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
            float RandHeight = Random.Range(6, 10);

            if (chance < 32)
            {
                Instantiate(gm[0], new Vector3(pos_x, RandHeight, 0f), Quaternion.identity);
            }
            else if (chance > 33 && chance < 66)
            {
                Instantiate(gm[1], new Vector3(pos_x, RandHeight, 0f), Quaternion.identity);
            }
            else
            {
                Instantiate(gm[2], new Vector3(pos_x, RandHeight, 0f), Quaternion.identity);
            }

            timer = 0.9f;

        }
        
    }
}
