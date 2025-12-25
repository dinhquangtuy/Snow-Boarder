using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour {
    [SerializeField] GameObject playerToFollow;
    void LateUpdate() {
        transform.position = playerToFollow.transform.position + new Vector3(0, 0, -10);
    }
}
