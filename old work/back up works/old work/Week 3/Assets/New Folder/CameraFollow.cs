using System.Collections;
using System.Collections.Generic;

using UnityEngine;
public class CameraFollow : MonoBehaviour
{
	public Transform ObjectToFollow;
	public Vector3 Offset;

	void LateUpdate ()
	{
		if (ObjectToFollow != null)
			transform.position = ObjectToFollow.position + Offset;
		transform.LookAt (ObjectToFollow);
	}
}
