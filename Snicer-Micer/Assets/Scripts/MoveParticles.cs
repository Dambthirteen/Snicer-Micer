using UnityEngine;

public class MoveParticles : MonoBehaviour
{

    [SerializeField] private ParticleSystem MoveParticleRight;
    private ParticleSystem _MoveparticleSystem;
    [SerializeField] Transform LeftTransform;
    
    void Start()
    {
        
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D))
        {
            _MoveparticleSystem = Instantiate(MoveParticleRight, LeftTransform.position, Quaternion.identity);
        }
    }
}
