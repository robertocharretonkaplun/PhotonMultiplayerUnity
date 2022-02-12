using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
public class SpawnPlayers : MonoBehaviour
{
  public GameObject playerPref;
  public float maxX;
  public float minX;
  public float maxY;
  public float minY;
  // Start is called before the first frame update
  void Start()
  {
    Vector3 randomPos = new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY), -0.7f);
    playerPref.GetComponent<Movement>().id = PhotonNetwork.CountOfPlayersInRooms;
    if (PhotonNetwork.CountOfPlayersInRooms > 0)
    {
      //playerPref.GetComponent<Movement>().setWhiteMaterial();
      PhotonNetwork.Instantiate(playerPref.name, new Vector3(-5.5f, 0.5f, 3.5f), Quaternion.identity);
    }
    else
    {
      //playerPref.GetComponent<Movement>().setBlackMaterial();
      PhotonNetwork.Instantiate(playerPref.name, new Vector3(-5.5f, 0.5f, -3.5f), Quaternion.identity);
    }

  }



  // Update is called once per frame
  void Update()
  {

  }
}
