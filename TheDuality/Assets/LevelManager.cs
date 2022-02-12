using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
  List<int> answerBlockList = new List<int>();
  public List<GameObject> answerBlock = new List<GameObject>();
  public List<GameObject> triggerBlocks = new List<GameObject>();
  // Start is called before the first frame update
  void Start()
  {
    answerBlockList.Add(1);
    answerBlockList.Add(2);
    answerBlockList.Add(6);
    answerBlockList.Add(4);
    answerBlockList.Add(5);
    answerBlockList.Add(3);

    for (int i = 0; i < triggerBlocks.Count; i++)
    {
      triggerBlocks[i].GetComponent<TriggerBlockScript>().randomIndexPos = answerBlockList[i];
    }

    for (int i = 0; i < answerBlockList.Count; i++)
    {
      if (answerBlockList[i] == 6)
      {

        answerBlock[i].transform.GetChild(0).GetComponent<TextMesh>().text = "X";
      }
      else
      {
        answerBlock[i].transform.GetChild(0).GetComponent<TextMesh>().text = answerBlockList[i].ToString();
      }
    }
  }

  // Update is called once per frame
  void Update()
  {

  }
}
