using UnityEngine;
using System.Collections;

public class PlayerCamera : MonoBehaviour {

    public Player pl;
    public float cameraSmooth = 0.0001f;

	// Use this for initialization
	void Start () {
        pl = Player.player;
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 newPosition = new Vector3();
        newPosition.x = Mathf.Lerp(this.transform.position.x, pl.transform.position.x, Time.deltaTime * cameraSmooth);
        newPosition.y = 10;
        newPosition.z = Mathf.Lerp(this.transform.position.z, pl.transform.position.z, Time.deltaTime * cameraSmooth);
        transform.position = newPosition;
	}
}
