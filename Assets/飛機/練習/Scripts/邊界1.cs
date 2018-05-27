using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 邊界1 : MonoBehaviour {




    private void OnTriggerExit(Collider other)
    {
        Destroy(other.gameObject);
    }
}
