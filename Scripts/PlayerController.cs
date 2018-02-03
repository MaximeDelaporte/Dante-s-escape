using UnityEngine;
using System.Collections;

[System.Serializable]
public class Boundary {
	public float xMin, xMax, yMin, yMax;
}
/// <summary>
/// Player controller and behavior
/// </summary>
public class PlayerController : MonoBehaviour
{
	/// <summary>
	/// 1 - The speed of the hero
	/// </summary>
	public Vector2 speed = new Vector2(50, 50);
	public Boundary boundary;
    public GameObject Vie1;
    public GameObject Vie2;
    public GameObject Vie3;
	
	// 2 - Store the movement
	private Vector2 movement;
    void Start()
    {
        Vie1.SetActive(true);
        Vie2.SetActive(true);
        Vie3.SetActive(true);
    }


	
	void Update()
	{
		// 3 - Retrieve axis information
		float inputX = Input.GetAxis("Horizontal");
		float inputY = Input.GetAxis("Vertical");
		
		// 4 - Movement per direction
		movement = new Vector2(speed.x * inputX, speed.y * inputY);
        if (DestroyByContact.compteur == 0)
        {
            Vie1.SetActive(true);
            Vie2.SetActive(false);
            Vie3.SetActive(false);
        }
        else if (DestroyByContact.compteur == 1)
        {
            Vie1.SetActive(false);
            Vie2.SetActive(true);
            Vie3.SetActive(false);
        }else if (DestroyByContact.compteur == 2)
        {
            Vie1.SetActive(false);
            Vie2.SetActive(false);
            Vie3.SetActive(true);
        }
		if (DestroyByContact.compteur > 2) 
		{
			Destroy(this.gameObject);
		}
        
	}

	
	void FixedUpdate()
	{
		// 5 - Move the game object
			GetComponent<Rigidbody2D>().velocity = movement;
			GetComponent<Rigidbody2D>().position = new Vector2(Mathf.Clamp(GetComponent<Rigidbody2D>().position.x, boundary.xMin, boundary.xMax),Mathf.Clamp(GetComponent<Rigidbody2D>().position.y, boundary.yMin, boundary.yMax));
       
	}
	void OnDestroy()
	{                   
		// Game Over.
		// Ajouter un nouveau script au parent
		// Car cet objet va être détruit sous peu
        transform.parent.gameObject.AddComponent<GameOverScript>();
	}
	void OnTriggerEnter (Collider other) {
		if ( other.tag == "Ennemy" ) {
			//gameController.AddExplosionAtPosition(1,transform.position);
			//gameController.GameOver();

			Destroy (other.gameObject);
			Destroy (gameObject);
		}
	}
}