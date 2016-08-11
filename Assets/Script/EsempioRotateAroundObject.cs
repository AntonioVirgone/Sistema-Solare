using UnityEngine;
using System.Collections;

public class EsempioRotateAroundObject : MonoBehaviour 
{
	public Vector3 rotationMask = new Vector3(0, 1, 0); //which axes to rotate around
	public float rotationSpeed = 5.0F; //degrees per second
	public Transform rotateAroundObject;

	// Use this for initialization
	void Start () {
	
	}
	
	void FixedUpdate() 
	{
		if (rotateAroundObject) {//If true in the inspector orbit <rotateAroundObject>:
			transform.RotateAround(rotateAroundObject.transform.position, rotationMask, rotationSpeed * Time.deltaTime);
		}
		else {//not set -> rotate around own axis/axes:
			transform.Rotate(new Vector3(
				rotationMask.x * rotationSpeed * Time.deltaTime,
				rotationMask.y * rotationSpeed * Time.deltaTime,
				rotationMask.z * rotationSpeed * Time.deltaTime));
		}
	}
}
