using UnityEngine;
using System.Collections;
using UnityEngine.Events;

public class EventsTest : MonoBehaviour {

	public UnityEvent onPlayerHasDied, onPlayerHasLeveledUp;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		onPlayerHasDied.Invoke();
	}
}
