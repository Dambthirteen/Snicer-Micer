using Unity.VisualScripting;
using UnityEngine;

public class SlicerMovement : MonoBehaviour
{


    [Header("Slicer Components")]
    Rigidbody _rb;
    [SerializeField] GameObject Slicer;
    public float _MovementSpeed;
    Vector3 HorizontalMovement;
    Vector3 PreviousPosition;

    public AudioSource _AudioSource;


    void Start()
    {
        Slicer = GetComponent<GameObject>();
        _rb = GetComponent<Rigidbody>();
    }


    void Update()
    {
        PreviousPosition = transform.position;
        InputManager();
        MoveSound();
    }

    public void InputManager()
    {
        HorizontalMovement = new Vector3(Input.GetAxisRaw("Horizontal"), 0, 0);
        transform.Translate(HorizontalMovement * _MovementSpeed * Time.deltaTime);
    }

    public void MoveSound()
    {
        if (transform.position != PreviousPosition)
        {
            _AudioSource.Play();
        }
    }
}
