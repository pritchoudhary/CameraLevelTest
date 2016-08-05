using UnityEngine;
using System.Collections;

public class FromAtLerpController : MonoBehaviour {

	public Transform at, atProxy, fromTrans, fromProxyTrans;
	public float atLerpSpeed, fromLerpSpeed;
	public Transform camRoot;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		atProxy.position = Vector3.Lerp (atProxy.position, at.position, atLerpSpeed * Time.deltaTime);
		fromProxyTrans.position = Vector3.Lerp (fromProxyTrans.position, fromTrans.position, fromLerpSpeed * Time.deltaTime);

		camRoot.position = fromProxyTrans.position;
		camRoot.LookAt (atProxy);
	}
}
