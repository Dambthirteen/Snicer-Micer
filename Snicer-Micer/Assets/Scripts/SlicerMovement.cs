using Unity.VisualScripting;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using FirstGearGames.SmoothCameraShaker;


public class SlicerMovement : MonoBehaviour
{


    [Header("Slicer Components")]
    Rigidbody _rb;
    [SerializeField] GameObject Slicer;
    public float _MovementSpeed;
    public float _Sprintspeed;
    Vector3 HorizontalMovement;
    Vector3 PreviousPosition;

    public AudioSource _AudioSource;
    public ShakeData explosionShakeData;


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

        if (Input.GetKey(KeyCode.LeftShift))
        {
            Debug.Log("Sprint");
            transform.Translate(HorizontalMovement * _Sprintspeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            CameraShakerHandler.Shake(explosionShakeData);
        }
    }

    public void MoveSound()
    {
        
        if (Input.GetKey(KeyCode.LeftShift))
        {
            _AudioSource.pitch = Random.Range(1.2f, 1.4f);
        }
        else
        {
            _AudioSource.pitch = Random.Range(0.9f, 1.2F);
        }

        if (Input.GetKeyDown(KeyCode.D) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow))
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
