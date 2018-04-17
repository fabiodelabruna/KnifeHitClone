using UnityEngine;

public class KnifeCreator : MonoBehaviour
{
	public static KnifeCreator instance;

	public Transform knifePrefab;

	void Awake()
	{
		if (instance == null)
		{
			instance = this;
		}
	}

	public void Create()
	{
		Instantiate(knifePrefab);
	}

}
