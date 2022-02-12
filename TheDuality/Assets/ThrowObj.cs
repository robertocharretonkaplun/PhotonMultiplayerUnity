using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowObj : MonoBehaviour
{
  Transform handPos;
  GameObject player;
  public bool hasPlayer = false;
  public bool beingCarried = false;
  public bool touched = false;
  public float throwForce = 10;
  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {

  }

  private void OnCollisionEnter(Collision collision)
  {
    if (collision.gameObject.name == "Player(Clone)")
    {
      GetComponent<Rigidbody>().isKinematic = false;
      GetComponent<Rigidbody>().useGravity = false;
      //GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePosition;
      transform.position = collision.gameObject.transform.position;
      transform.parent = collision.gameObject.transform.GetChild(0).transform;

    }
  }
  /*
  private void OnTriggerEnter(Collider other)
  {
    //player = other.gameObject;

    if (other.gameObject.name == "Player")
    {
      player = other.gameObject;
      float distance = Vector3.Distance(gameObject.transform.position, player.transform.position);
      if (distance <= 2.5)
      {
        hasPlayer = true;
      }
      else
      {
        hasPlayer = false;
      }

      if (hasPlayer && Input.GetMouseButton(0))
      {
        GetComponent<Rigidbody>().isKinematic = true;
        transform.parent = player.transform;
        beingCarried = true;
      }

      if (beingCarried)
      {
        if (touched)
        {
          GetComponent<Rigidbody>().isKinematic = false;
          transform.parent = null;
          beingCarried = false;
        }
        if (Input.GetMouseButton(0))
        {
          GetComponent<Rigidbody>().isKinematic = false;
          transform.parent = null;
          beingCarried = false;
          GetComponent<Rigidbody>().AddForce(player.transform.forward * throwForce);
        }
        else if (Input.GetMouseButton(1))
        {
          GetComponent<Rigidbody>().isKinematic = false;
          transform.parent = null;
          beingCarried = false;
        }
      }
    }

    if (beingCarried)
    {
      touched = true;
    }

  }*/
}
