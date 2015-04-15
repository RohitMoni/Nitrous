using UnityEngine;
using System.Collections;

public class PlayerBehaviour : MonoBehaviour
{
    private Camera _main;

    void Awake()
    {
        // All reference declarations go here
        _main = Camera.main;
    }

	// Use this for initialization
	void Start ()
	{
        _main.transform.SetParent(transform);
        _main.transform.localRotation = Quaternion.Euler(8, 0, 0);
        _main.transform.localPosition = new Vector3(0, 2.7f, -1.8f);
	    _main.transform.localScale = new Vector3(1, 1, 1);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
