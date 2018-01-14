using UnityEngine;

public class wayPointPathFinding : MonoBehaviour {

	[Header("Object Stats")]
	public static Transform[] points;

	//[Header("Unity Presets")]

	//Private Veriables

	void initializeValues()
	{

	}

	void Awake()
	{
		points = new Transform[transform.childCount]; //Create array 

		for (int i = 0; i < points.Length; i++)
		{
			//add all waypoints (Children of empty object Waypoints)
			points[i] = transform.GetChild(i);
		}
	}

	void Start () 
	{
		initializeValues();
	}
	

	void Update () 
	{

	}
}
