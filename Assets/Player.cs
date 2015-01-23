using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public float speed = 10;
    public float moveSpeed = 20;
    public static Player player;

	// Use this for initialization
	void Awake () {
        player = this;
	}
	
	// Update is called once per frame
	void Update () {
        float rotSpeed = Input.GetAxis("Horizontal") * Time.deltaTime * speed;

        this.transform.Rotate(Vector3.up * rotSpeed);
        this.transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
	}

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
        if(collision.gameObject.name.Equals("Enemy1")){
            Application.LoadLevel(Application.loadedLevel);
        }
    }
}
