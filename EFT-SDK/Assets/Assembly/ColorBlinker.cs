using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020009B5 RID: 2485
public class ColorBlinker : MonoBehaviour
{
	// Token: 0x0600377C RID: 14204 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	// Token: 0x040038FB RID: 14587
	[SerializeField]
	private Image _target;

	// Token: 0x040038FC RID: 14588
	[SerializeField]
	private AnimationCurve _curve;

	// Token: 0x040038FD RID: 14589
	[SerializeField]
	private float _speed;

	// Token: 0x040038FE RID: 14590
	public Color StartColor;

	// Token: 0x040038FF RID: 14591
	public Color EndColor;
}
