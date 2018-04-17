using UnityEngine;

public class KnifeThrower : MonoBehaviour
{
	private float speed = 30f;
	private bool throwed, spiked;
	
	private Rigidbody2D rb;

	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
	}
	
	void Update ()
	{
		if (spiked)
		{
			rb.angularVelocity = 0f; 
			rb.velocity = Vector2.zero;
			return;
		}
		
		if (throwed && !spiked)
		{
			rb.AddForce(transform.up * speed);
			return;
		}
		
		if (Input.GetKeyDown(KeyCode.Space))
		{
			throwed = true;
		}
	}

	public bool Spiked
	{
		set { spiked = value; }
	}
}
