using System;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;

// Token: 0x0200047D RID: 1149
public class BotPlanDropItem : GClass362
{
	// Token: 0x06001BBE RID: 7102 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Activate()
	{
		throw null;
	}

	// Token: 0x06001BBF RID: 7103 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool WantDropItem()
	{
		throw null;
	}

	// Token: 0x06001BC0 RID: 7104 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ManualUpdate()
	{
		throw null;
	}

	// Token: 0x06001BC1 RID: 7105 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x06001BC2 RID: 7106 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1()
	{
		throw null;
	}

	// Token: 0x04001790 RID: 6032
	private const float DROP_ITEM_PERIOD = 30f;

	// Token: 0x04001791 RID: 6033
	private const float FIND_ITEM_PERIOD = 30f;

	// Token: 0x04001792 RID: 6034
	private float _period;

	// Token: 0x04001793 RID: 6035
	private float _periodGo;

	// Token: 0x04001794 RID: 6036
	private Vector3 _pointToDrop;

	// Token: 0x04001795 RID: 6037
	[CanBeNull]
	private string _itemToDrop;

	// Token: 0x04001796 RID: 6038
	private float _nextPossibleDropTime;

	// Token: 0x04001797 RID: 6039
	private bool _havePlace;

	// Token: 0x04001798 RID: 6040
	private float _comeTime;

	// Token: 0x0200047E RID: 1150
	[CompilerGenerated]
	[Serializable]
	private sealed class Class230
	{
		// Token: 0x06001BC3 RID: 7107 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(AIPlaceInfo x)
		{
			throw null;
		}

		// Token: 0x04001799 RID: 6041
		public static readonly BotPlanDropItem.Class230 class230_0;

		// Token: 0x0400179A RID: 6042
		public static Func<AIPlaceInfo, bool> func_0;
	}
}
