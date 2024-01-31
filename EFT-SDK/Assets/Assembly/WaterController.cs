using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000B8E RID: 2958
[ExecuteInEditMode]
public class WaterController : MonoBehaviour
{
	// Token: 0x06004046 RID: 16454 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	// Token: 0x04004923 RID: 18723
	public Color WaterColor;

	// Token: 0x04004924 RID: 18724
	public Color SpecularColor;

	// Token: 0x04004925 RID: 18725
	[Range(0f, 500f)]
	public float Shininess;

	// Token: 0x04004927 RID: 18727
	private static readonly int int_0;

	// Token: 0x04004928 RID: 18728
	private static readonly int int_1;

	// Token: 0x04004929 RID: 18729
	private static readonly int int_2;

	// Token: 0x0400492A RID: 18730
	private static readonly int int_3;
}
