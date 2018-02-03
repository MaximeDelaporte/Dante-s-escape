using UnityEngine;
using System.Collections;

public class DestroyByContact : MonoBehaviour 
{
	public static int compteur;
	void Start()
	{
		compteur = 0;
	}
	void OnCollisionEnter2D(Collision2D coll) 
	{
        Animator animator = GetComponent<Animator>();
		compteur ++;
        animator.SetTrigger ("Hit"); 
	}
}

