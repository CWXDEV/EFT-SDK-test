using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.Communications;
using UnityEngine;

namespace EFT.UI.Chat
{
	// Token: 0x02002E88 RID: 11912
	public sealed class ProfileEventsWindow : Window<GClass3088>
	{
		// Token: 0x0600EB1C RID: 60188 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Awake()
		{
			throw null;
		}

		// Token: 0x0600EB1D RID: 60189 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GClass3088 Show(IEnumerable<ProfileChangeEvent> profileEvents)
		{
			throw null;
		}

		// Token: 0x0600EB1E RID: 60190 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(IEnumerable<ProfileChangeEvent> events)
		{
			throw null;
		}

		// Token: 0x0600EB1F RID: 60191 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3()
		{
			throw null;
		}

		// Token: 0x0600EB20 RID: 60192 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4(ProfileChangeEvent item, ProfileEventView view)
		{
			throw null;
		}

		// Token: 0x0600EB21 RID: 60193 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5(ProfileChangeEvent profileEvent)
		{
			throw null;
		}

		// Token: 0x0400F014 RID: 61460
		[SerializeField]
		private Transform _eventsList;

		// Token: 0x0400F015 RID: 61461
		[SerializeField]
		private ProfileEventView _eventViewTemplate;

		// Token: 0x0400F016 RID: 61462
		[SerializeField]
		private DefaultUIButton _applyAllButton;

		// Token: 0x0400F017 RID: 61463
		[SerializeField]
		private DefaultUIButton _cancelButton;

		// Token: 0x0400F018 RID: 61464
		private IEnumerable<ProfileChangeEvent> ienumerable_0;

		// Token: 0x02002E89 RID: 11913
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2921
		{
			// Token: 0x0600EB22 RID: 60194 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(ProfileChangeEvent profileEvent)
			{
				throw null;
			}

			// Token: 0x0400F019 RID: 61465
			public static readonly ProfileEventsWindow.Class2921 class2921_0;

			// Token: 0x0400F01A RID: 61466
			public static Func<ProfileChangeEvent, bool> func_0;
		}
	}
}
