using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace AnimationEventSystem
{
	// Token: 0x0200102E RID: 4142
	[Serializable]
	public sealed class EventCondition : ICloneable
	{
		// Token: 0x0600566E RID: 22126 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool smethod_0(EventCondition condition, IAnimator animator)
		{
			throw null;
		}

		// Token: 0x0600566F RID: 22127 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool smethod_1(EventCondition condition, IAnimator animator)
		{
			throw null;
		}

		// Token: 0x06005670 RID: 22128 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool smethod_2(EventCondition condition, IAnimator animator)
		{
			throw null;
		}

		// Token: 0x06005671 RID: 22129 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool smethod_3(EventCondition condition, IAnimator animator)
		{
			throw null;
		}

		// Token: 0x06005672 RID: 22130 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool smethod_4(EventCondition condition, IAnimator animator)
		{
			throw null;
		}

		// Token: 0x06005673 RID: 22131 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool smethod_5(EventCondition condition, IAnimator animator)
		{
			throw null;
		}

		// Token: 0x06005674 RID: 22132 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool smethod_6(EventCondition condition, IAnimator animator)
		{
			throw null;
		}

		// Token: 0x06005675 RID: 22133 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool smethod_7(EventCondition condition, IAnimator animator)
		{
			throw null;
		}

		// Token: 0x06005676 RID: 22134 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool smethod_8(EventCondition condition, IAnimator animator)
		{
			throw null;
		}

		// Token: 0x06005677 RID: 22135 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsSucceed(IAnimator animator)
		{
			throw null;
		}

		// Token: 0x06005678 RID: 22136 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string ToString(IAnimator animator)
		{
			throw null;
		}

		// Token: 0x06005679 RID: 22137 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x0600567A RID: 22138 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public object Clone()
		{
			throw null;
		}

		// Token: 0x0600567B RID: 22139 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Serialize(BinaryWriter writer)
		{
			throw null;
		}

		// Token: 0x0600567C RID: 22140 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Deserialize(BinaryReader reader)
		{
			throw null;
		}

		// Token: 0x0600567D RID: 22141 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x0600567E RID: 22142 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x0600567F RID: 22143 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected bool Equals(EventCondition other)
		{
			throw null;
		}

		// Token: 0x04006294 RID: 25236
		private static readonly EventCondition.Delegate4[] _CONDITION_DELEGATES;

		// Token: 0x04006295 RID: 25237
		public bool BoolValue;

		// Token: 0x04006296 RID: 25238
		public float FloatValue;

		// Token: 0x04006297 RID: 25239
		public int IntValue;

		// Token: 0x04006298 RID: 25240
		public string ParameterName;

		// Token: 0x04006299 RID: 25241
		private int _cachedNameHash;

		// Token: 0x0400629A RID: 25242
		private EventCondition.EConditionType _conditionMode;

		// Token: 0x0400629B RID: 25243
		public EEventConditionParamTypes ConditionParamType;

		// Token: 0x0400629C RID: 25244
		public EEventConditionModes ConditionMode;

		// Token: 0x0200102F RID: 4143
		// (Invoke) Token: 0x06005680 RID: 22144
		private delegate bool Delegate4(EventCondition condition, IAnimator animator);

		// Token: 0x02001030 RID: 4144
		private enum EConditionType
		{
			// Token: 0x0400629E RID: 25246
			None = -1,
			// Token: 0x0400629F RID: 25247
			IntEqual,
			// Token: 0x040062A0 RID: 25248
			IntNotEqual,
			// Token: 0x040062A1 RID: 25249
			IntGreaterThan,
			// Token: 0x040062A2 RID: 25250
			IntLessThan,
			// Token: 0x040062A3 RID: 25251
			IntGreaterEqualThan,
			// Token: 0x040062A4 RID: 25252
			IntLessEqualThan,
			// Token: 0x040062A5 RID: 25253
			FloatGreaterThan,
			// Token: 0x040062A6 RID: 25254
			FloatLessThan,
			// Token: 0x040062A7 RID: 25255
			BoolEqual,
			// Token: 0x040062A8 RID: 25256
			EConditionTypeEnumsCount
		}
	}
}
