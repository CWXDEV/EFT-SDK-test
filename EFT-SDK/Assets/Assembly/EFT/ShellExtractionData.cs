using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT
{
	// Token: 0x02001575 RID: 5493
	public sealed class ShellExtractionData : MonoBehaviour
	{
		// Token: 0x060075CC RID: 30156 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Vector3 GetMisfireAdditionalForce()
		{
			throw null;
		}

		// Token: 0x060075CD RID: 30157 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public float GetMisfireShellForceMultiplier()
		{
			throw null;
		}

		// Token: 0x060075CE RID: 30158 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Vector3 GetShotAdditionalForce()
		{
			throw null;
		}

		// Token: 0x060075CF RID: 30159 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public float GetShotShellForceMultiplier()
		{
			throw null;
		}

		// Token: 0x060075D0 RID: 30160 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Vector3 GetJamAdditionalForce()
		{
			throw null;
		}

		// Token: 0x060075D1 RID: 30161 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public float GetJamShellForceMultiplier()
		{
			throw null;
		}

		// Token: 0x060075D2 RID: 30162 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Vector3 PatronExtractionAdditionalForce()
		{
			throw null;
		}

		// Token: 0x060075D3 RID: 30163 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public float PatronExtractionForceMultiplier()
		{
			throw null;
		}

		// Token: 0x04007BCB RID: 31691
		public ShellExtractionData.ExtractionSettings ShotSettings;

		// Token: 0x04007BCC RID: 31692
		public ShellExtractionData.ExtractionSettings MisfireSettings;

		// Token: 0x04007BCD RID: 31693
		public ShellExtractionData.ExtractionSettings JamSettings;

		// Token: 0x04007BCE RID: 31694
		public ShellExtractionData.ExtractionSettings PatronExtractionSettings;

		// Token: 0x02001576 RID: 5494
		[Serializable]
		public struct ExtractionSettings
		{
			// Token: 0x060075D4 RID: 30164 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public Vector3 GetRandomForce()
			{
				throw null;
			}

			// Token: 0x060075D5 RID: 30165 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public Vector3 GetRandomRotation()
			{
				throw null;
			}

			// Token: 0x04007BCF RID: 31695
			public Vector2 ShellsForceXRange;

			// Token: 0x04007BD0 RID: 31696
			public Vector2 ShellsForceYRange;

			// Token: 0x04007BD1 RID: 31697
			public Vector2 ShellsForceZRange;

			// Token: 0x04007BD2 RID: 31698
			public Vector2 ShellsRotationRangeX;

			// Token: 0x04007BD3 RID: 31699
			public Vector2 ShellsRotationRangeY;

			// Token: 0x04007BD4 RID: 31700
			public Vector2 ShellsRotationRangeZ;

			// Token: 0x04007BD5 RID: 31701
			public float ShellForceMultiplier;
		}
	}
}
