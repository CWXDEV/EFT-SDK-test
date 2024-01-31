using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

namespace EFT.UI
{
	// Token: 0x02002B6B RID: 11115
	public abstract class TaskLabelsTooltip : Tooltip
	{
		// Token: 0x0600DBAC RID: 56236 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void Show(string title, int labelsCount)
		{
			throw null;
		}

		// Token: 0x0600DBAD RID: 56237 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(int labelsCount)
		{
			throw null;
		}

		// Token: 0x0400DF75 RID: 57205
		[SerializeField]
		private TMP_Text _taskTitle;

		// Token: 0x0400DF76 RID: 57206
		[SerializeField]
		[FormerlySerializedAs("_rewardLabelTemplate")]
		private GameObject _labelTemplate;

		// Token: 0x0400DF77 RID: 57207
		[SerializeField]
		[FormerlySerializedAs("_rewardLabelsParent")]
		private Transform _labelsParent;

		// Token: 0x0400DF78 RID: 57208
		[SerializeField]
		[FormerlySerializedAs("_rewardLabelsPool")]
		protected List<TMP_Text> _labelsPool;
	}
}
