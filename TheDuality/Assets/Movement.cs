using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
public class Movement : MonoBehaviour
{
  public Rigidbody rg;
  float speed = 5.0f;
  PhotonView view;
  public int id;
  Renderer render;
  public Material black;
  public Material white;
  // Start is called before the first frame update
  void Start()
  {
    view = GetComponent<PhotonView>();
    render = GetComponent<Renderer>();
    if (id == 1)
    {
      setWhiteMaterial();
    }
    else
    {
      setBlackMaterial();
    }
  }

  // Update is called once per frame
  void Update()
  {
    if (view.IsMine)
    {
      Vector3 movementInput = Vector3.zero;
      if (Input.GetKey(KeyCode.D))
      {
        movementInput.x = 1;
        //rg.AddForce(5, 0, 0);
      }
      if (Input.GetKey(KeyCode.A))
      {
        movementInput.x = -1;
        //rg.AddForce(-5, 0, 0);
      }
      if (Input.GetKey(KeyCode.W))
      {
        movementInput.z = 1;
        //rg.AddForce(0, 8, 0);
      }
      if (Input.GetKey(KeyCode.S))
      {
        movementInput.z = -1;
        //rg.AddForce(0, 8, 0);
      }
      Move(movementInput);
    }
  }

  void Move(Vector3 dir)
  {
    transform.position += dir.normalized * speed * Time.deltaTime;
  }

  public void setBlackMaterial()
  {
    render.sharedMaterial = black;
  }
  
  public void setWhiteMaterial()
  {
    render.sharedMaterial = white;
  }
}
