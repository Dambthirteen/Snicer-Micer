using UnityEngine;

public class MoveParticles : MonoBehaviour
{

    [SerializeField] private ParticleSystem MoveParticleRight;
    private ParticleSystem _MoveparticleSystem;
    [SerializeField] Transform RightTransform;
    [SerializeField] Transform LeftTransform;
    
    void Start()
    {
        
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            _MoveparticleSystem = Instantiate(MoveParticleRight, RightTransform.position, Quaternion.Euler(new Vector3(0, 0, 0)));
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            _MoveparticleSystem = Instantiate(MoveParticleRight, LeftTransform.position, Quaternion.Euler(new Vector3(-90, 0, 0)));
        }
    }
}
