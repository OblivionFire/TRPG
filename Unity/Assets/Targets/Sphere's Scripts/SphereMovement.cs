using UnityEngine;


public class SphereMovement : MonoBehaviour {

	[Header("Object Stats")]
	public float unitSpeed = 5f;
	//[Header("Unity Presets")]

	//Private Veriables
	private Transform target;
	private int wayPointIndex = 0;


	void initializeValues()
	{

		target = wayPointPathFinding.points[0];

	}


	void Start () 
	{
		initializeValues();
	}
	

	void Update () 
	{
		Vector3 dir = target.position - transform.position;
		transform.Translate(dir.normalized * unitSpeed * Time.deltaTime, Space.World);

		if(Vector3.Distance(transform.position, target.position) <= .4f)
		{
			getNextWaypoint();
		}
	}

	void getNextWaypoint()
	{
		if(wayPointIndex >= wayPointPathFinding.points.Length - 1)
		{
			Destroy(gameObject);
			return;
		}

		wayPointIndex++;
		target = wayPointPathFinding.points[wayPointIndex];
	}
}
