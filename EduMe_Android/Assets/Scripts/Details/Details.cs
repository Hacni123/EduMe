using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public abstract class Details : MonoBehaviour
{

    public abstract void Start();

    public abstract IEnumerator GetDetails();
}
