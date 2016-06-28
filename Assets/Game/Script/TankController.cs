using System.Collections;

using UnityEngine;

public class TankController : MonoBehaviour
{
	public float MoveSpeed = 10.0f; // 物件移動速度

	public float TurnSpeed = 50.0f;

	// Use this for initialization
	void Start()
	{
	}

	// Update is called once per frame
	void Update()
	{
		if(Input.GetKey(KeyCode.UpArrow))
		{
			transform.rotation = Quaternion.Euler(0, 0, 0);
			transform.Translate(Vector3.forward * MoveSpeed * Time.deltaTime);
		}

		else if(Input.GetKey(KeyCode.DownArrow))
		{
			transform.rotation = Quaternion.Euler(0, 180, 0);
			transform.Translate(Vector3.forward * MoveSpeed * Time.deltaTime);
		}

		else if(Input.GetKey(KeyCode.LeftArrow))
		{
			transform.rotation = Quaternion.Euler(0, -90, 0);
			transform.Translate(Vector3.forward * MoveSpeed * Time.deltaTime);
		}

		else if(Input.GetKey(KeyCode.RightArrow))
		{
			transform.rotation = Quaternion.Euler(0, 90, 0);
			transform.Translate(Vector3.forward * MoveSpeed * Time.deltaTime);
		}
		
	}
}
