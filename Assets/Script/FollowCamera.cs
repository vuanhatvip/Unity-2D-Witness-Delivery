using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [Header("Attach Components")]
    [Tooltip("Game object which camera need to follow")] [SerializeField] private GameObject m_thingToFollow;
    //this things position (camera) should be the same as the car's position

    void LateUpdate()
    {
        transform.position = m_thingToFollow.transform.position + new Vector3(0, 0, -10);
    }
}
