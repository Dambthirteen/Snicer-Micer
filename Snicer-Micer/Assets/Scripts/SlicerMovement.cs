using Unity.VisualScripting;
using UnityEngine;

public class SlicerMovement : MonoBehaviour
{


    [Header("Slicer Components")]
    Rigidbody _rb;
    [SerializeField] GameObject Slicer;
    public float _MovementSpeed;
    Vector3 HorizontalMovement;
    

    void Start()
    {
        Slicer = GetComponent<GameObject>();
        _rb = GetComponent<Rigidbody>();
    }


    void Update()
    {
        InputManager();
    }

    public void InputManager()
    {
        HorizontalMovement = new Vector3(Input.GetAxisRaw("Horizontal"), 0, 0);
        transform.Translate(HorizontalMovement * _MovementSpeed * Time.deltaTime);
        
    }
}
