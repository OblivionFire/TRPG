using UnityEngine;
using System.Collections;
using TMPro;
public class WaveSpawner : MonoBehaviour {

	//[Header("Object Stats")]
	public float timeBetweenWaves = 6f;

	//[Header("Unity Presets")]
	public Transform enemyPrefab;
	public Transform spawnPoint;
	public TextMeshProUGUI waveCountDownText;

	//Private Veriables
	private float countdown = 2f;
	private int waveIndex = 1;


	void initializeValues()
	{

	}


	void Start () 
	{
		initializeValues();
	}
	

	void Update () 
	{
		if(countdown <=1)
		{
			StartCoroutine(spawnWave());
			countdown = timeBetweenWaves;
		}

		countdown -= Time.deltaTime;

		waveCountDownText.text = Mathf.Round(countdown).ToString() ;
	}

	IEnumerator spawnWave()
	{
		for (int i = 0; i < waveIndex; i++)
		{
			spawnEnemy();
			yield return new WaitForSeconds(.5f);
		}
		waveIndex++;
	}

	void spawnEnemy()
	{
		Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
	}
}
