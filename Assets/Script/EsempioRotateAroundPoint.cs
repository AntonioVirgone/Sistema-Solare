using UnityEngine;
using System.Collections;

public class EsempioRotateAroundPoint : MonoBehaviour 
{
	public float angle = 20.0F;
	public Vector3 axis = Vector3.up;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.RotateAround (Vector3.zero, axis, angle * Time.deltaTime);
	}
}
