using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBlockScript : MonoBehaviour
{
  public int randomIndexPos = 0;
  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {

  }

  private void OnTriggerEnter(Collider other)
  {
    if (other.gameObject.GetComponent<TargetBlock>().indexBlockPosition == randomIndexPos)
    {
      Debug.Log("Posicion Correcta: " + other.gameObject.name);
      other.gameObject.GetComponent<TargetBlock>().isBlockInCorrectColor = true;
    }
    else
    {
      other.gameObject.GetComponent<TargetBlock>().isBlockInCorrectColor = false;
    }
  }
}
