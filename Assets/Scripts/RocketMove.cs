using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RocketMove : MonoBehaviour {
    private Quaternion from;
    private Quaternion to;
    private float countTime = 0.0f;
    private GameObject player;
    private Rigidbody2D rg;
    private float z = 0f;
    public float Speed = 10f;
	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        
        rg = GetComponent<Rigidbody2D>();
        rg.isKinematic = true;
	}


    private void OnCollisionEnter2D(Collision2D collision)
    {
            SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    }


    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A))
        {
            RotateLeft();
            rg.MovePosition(transform.position + new Vector3(-1,0,0) * Speed * Time.fixedDeltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            RotateRight();
            rg.MovePosition(transform.position + new Vector3( 1, 0, 0) * Speed * Time.fixedDeltaTime);
        }

       // rg.MovePosition(transform.position + transform.right * Time.fixedDeltaTime);
    }

    /**private void OnMouseDrag()
      {
           Vector2 mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y);
          Vector2 objPos = Camera.main.ScreenToWorldPoint(mousePos);
            player.transform.position = Vector2.Lerp(player.transform.position, new Vector2(objPos.x, player.transform.position.y), Speed * Time.deltaTime);
         //  player.transform.position = Vector2.Lerp()
      }**/

    private void RotateLeft()
    {
        from = transform.rotation;
        to = Quaternion.Euler(0, 0, 40);
        transform.rotation = Quaternion.Slerp(from, to, countTime);
        countTime += Time.fixedDeltaTime;
    }

    private void RotateRight()
    {
        from = transform.rotation;
        to = Quaternion.Euler(0, 0, -40);
        transform.rotation = Quaternion.Slerp(from, to, countTime);
        countTime += Time.fixedDeltaTime;
    }
}
