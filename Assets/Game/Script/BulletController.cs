using System.Collections;

using UnityEngine;

public class BulletController : MonoBehaviour
{
	public GameObject Bullet;

	public float Speed;

	public GameObject Tank;

	// Use this for initialization
	void Start()
	{
	}

	// Update is called once per frame
	void Update()
	{
		if(Input.GetKeyDown(KeyCode.A))
		{
			var obj = Instantiate(Bullet);

			obj.transform.position = transform.position;

			obj.GetComponent<Rigidbody>()
				.velocity = Tank.transform.forward * Speed;
		}
	}
}
