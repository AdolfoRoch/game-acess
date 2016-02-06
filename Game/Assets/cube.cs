using UnityEngine;
using System.Collections;

public class cube : MonoBehaviour {

	public float moveSpeed;
	private Vector3 m_CamForward;             // The current forward direction of the camera
	private Vector3 m_Move;

	// Use this for initialization
	void Start ()
	{
		 moveSpeed = 1f;
	}
	
	// Update is called once per frame
	void Update ()
	{
		//print(Input.GetAxis("Horizontal"));
		transform.Translate(moveSpeed*Input.GetAxis("Horizontal")*Time.deltaTime,0f,moveSpeed*Input.GetAxis("Vertical")*Time.deltaTime);

	}
}
