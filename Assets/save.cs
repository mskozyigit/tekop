using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class save : MonoBehaviour {

    public List<int> livingTargetPositions = new List<int>();
    public List<int> livingTargetsTypes = new List<int>();

    public int hits = 0;
    public int shots = 0;
}
