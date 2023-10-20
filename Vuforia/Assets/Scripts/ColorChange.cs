using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    public List<Texture> hairTextureList;
    public Material hairMaterial;

    private void Update()
    {
        ChangeHairCoclor();
    }

    public void ChangeHairCoclor()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            int currentHairTextureIndex = hairTextureList.IndexOf(hairMaterial.mainTexture);
            currentHairTextureIndex++;
            if(currentHairTextureIndex >= hairTextureList.Count)
            {
                currentHairTextureIndex = 0;
            }
            hairMaterial.mainTexture = hairTextureList[currentHairTextureIndex];
        }
    }
}
