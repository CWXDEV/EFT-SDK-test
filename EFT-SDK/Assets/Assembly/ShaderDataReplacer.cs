using System;
using UnityEngine;

// Token: 0x0200092F RID: 2351
public class ShaderDataReplacer : MonoBehaviour
{
	// Token: 0x04003627 RID: 13863
	[SerializeField]
	public string _shaderNameToReplaceData;

	// Token: 0x04003628 RID: 13864
	[SerializeField]
	public Cubemap _cubemap;

	// Token: 0x04003629 RID: 13865
	[SerializeField]
	public Color _reflectColor;

	// Token: 0x0400362A RID: 13866
	[SerializeField]
	[Range(0.01f, 10f)]
	public float _specularness;

	// Token: 0x0400362B RID: 13867
	[Range(0.01f, 10f)]
	[SerializeField]
	public float _glossness;
}
