using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialApplier: MonoBehaviour

{

public Material originalMaterial;
public Material otherMaterial;

private Renderer rend;

public void Applyoriginal()

 

{
if (rend == null) return;
rend.material = originalMaterial;
}
public void Applyother()
{
if (rend == null) return;
rend.material = otherMaterial;
}

// Start is called before the first frane update
void start()
{

rend = GetComponent<Renderer>() ;

}
}