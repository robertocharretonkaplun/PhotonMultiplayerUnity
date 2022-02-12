using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
public class GrabController : MonoBehaviour
{
  public Transform grabDetect;
  public Transform boxHolder;
  public float rayDist = 2;
  PhotonView view;
  private void Start()
  {
    view = GetComponent<PhotonView>();
  }
  // Update is called once per frame
  void Update()
  {
    if (view.IsMine)
    {

      Vector3 maxDist = new Vector3(Vector3.right.x * transform.lossyScale.x, Vector3.right.y * transform.lossyScale.y, Vector3.right.z * transform.lossyScale.z);
      RaycastHit[] grabCheck = Physics.RaycastAll(grabDetect.position, maxDist, rayDist);
      for (int i = 0; i < grabCheck.Length; i++)
      {

        if (grabCheck[i].collider != null && grabCheck[i].collider.tag == "Box")
        {
          if (Input.GetKey(KeyCode.E))
          {
            grabCheck[i].collider.gameObject.transform.parent = boxHolder;
            grabCheck[i].collider.gameObject.transform.position = boxHolder.position;
            grabCheck[i].collider.gameObject.GetComponent<Rigidbody>().isKinematic = true;
          }
          else
          {
            grabCheck[i].collider.gameObject.transform.parent = null;
            grabCheck[i].collider.gameObject.GetComponent<Rigidbody>().isKinematic = false;
          }
        }
      }
      if (Input.GetKey(KeyCode.Q))
      {
        if (boxHolder.transform.childCount > 0)
        {
          boxHolder.transform.GetChild(0).GetComponent<Rigidbody>().isKinematic = false;
          boxHolder.transform.GetChild(0).GetComponent<Rigidbody>().AddForce(boxHolder.transform.forward * 600);
          boxHolder.transform.GetChild(0).transform.parent = null;
        }
      }
    }
  }
}
