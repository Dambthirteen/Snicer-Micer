using Unity.VisualScripting;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.ReorderableList;


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
        _AudioSource.pitch = Random.Range(0.9f, 1.2F);
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("Moving");
            _AudioSource.enabled = true;
        }
        else
        {
            _AudioSource.enabled = false;
        }
    }

}
