using System.Collections.Generic;
using System.Linq;

using UnityEngine;

public class CubeCreator : MonoBehaviour
{
	public GameObject Cube;

	public Queue<GameObject> Cubes = new Queue<GameObject>();

	// Use this for initialization
	void Start()
	{
	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.A))
		{
			var obj = Instantiate(Cube);
			var ms = obj.GetComponent<Renderer>().sharedMaterial;

			obj.GetComponent<Renderer>()
				.sharedMaterial.color = Color.black;

			Cubes.Enqueue(obj);

			Sort();
		}

		if (Input.GetKeyDown(KeyCode.B))
		{
			var obj = Instantiate(Cube);
			var ms = obj.GetComponent<Renderer>().sharedMaterial;

			obj.GetComponent<Renderer>()
				.sharedMaterial.color = Color.red;

			Cubes.Enqueue(obj);
			Sort();
		}


		if (Input.GetKeyDown(KeyCode.C))
		{
			var obj = Cubes.Dequeue();
			Destroy(obj);
		}

		if(Input.GetKeyDown(KeyCode.D))
		{
			var obj = this.Cubes.First();
			obj.GetComponent<Renderer>()
				.sharedMaterial.color = Color.green;
		}
	}

	void Sort()
	{
		var array = this.Cubes.ToArray();
		for(int i=0; i <array.Length;++i)
		{
			array[i].transform.position = new Vector3(i,0,0);
		}
	}
}
