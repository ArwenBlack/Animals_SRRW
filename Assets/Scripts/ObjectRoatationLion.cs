using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRoatationLion : MonoBehaviour
{
	public GameObject objectRotate;
	public float rotateSpeed = 50f;
	public Rigidbody rb;
	public Vector3 cenLocal;
	bool rotateStatus = false;
	void Start()
	{
		rb = objectRotate.GetComponent<Rigidbody>();
		cenLocal = objectRotate.GetComponent<BoxCollider>().center;
	}
	public void RotateObject()
	{
		if (rotateStatus == false)
		{
			rotateStatus = true;
		}
		else
		{
			rotateStatus = false;
		}
	}
	void Update()
	{
		if (rotateStatus == true)
		{
			objectRotate.transform.Rotate(new Vector3(0, 0, rotateSpeed) * Time.deltaTime);
		}
	}
}
