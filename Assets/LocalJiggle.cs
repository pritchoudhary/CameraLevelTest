using UnityEngine;
using System.Collections;

public class LocalJiggle : MonoBehaviour {

	public Vector3 axisScale, timeScale;
	
	// Update is called once per frame
	void Update () {
		transform.localPosition = new Vector3 (Mathf.PerlinNoise (Time.realtimeSinceStartup * timeScale.x, 1) * axisScale.x, 
			Mathf.PerlinNoise (Time.realtimeSinceStartup * timeScale.y, 10)* axisScale.y, 
			Mathf.PerlinNoise (Time.realtimeSinceStartup * timeScale.z, 100)* axisScale.z) - axisScale * 0.5f;

		/*transform.localRotation = Quaternion.Euler(new Vector3 (Mathf.PerlinNoise (Time.realtimeSinceStartup * timeScale.x, 5) * axisScale.x, 
			Mathf.PerlinNoise (Time.realtimeSinceStartup * timeScale.y, -20)* axisScale.y, 
			Mathf.PerlinNoise (Time.realtimeSinceStartup * timeScale.z, 40)* axisScale.z) - axisScale * 0.5f);*/
	}
}
