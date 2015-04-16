using UnityEngine;
using System.Collections;

public class PlayerBehaviour : MonoBehaviour
{
    // References
    private Camera _main;
    private Rigidbody _rigidbody;

    // Properties
    private float _acceleration;
    private float _brakeCoefficient;
    private float _handling;

    void Awake()
    {
        // All reference declarations go here
        _main = Camera.main;
        _rigidbody = GetComponent<Rigidbody>();
    }

	// Use this for initialization
	void Start ()
	{
        _main.transform.SetParent(transform);
        _main.transform.localRotation = Quaternion.Euler(8, 0, 0);
        _main.transform.localPosition = new Vector3(0, 2.7f, -1.8f);
	    _main.transform.localScale = new Vector3(1, 1, 1);

	    _acceleration = 1000.0f;
	    _brakeCoefficient = 0.01f;
	    _handling = 1.0f;
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetKey(KeyCode.W))
	    {
	        _rigidbody.AddForce(transform.forward * _acceleration);
	    }
        if (Input.GetKey(KeyCode.Space))
        {
            _rigidbody.velocity *= (1.0f - _brakeCoefficient);
        }

	    if (Input.GetKey(KeyCode.A))
	    {
	        _rigidbody.rotation *= Quaternion.AngleAxis(_handling, -transform.up);
            _rigidbody.velocity = Quaternion.AngleAxis(_handling, -transform.up) * _rigidbody.velocity;
	    }
	    if (Input.GetKey(KeyCode.D))
	    {
            _rigidbody.rotation *= Quaternion.AngleAxis(_handling, transform.up);
            _rigidbody.velocity = Quaternion.AngleAxis(_handling, transform.up) * _rigidbody.velocity;
        }
	}
}
