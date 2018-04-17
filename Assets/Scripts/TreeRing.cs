using UnityEngine;

public class TreeRing : MonoBehaviour {

	private float defaultSpeed = 50f;
	
	void Update () {
		transform.Rotate(Vector3.forward, defaultSpeed * Time.deltaTime);
	}

	private void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.name.Contains("KnifePrefab"))
		{
			other.transform.parent = transform;
			other.gameObject.GetComponent<KnifeThrower>().Spiked = true;
			other.gameObject.GetComponent<Collider2D>().isTrigger = true;
			KnifeCreator.instance.Create();
		}
	}
}
