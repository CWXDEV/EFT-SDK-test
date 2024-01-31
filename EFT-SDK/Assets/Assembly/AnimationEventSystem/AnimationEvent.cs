using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace AnimationEventSystem
{
	// Token: 0x02001019 RID: 4121
	[Serializable]
	public sealed class AnimationEvent : ICloneable
	{
		// Token: 0x17000D91 RID: 3473
		// (get) Token: 0x0600561B RID: 22043 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600561C RID: 22044 RVA: 0x00002050 File Offset: 0x00000250
		public string FunctionName
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000D92 RID: 3474
		// (get) Token: 0x0600561D RID: 22045 RVA: 0x00002050 File Offset: 0x00000250
		public int FunctionNameHash
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000D93 RID: 3475
		// (get) Token: 0x0600561E RID: 22046 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600561F RID: 22047 RVA: 0x00002050 File Offset: 0x00000250
		public float Time
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06005620 RID: 22048 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsTimeToFire(float previousNormalizedTime, float normalizedTime)
		{
			throw null;
		}

		// Token: 0x06005621 RID: 22049 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsConditionsSucceed(IAnimator animator)
		{
			throw null;
		}

		// Token: 0x06005622 RID: 22050 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public object Clone()
		{
			throw null;
		}

		// Token: 0x06005623 RID: 22051 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Serialize(BinaryWriter writer)
		{
			throw null;
		}

		// Token: 0x06005624 RID: 22052 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Deserialize(BinaryReader reader)
		{
			throw null;
		}

		// Token: 0x06005625 RID: 22053 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x06005626 RID: 22054 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x06005627 RID: 22055 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected bool Equals(AnimationEvent other)
		{
			throw null;
		}

		// Token: 0x04006250 RID: 25168
		public const float MAX_EVENT_TIME = 1f;

		// Token: 0x04006251 RID: 25169
		public AnimationEventParameter Parameter;

		// Token: 0x04006252 RID: 25170
		[SerializeField]
		private string _functionName;

		// Token: 0x04006253 RID: 25171
		[SerializeField]
		private int _functionNameHash;

		// Token: 0x04006254 RID: 25172
		public bool Enabled;

		// Token: 0x04006255 RID: 25173
		[SerializeField]
		private float _time;

		// Token: 0x04006256 RID: 25174
		public List<EventCondition> EventConditions;
	}
}
