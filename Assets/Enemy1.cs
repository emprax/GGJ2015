using UnityEngine;
using System.Collections;

public class Enemy1 : MonoBehaviour {

    public float rotSpeed = 10;
    public float moveSpeed = 15;
    public Player pl;

	// Use this for initialization
	void Start () {
        pl = Player.player;
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.LookAt(new Vector3(pl.gameObject.transform.position.x, 0, pl.gameObject.transform.position.z));
        this.transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);
	}
}
