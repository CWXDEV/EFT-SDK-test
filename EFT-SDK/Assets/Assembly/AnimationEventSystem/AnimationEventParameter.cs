using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace AnimationEventSystem
{
	// Token: 0x0200101C RID: 4124
	[Serializable]
	public sealed class AnimationEventParameter : ICloneable, IAnimatorEventParameter
	{
		// Token: 0x17000D94 RID: 3476
		// (get) Token: 0x06005629 RID: 22057 RVA: 0x00002050 File Offset: 0x00000250
		bool IAnimatorEventParameter.BoolParam
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000D95 RID: 3477
		// (get) Token: 0x0600562A RID: 22058 RVA: 0x00002050 File Offset: 0x00000250
		float IAnimatorEventParameter.FloatParam
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000D96 RID: 3478
		// (get) Token: 0x0600562B RID: 22059 RVA: 0x00002050 File Offset: 0x00000250
		int IAnimatorEventParameter.IntParam
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000D97 RID: 3479
		// (get) Token: 0x0600562C RID: 22060 RVA: 0x00002050 File Offset: 0x00000250
		string IAnimatorEventParameter.StringParam
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000D98 RID: 3480
		// (get) Token: 0x0600562D RID: 22061 RVA: 0x00002050 File Offset: 0x00000250
		EAnimationEventParamType IAnimatorEventParameter.ParamType
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600562E RID: 22062 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public object Clone()
		{
			throw null;
		}

		// Token: 0x0600562F RID: 22063 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Serialize(BinaryWriter writer)
		{
			throw null;
		}

		// Token: 0x06005630 RID: 22064 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Deserialize(BinaryReader reader)
		{
			throw null;
		}

		// Token: 0x06005631 RID: 22065 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x06005632 RID: 22066 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public object GetParameter()
		{
			throw null;
		}

		// Token: 0x06005633 RID: 22067 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string GetSelectedParameterFieldName()
		{
			throw null;
		}

		// Token: 0x06005634 RID: 22068 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x06005635 RID: 22069 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x06005636 RID: 22070 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected bool Equals(AnimationEventParameter other)
		{
			throw null;
		}

		// Token: 0x0400625D RID: 25181
		public bool BoolParam;

		// Token: 0x0400625E RID: 25182
		public float FloatParam;

		// Token: 0x0400625F RID: 25183
		public int IntParam;

		// Token: 0x04006260 RID: 25184
		public string StringParam;

		// Token: 0x04006261 RID: 25185
		public EAnimationEventParamType ParamType;
	}
}
