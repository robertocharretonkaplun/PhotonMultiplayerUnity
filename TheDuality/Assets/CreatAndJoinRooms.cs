using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Photon.Pun;
public class CreatAndJoinRooms : MonoBehaviourPunCallbacks
{
  public InputField create;
  public InputField join;

  public void CreateRoom()
  {
    PhotonNetwork.CreateRoom(create.text);
  }

  public void JoinRoom()
  {
    PhotonNetwork.JoinRoom(join.text);
  }

  public override void OnJoinedRoom()
  {
    //if (PhotonNetwork.CurrentRoom.PlayerCount > 1)
    //{
    //  PhotonNetwork.LoadLevel("Answers");
    //}
    //else
    //{
    //}
    PhotonNetwork.LoadLevel("Game");
  }
}
