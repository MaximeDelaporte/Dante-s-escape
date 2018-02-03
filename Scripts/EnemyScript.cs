using UnityEngine;

/// <summary>
/// Comportement générique pour les méchants
/// </summary>
public class EnemyScript : MonoBehaviour
{
	private bool hasSpawn;
	private MoveScript moveScript;
	
	void Awake()
	{
	
		
		// Récupération du script de mouvement lié
		moveScript = GetComponent<MoveScript>();
	}
	
	// 1 - Disable everything
	void Start()
	{
		hasSpawn = false;
		
		// On désactive tout
		// -- collider
		GetComponent<Collider2D>().enabled = false;
		// -- Mouvement
		moveScript.enabled = false;
	
	}
	
	void Update()
	{
		// 2 - On vérifie si l'ennemi est apparu à l'écran
		if (hasSpawn == false)
		{
			if (GetComponent<Renderer>().IsVisibleFrom(Camera.main))
			{
				Spawn();
			}
		}
	
			
			// 4 - L'ennemi n'a pas été détruit, il faut faire le ménage
			if (GetComponent<Renderer>().IsVisibleFrom(Camera.main) == false)
			{
				Destroy(gameObject);
			}
		}

	
	// 3 - Activation
	private void Spawn ()
	{
		hasSpawn = true;
		
		// On active tout
		// -- Collider
		GetComponent<Collider2D>().enabled = true;
		// -- Mouvement
		moveScript.enabled = true;
		
	}
}