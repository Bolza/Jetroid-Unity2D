using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookForward : MonoBehaviour {
	public Transform sightStart, sightEnd;
	public string layer = "Solid";
	public bool needsCollision = true;
	private bool collision;
	private bool canFlip = true;
	// Use this for initialization
	void Start () {
		
	}
	
//	 Update is called once per frame
	void Update () {
		collision = Physics2D.Linecast (sightStart.position, sightEnd.position, 1 << LayerMask.NameToLayer(layer));
		Debug.DrawLine (sightStart.position, sightEnd.position, Color.green);
		if (collision == needsCollision && canFlip) {
//			canFlip = false;
			transform.localScale = new Vector3 (transform.localScale.x == 1 ? -1 : 1, 1, 1);
//			StartCoroutine(ExecuteAfterTime(1f));

		}
	}
//	void OnCollisionEnter2D (Collision2D col) {
//		Collider2D collider = col.collider;
//		if (collider.CompareTag("Alien") && canFlip) {
//			canFlip = false;
//			transform.localScale = new Vector3 (transform.localScale.x == 1 ? -1 : 1, 1, 1);
//			Debug.logger.Log (gameObject.name, transform.localScale.x);
//			StartCoroutine(ExecuteAfterTime(.5f));
//
//		}
//	}
//	IEnumerator ExecuteAfterTime(float time)
//	{
//		yield return new WaitForSeconds(time);
//		canFlip = true;
//	}
}
