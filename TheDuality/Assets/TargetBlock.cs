using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetBlock : MonoBehaviour
{
  public int indexBlockPosition = 0;
  public bool isBlockInCorrectColor = false;
  public TextMesh txm;
  float speed = 1.5f;
  public Camera cam;
  GameObject gameobject;// = new GameObject();

  // Start is called before the first frame update
  void Start()
  {
    gameobject = new GameObject();
    txm.text = indexBlockPosition.ToString();
  }

  // Update is called once per frame
  void Update()
  {
    Vector3 movementInput = Vector3.zero;
    if (Input.GetMouseButton(0))
    {
      Ray ray = cam.ScreenPointToRay(Input.mousePosition);
      if (Physics.Raycast(ray, out RaycastHit hitInfo))
      {
        if (hitInfo.collider.gameObject.tag == "Block")
        {
          gameobject = hitInfo.collider.gameObject;
        }
      }
    }
    if (Input.GetKey(KeyCode.D))
    {
      movementInput.x = 1;
      //rg.AddForce(5, 0, 0);
    }
    else if (Input.GetKey(KeyCode.A))
    {
      movementInput.x = -1;
      //rg.AddForce(-5, 0, 0);
    }
    else if (Input.GetKey(KeyCode.W))
    {
      movementInput.z = 1;
      //rg.AddForce(0, 8, 0);
    }
    else if (Input.GetKey(KeyCode.S))
    {
      movementInput.z = -1;
      //rg.AddForce(0, 8, 0);
    }
    else
    {
      speed = 0;
    }
    Move(movementInput, gameobject);
  }


  void Move(Vector3 dir, GameObject go)
  {
    speed = 1.5f;
    go.transform.position += dir.normalized * speed * Time.deltaTime;
  }
}
