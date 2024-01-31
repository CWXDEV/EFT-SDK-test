using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000763 RID: 1891
public class Watch : MonoBehaviour
{
	// Token: 0x170007FB RID: 2043
	// (get) Token: 0x06002C8A RID: 11402 RVA: 0x00002050 File Offset: 0x00000250
	private DateTime DateTime_0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06002C8B RID: 11403 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(TimeSpan timeDifference)
	{
		throw null;
	}

	// Token: 0x06002C8C RID: 11404 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	// Token: 0x04002B22 RID: 11042
	[SerializeField]
	private Transform _hourHand;

	// Token: 0x04002B23 RID: 11043
	[SerializeField]
	private Transform _minuteHand;

	// Token: 0x04002B24 RID: 11044
	[SerializeField]
	private Transform _secondHand;

	// Token: 0x04002B25 RID: 11045
	[SerializeField]
	private AnimationCurve _curve;

	// Token: 0x04002B26 RID: 11046
	private float float_0;

	// Token: 0x04002B27 RID: 11047
	private DateTime dateTime_0;

	// Token: 0x04002B28 RID: 11048
	private TimeSpan timeSpan_0;
}
