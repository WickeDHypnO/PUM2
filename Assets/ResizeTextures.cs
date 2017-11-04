using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResizeTextures : MonoBehaviour {

    public float globalSizeModifier = 0.5f;

	[ContextMenu("Resize Textures")]
	void Resize () {
		foreach(MeshRenderer mr in GetComponentsInChildren<MeshRenderer>())
        {
            mr.material.SetTextureScale("_MainTex", new Vector2(mr.transform.localScale.x * globalSizeModifier, mr.transform.localScale.z * globalSizeModifier));
            if(mr.transform.eulerAngles.y != 0 && mr.transform.eulerAngles.y != 180)
                mr.material.SetTextureOffset("_MainTex", new Vector2(0,0.0625f));
            else
                mr.material.SetTextureOffset("_MainTex", Vector2.zero);
        }
	}
}
