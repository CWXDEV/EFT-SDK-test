using System;
using System.Runtime.CompilerServices;
using Comfort.Common;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x02002AD3 RID: 10963
	public sealed class ReportPanel : UIElement
	{
		// Token: 0x140002FD RID: 765
		// (add) Token: 0x0600D9E8 RID: 55784 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600D9E9 RID: 55785 RVA: 0x00002050 File Offset: 0x00000250
		public event Action OnShowPlayerProfileButtonClick
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

		// Token: 0x0600D9EA RID: 55786 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600D9EB RID: 55787 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(ISession session)
		{
			throw null;
		}

		// Token: 0x0600D9EC RID: 55788 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x0600D9ED RID: 55789 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(EReportType reportType)
		{
			throw null;
		}

		// Token: 0x0600D9EE RID: 55790 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x0600D9EF RID: 55791 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0600D9F0 RID: 55792 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2()
		{
			throw null;
		}

		// Token: 0x0600D9F1 RID: 55793 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3()
		{
			throw null;
		}

		// Token: 0x0600D9F2 RID: 55794 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4()
		{
			throw null;
		}

		// Token: 0x0600D9F3 RID: 55795 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5()
		{
			throw null;
		}

		// Token: 0x0600D9F4 RID: 55796 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6(IResult result)
		{
			throw null;
		}

		// Token: 0x0400DCD4 RID: 56532
		[SerializeField]
		private Button _reportDropdownButton;

		// Token: 0x0400DCD5 RID: 56533
		[SerializeField]
		private Button _bugAbuseReportButton;

		// Token: 0x0400DCD6 RID: 56534
		[SerializeField]
		private Button _cheatUseReportButton;

		// Token: 0x0400DCD7 RID: 56535
		[SerializeField]
		private Button _offensiveNicknameButton;

		// Token: 0x0400DCD8 RID: 56536
		[SerializeField]
		private Button _showPlayerProfileButton;

		// Token: 0x0400DCD9 RID: 56537
		[SerializeField]
		private GameObject _reportDropdownPanel;

		// Token: 0x0400DCDA RID: 56538
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x0400DCDB RID: 56539
		private bool bool_0;

		// Token: 0x0400DCDC RID: 56540
		private ISession ginterface145_0;

		// Token: 0x0400DCDD RID: 56541
		[CompilerGenerated]
		private Action action_0;
	}
}
