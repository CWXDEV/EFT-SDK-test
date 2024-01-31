using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.Weather
{
	// Token: 0x02001DE7 RID: 7655
	[CreateAssetMenu]
	public class FogRemapData : ScriptableObject
	{
		// Token: 0x170018DE RID: 6366
		// (get) Token: 0x06009D8F RID: 40335 RVA: 0x00002050 File Offset: 0x00000250
		public int HourCount
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170018DF RID: 6367
		// (get) Token: 0x06009D90 RID: 40336 RVA: 0x00002050 File Offset: 0x00000250
		public int OriginalFogValueCount
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x140001EF RID: 495
		// (add) Token: 0x06009D91 RID: 40337 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06009D92 RID: 40338 RVA: 0x00002050 File Offset: 0x00000250
		public event Action OnChange
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x170018E0 RID: 6368
		// (get) Token: 0x06009D93 RID: 40339 RVA: 0x00002050 File Offset: 0x00000250
		public List<ValueTuple<int, int>> LastUsedForInterpolateRecords
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06009D94 RID: 40340 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public float GetHour(int index)
		{
			throw null;
		}

		// Token: 0x06009D95 RID: 40341 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetHour(int index, float value)
		{
			throw null;
		}

		// Token: 0x06009D96 RID: 40342 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(float hour, out List<FogRemapRecord> left, out List<FogRemapRecord> right, out int leftHourIdx, out int rightHourIdx)
		{
			throw null;
		}

		// Token: 0x06009D97 RID: 40343 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool smethod_0(float fog, List<FogRemapRecord> list, out FogRemapRecord low, out FogRemapRecord hi, out int lowFogIdx, out int hiFogIdx)
		{
			throw null;
		}

		// Token: 0x06009D98 RID: 40344 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static float smethod_1(float fog, float hour, float lowFog, float highFog, float leftHour, float rightHour, float leftLow, float leftHigh, float rightLow, float rightHigh)
		{
			throw null;
		}

		// Token: 0x06009D99 RID: 40345 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private FogRemapRecord method_1(float fog, float hour, FogRemapRecord leftLow, FogRemapRecord leftHigh, FogRemapRecord rightLow, FogRemapRecord rightHigh)
		{
			throw null;
		}

		// Token: 0x06009D9A RID: 40346 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public float RemapFogValue(float fog, float hour, out FogRemapRecord interpolatedParameters)
		{
			throw null;
		}

		// Token: 0x06009D9B RID: 40347 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int AddHour(float value)
		{
			throw null;
		}

		// Token: 0x06009D9C RID: 40348 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RemoveHourAt(int index)
		{
			throw null;
		}

		// Token: 0x06009D9D RID: 40349 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int AddOriginalFogValue(float value)
		{
			throw null;
		}

		// Token: 0x06009D9E RID: 40350 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RemoveOriginalFogValueAt(int index)
		{
			throw null;
		}

		// Token: 0x06009D9F RID: 40351 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public float GetOriginalFogValue(int index)
		{
			throw null;
		}

		// Token: 0x06009DA0 RID: 40352 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetOriginalFogValue(int index, float value)
		{
			throw null;
		}

		// Token: 0x06009DA1 RID: 40353 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FogRemapRecord GetRecord(int hourIndex, int originalForValueIndex)
		{
			throw null;
		}

		// Token: 0x06009DA2 RID: 40354 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetRecord(int hourIndex, int originalForValueIndex, FogRemapRecord record)
		{
			throw null;
		}

		// Token: 0x0400A563 RID: 42339
		[HideInInspector]
		[SerializeField]
		private int _hourCount;

		// Token: 0x0400A564 RID: 42340
		[SerializeField]
		[HideInInspector]
		private int _originalFogValueCount;

		// Token: 0x0400A565 RID: 42341
		[SerializeField]
		[HideInInspector]
		private List<FogRemapRecord> _fogRemapRecords;

		// Token: 0x0400A566 RID: 42342
		[CompilerGenerated]
		private Action action_0;

		// Token: 0x0400A567 RID: 42343
		private List<ValueTuple<int, int>> list_0;
	}
}
